using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;

namespace Azure_Storage_Blob
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var storageAccount = CloudStorageAccount.Parse(
                CloudConfigurationManager.GetSetting("StorageConnectionString"));

            var blobClient = storageAccount.CreateCloudBlobClient();
            var container = blobClient.GetContainerReference("images");

            container.CreateIfNotExists(BlobContainerPublicAccessType.Blob);

            Console.WriteLine("Container with name images created.");

            var filename = "azure-network-architecture.PNG";
            var path = "images/azure-network-architecture.PNG";

            UploadFile(container, filename, path);
            DownloadFile(container, filename, path);
            CopyFile(container, filename, $"copy-{filename}");

            var hieracyFilename = $"third-party/{filename}";
            UploadFile(container, hieracyFilename, path);

            SetMetadata(container);
            GetMetaData(container);

            Console.ReadKey();
        }

        private static void UploadFile(CloudBlobContainer container, string filename, string path)
        {
            var blockBlob = container.GetBlockBlobReference(filename);

            using (var filestream = System.IO.File.OpenRead(path))
            {
                blockBlob.UploadFromStream(filestream);
            }
        }

        private static void DownloadFile(CloudBlobContainer container, string filename, string path)
        {
            var blockBlob = container.GetBlockBlobReference(filename);

            using (var filestream = System.IO.File.OpenWrite(path))
            {
                blockBlob.DownloadToStream(filestream);
            }
        }

        private static void CopyFile(CloudBlobContainer container, string originalFilename, string newFilename)
        {
            var blockBlob = container.GetBlockBlobReference(originalFilename);
            var blockBlobCopy = container.GetBlockBlobReference(newFilename);

            var callback = new AsyncCallback(o => Console.WriteLine("Blob copy completed!"));

            blockBlobCopy.BeginStartCopy(blockBlob.Uri, callback, null);
        }

        private static void SetMetadata(CloudBlobContainer container)
        {
            container.Metadata.Clear();
            container.Metadata.Add("Owner", "Anders");
            container.Metadata["Updated"] = DateTime.Now.ToString();
            container.SetMetadata();
        }

        private static void GetMetaData(CloudBlobContainer container)
        {
            container.FetchAttributes();
            Console.WriteLine("Container Metadata: \n");
            foreach(var data in container.Metadata)
            {
                Console.WriteLine($"{data.Key}: {data.Value}");
            }
        }
    }
}
