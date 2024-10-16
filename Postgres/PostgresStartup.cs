using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Postgres.Configuration;

public static class PostgresStartup
{
    public static void ConfigurePostgresDb(this IServiceCollection services, IConfiguration configuration)
    {
        // Registre PostgresSettings
        services.Configure<PostgresSettings>(options =>
        {
            options.ConnectionString = configuration["DB_CONNECTION"]
                ?? throw new InvalidOperationException("PostgreSQL connection string is missing.");
        });

        // Adicione o DbContext como scoped
        services.AddDbContext<PostgresDbContext>((serviceProvider, options) =>
        {
            var postgresSettings = serviceProvider.GetRequiredService<IOptions<PostgresSettings>>().Value;
            options.UseNpgsql(postgresSettings.ConnectionString);
        });
    }
}
