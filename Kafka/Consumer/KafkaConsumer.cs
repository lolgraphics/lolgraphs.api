using Confluent.Kafka;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Core.Application.Interfaces;

namespace KafkaAdapter
{
    public class KafkaConsumer(IServiceProvider serviceProvider, IConsumer<Null, string> consumer, ILogger<KafkaConsumer> logger) : BackgroundService
    {
        private readonly IServiceProvider _serviceProvider = serviceProvider;
        private readonly IConsumer<Null, string> _consumer = consumer;
        private readonly ILogger<KafkaConsumer> _logger = logger;
        private const string TopicName = "match-job-topic";

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _consumer.Subscribe(TopicName);

            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    var result = _consumer.Consume(stoppingToken);

                    if (result != null)
                    {
                        using (var scope = _serviceProvider.CreateScope())
                        {
                            var matchJobService = scope.ServiceProvider.GetRequiredService<IMatchJobService>();
                            await matchJobService.ProcessMatchesAsync(result.Message.Value);
                            _logger.LogInformation($"Processed message: Data: '{DateTime.Now.ToString()}'", result.Message.Value);
                        }
                    }
                }
                catch (ConsumeException e)
                {
                    // Log consume exception
                    _logger.LogError(e, "Error consuming message: {Reason}", e.Error.Reason);
                }
                catch (Exception ex)
                {
                    // Log unexpected exceptions
                    _logger.LogError(ex, "Unexpected error occurred while consuming messages.");
                }
            }
        }


        public override void Dispose()
        {
            _consumer.Close();
            base.Dispose();
        }
    }
}
