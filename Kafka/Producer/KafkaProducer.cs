using Confluent.Kafka;
using Core.Application.Interfaces;
using Microsoft.Extensions.Logging;

namespace Kafka.Producer
{
    public class KafkaProducer(IProducer<Null, string> producer, ILogger<KafkaProducer> logger) : IKafkaProducer
    {
        private readonly IProducer<Null, string> _producer = producer;
        private readonly ILogger<KafkaProducer> _logger = logger;
        private const string TopicName = "match-job-topic";

        public async Task EnqueueMessageAsync(string puuid)
        {
            var message = new Message<Null, string> { Value = puuid };
            try
            {
                // Produce the message asynchronously
                var deliveryResult = await _producer.ProduceAsync(TopicName, message);
                // Use structured logging
                _logger.LogInformation($"Message '{puuid}' Date: '{DateTime.Now.ToString()}'", message.Value, deliveryResult.TopicPartitionOffset);
            }
            catch (ProduceException<Null, string> e)
            {
                // Log any errors encountered during production
                _logger.LogError(e, "Error producing message to Kafka: {Reason}", e.Error.Reason);
            }
        }
    }
}
