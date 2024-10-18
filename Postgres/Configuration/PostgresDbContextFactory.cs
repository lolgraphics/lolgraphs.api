using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Postgres.Configuration;
using System.IO;

public class PostgresDbContextFactory : IDesignTimeDbContextFactory<PostgresDbContext>
{
    public PostgresDbContext CreateDbContext()
    {
        return CreateDbContext(null); // Chame o método com null para o parâmetro adicional
    }

    public PostgresDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<PostgresDbContext>();

        // Use a configuração diretamente aqui, por exemplo, a partir de um arquivo appsettings.json
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        optionsBuilder.UseNpgsql(configuration.GetConnectionString("PostgresConnection"));

        return new PostgresDbContext(optionsBuilder.Options);
    }
}
