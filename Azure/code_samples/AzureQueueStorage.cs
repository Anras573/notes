using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;
using System;

namespace Queue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var storageAccount = CloudStorageAccount.Parse(
                CloudConfigurationManager.GetSetting("StorageConnectionString"));

            var queueClient = storageAccount.CreateCloudQueueClient();

            var queue = queueClient.GetQueueReference("tasks");

            queue.CreateIfNotExists();
            Console.WriteLine("Queue created");

            var message = new CloudQueueMessage("Hello World");
            var time = new TimeSpan(24, 0, 0);
            queue.AddMessage(message, time);

            var peekedMessage = queue.PeekMessage();
            Console.WriteLine(peekedMessage.AsString);

            var receivedMessage = queue.GetMessage();
            Console.WriteLine(message.AsString);
            queue.DeleteMessage(receivedMessage);
 
            Console.ReadKey();
        }
    }
}
