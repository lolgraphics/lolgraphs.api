using Bff;
using Core.Application.Interfaces;
using Bff.Services;
using Redis.Services;
using Api.Middleware;
using Core.Application.Services;
using Core.Application.Interfaces.Repositories;
using StackExchange.Redis;
using Core.Application.Interfaces.Bff;
using Confluent.Kafka;
using Kafka.Producer;
using DotNetEnv;
using Postgres.Mapper;
using Postgres.Repositories;

Env.Load();

var builder = WebApplication.CreateBuilder(args);

// Add user secrets for configuration
builder.Configuration.AddUserSecrets<Program>();

// Register Redis connection
builder.Services.AddSingleton<IConnectionMultiplexer>(sp =>
{
    var configuration = builder.Configuration.GetConnectionString("Redis")
                         ?? throw new InvalidOperationException("Redis connection string is missing.");

    return ConnectionMultiplexer.Connect(configuration);
});

// Configure Kafka Producer
var producerConfig = new ProducerConfig
{
    BootstrapServers = "localhost:29092"
};

builder.Services.AddSingleton<IProducer<Null, string>>(new ProducerBuilder<Null, string>(producerConfig).Build());


// Register services and dependencies
builder.Services.ConfigureBffServices(builder.Configuration);
builder.Services.ConfigurePostgresDb(builder.Configuration);

// Register Redis and Kafka services
builder.Services.AddTransient<IRedisService, RedisService>();
builder.Services.AddTransient<IKafkaProducer, KafkaProducer>();

// Configure AutoMapper
builder.Services.AddAutoMapper(typeof(MappingProfile));

// Configure BFF services
builder.Services.AddScoped<ISummonerBffService, SummonerBffService>();
builder.Services.AddScoped<IMatchBffService, MatchBffService>();

// Configure Core Services and Repositories
builder.Services.AddScoped<ISummonerService, SummonerService>();
builder.Services.AddScoped<ISummonerRepository, SummonerRepository>();
builder.Services.AddScoped<IMatchRepository, MatchRepository>();
builder.Services.AddScoped<IMatchJobService, MatchJobService>();

// Add controllers and other services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Lolgraphics-API-v1");
    });
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.UseMiddleware<ExceptionMiddleware>();
app.MapControllers();
app.Run();
