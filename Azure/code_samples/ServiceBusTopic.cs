using Microsoft.ServiceBus.Messaging;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topics
{
    public class Program
    {
        private static readonly string _connectionString = ConfigurationManager.AppSettings["TopicsConnectionString"];
        private static readonly string _topic = "mytopic";

        public static void Main(string[] args)
        {
            SendMessage("Hello World!");
            ReadMessage();
            Console.ReadKey();
        }

        private static void SendMessage(string message)
        {
            var topicClient = TopicClient.CreateFromConnectionString(_connectionString, _topic);
            var msg = new BrokeredMessage(message);

            topicClient.Send(msg);
        }

        private static void ReadMessage()
        {
            var subscriptionClient = SubscriptionClient.CreateFromConnectionString(_connectionString, _topic, "ConsoleApp");

            subscriptionClient.OnMessage(message => {
                Console.WriteLine(message.GetBody<string>());
            });
        }
    }
}
