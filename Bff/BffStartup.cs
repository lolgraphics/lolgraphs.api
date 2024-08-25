namespace Bff
{
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    public static class BffStartup
    {
        public static void ConfigureBffServices(this IServiceCollection services, IConfiguration configuration)
        {

             var riotApiSettings = configuration.GetSection("RiotApi") 
                                ?? throw new InvalidOperationException("RIOT_API_TOKEN environment variable is not set.");

            var americasApi = riotApiSettings.GetValue<string>("AmericasApi")
                                ?? throw new InvalidOperationException("AmericasApi environment variable is not set.");

            var br1Api = riotApiSettings.GetValue<string>("Br1Api")
                                ?? throw new InvalidOperationException("br1Api environment variable is not set.");

            var riotApiToken = configuration["RIOT_API_TOKEN"]
                                ?? throw new InvalidOperationException("AmericasApi environment variable is not set.");




            services.AddHttpClient("AmericasApi", client =>
            {
                client.BaseAddress = new Uri(americasApi);
                client.DefaultRequestHeaders.Add("X-Riot-Token", riotApiToken);
            });
            
            services.AddHttpClient("RiotApiBr1", client =>
            {
                client.BaseAddress = new Uri(br1Api);
                client.DefaultRequestHeaders.Add("X-Riot-Token", riotApiToken);
            });
        }
    }
}
