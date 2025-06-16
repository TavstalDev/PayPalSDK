using System.Text;
using Newtonsoft.Json.Linq;
using Tavstal.PayPalSDK.Config;
using Tavstal.PayPalSDK.Http;

namespace Tavstal.PayPalSDK.Tests;

class Program
{
    /// <summary>
    /// Entry point for the example application.
    /// </summary>
    /// <param name="args">Command-line arguments.</param>
    static async Task Main(string[] args)
    {
        // 0. Read secrets
        byte[] fileBytes = await File.ReadAllBytesAsync("../../../secrets.json");
        string rawFileJSON = Encoding.UTF8.GetString(fileBytes);
        JObject secrets = JObject.Parse(rawFileJSON);

        var currencyCode = secrets["Currency"]?.ToString();
        var clientId = secrets["ClientId"];
        var clientSecret = secrets["ClientSecret"];
        
        if (clientId == null || clientSecret == null)
        {
            Console.WriteLine("Please provide ClientId and ClientSecret in secrets.json");
            return;
        }
        
        if (string.IsNullOrEmpty(currencyCode))
        {
            Console.WriteLine("Please provide CurrencyCode in secrets.json");
            return;
        }
        
        // 1. Create client
        PayPalHttpClient client = new PayPalHttpClient(new SandboxEnvironment(clientId.ToString(), clientSecret.ToString()));
        
        // Wait for user input before proceeding
        var input = Console.ReadKey();
        

        // Wait for user input before closing the console
        Console.ReadLine();
    }
}