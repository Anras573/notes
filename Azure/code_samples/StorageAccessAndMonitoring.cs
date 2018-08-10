using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace StorageAccessAndMonitoring.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var storageAccount = CloudStorageAccount.Parse(
                CloudConfigurationManager.GetSetting("StorageConnectionString"));

            var blobClient = storageAccount.CreateCloudBlobClient();

            var container = blobClient.GetContainerReference("images");

            var blobs = new List<BlobImage>();

            foreach (var blob in container.ListBlobs())
            {
                if (blob.GetType() == typeof(CloudBlockBlob))
                {
                    //var sas = GetSASToken(storageAccount);
                    var sas = container.GetSharedAccessSignature(null, "MySAP");
                    blobs.Add(new BlobImage { BlobUri = blob.Uri.ToString() + sas });
                }
            }

            return View(blobs);
        }

        private static string GetSASToken(CloudStorageAccount storageAccount)
        {
            var policy = new SharedAccessAccountPolicy
            {
                Permissions = SharedAccessAccountPermissions.Read | SharedAccessAccountPermissions.Write,
                Services = SharedAccessAccountServices.Blob,
                ResourceTypes = SharedAccessAccountResourceTypes.Object,
                SharedAccessExpiryTime = DateTime.Now.AddMinutes(30),
                Protocols = SharedAccessProtocol.HttpsOnly
            };

            return storageAccount.GetSharedAccessSignature(policy);
        }
    }

    public class BlobImage
    {
        public string BlobUri { get; set; }
    }
}
