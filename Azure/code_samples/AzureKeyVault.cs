using Microsoft.Azure.KeyVault;
using Microsoft.Azure.Services.AppAuthentication;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace KeyVault.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            var azureServiceTokenProvider = new AzureServiceTokenProvider();

            var keyVaultClient = new KeyVaultClient(
                new KeyVaultClient.AuthenticationCallback(azureServiceTokenProvider.KeyVaultTokenCallback));

            var secret = await keyVaultClient.GetSecretAsync("https://anbora.vault.azure.net/secrets/MySecret")
            .ConfigureAwait(false);

            ViewBag.Secret = $"Secret: {secret.Value}";

            return View();
        }
    }
}
