using Bff;
using Bff.Services;
using Confluent.Kafka;
using Core.Application.Interfaces;
using Core.Application.Interfaces.Bff;
using Core.Application.Interfaces.Repositories;
using Core.Application.Services;
using KafkaAdapter;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Mongo;
using Mongo.Mapper;
using Mongo.Repositories;

Console.WriteLine("Start consuming events ...");

var builder = Host.CreateDefaultBuilder()
    .ConfigureAppConfiguration((context, config) =>
    {
        // Load the appsettings.json file
        config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

        // Add User Secrets if in development environment
 
            config.AddUserSecrets<Program>(); // or specify the UserSecretsId if necessary
        
    })
    .ConfigureServices((hostContext, services) =>
    {
        var configuration = hostContext.Configuration;

        // Register Kafka Consumer
        var configConsumer = new ConsumerConfig
        {
            BootstrapServers = "localhost:29092",
            GroupId = "match-consumer-group"
        };

        var consumer = new ConsumerBuilder<Null, string>(configConsumer).Build();

        // Register MongoDB services
        services.ConfigureMongoDb(configuration);
        services.ConfigureBffServices(configuration);

        // Register Kafka Consumer and other services
        services.AddSingleton<IConsumer<Null, string>>(consumer);
        services.AddSingleton<IMatchJobService, MatchJobService>();
        services.AddScoped<IMatchBffService, MatchBffService>();
        services.AddHostedService<KafkaConsumer>();
        services.AddHttpClient();
        services.AddScoped<IMatchRepository, MatchRepository>();
        services.AddAutoMapper(typeof(MappingProfile));
    });

var host = builder.Build();
await host.RunAsync();
