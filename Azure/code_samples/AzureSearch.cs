using Microsoft.Azure.Search;
using Microsoft.Azure.Search.Models;
using System.Web.Mvc;

namespace AzureSearchWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var searchServiceName = "anbora";
            var apiKey = "ECBCD81AB8551C4B2884C40276C3D913";

            var searchClient = new SearchServiceClient(searchServiceName, new SearchCredentials(apiKey));
            var indexClient = searchClient.Indexes.GetClient("aw-index");

            var parameters = new SearchParameters()
            {
                SearchMode = SearchMode.All
            };

            var docs = indexClient.Documents.Search("A Bike Store", parameters);

            return Json(docs.Results, JsonRequestBehavior.AllowGet);
        }
    }
}
