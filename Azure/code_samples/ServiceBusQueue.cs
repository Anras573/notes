using System;
using Microsoft.ServiceBus.Messaging;

namespace ServiceBusQueue
{
    public class Program
    {
        private static string _conn = "<Queue connectionstring>";
        private static QueueClient _client = QueueClient.CreateFromConnectionString(_conn);

        public static void Main(string[] args)
        {
            SendMessage("Hellow World!");
            Console.ReadKey();
        }

        public static void SendMessage(string msg)
        {
            var message = new BrokeredMessage(msg);
            _client.Send(message);
        }

        public static void ReadMessage()
        {
            var options = new OnMessageOptions
            {
                AutoComplete = false
            };

            _client.OnMessage(m =>
            {
                var msg = m.GetBody<string>();

                if (msg == "Hello World!")
                {
                    Console.WriteLine(msg);
                    m.Complete();
                }

            }, options);
        }
    }
}
