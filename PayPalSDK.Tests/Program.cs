using System.Text;
using Newtonsoft.Json.Linq;
using Tavstal.PayPalSDK.Config;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Tests.Orders;
using Tavstal.PayPalSDK.Tests.Payments;
using Tavstal.PayPalSDK.Tests.ProductCatalog;
using Tavstal.PayPalSDK.Tests.Subscriptions;
using Tavstal.PayPalSDK.Tests.Webhooks;

namespace Tavstal.PayPalSDK.Tests;

/// <summary>
/// Represents the main program for interacting with the PayPal SDK.
/// </summary>
class Program
{
    /// <summary>
    /// Entry point for the example application.
    /// </summary>
    /// <param name="args">Command-line arguments.</param>
    static async Task Main(string[] args)
    {
        // 0. Read secrets
        if (!File.Exists("../../../secrets.json"))
        {
            Console.WriteLine("Please create secrets.json file in the root of the project with ClientId, ClientSecret and CurrencyCode.");
            return;
        }
        
        byte[] fileBytes = await File.ReadAllBytesAsync("../../../secrets.json");
        string rawFileJSON = Encoding.UTF8.GetString(fileBytes);
        JObject secrets = JObject.Parse(rawFileJSON);

        // Extract currency code, client ID, and client secret from the secrets file
        var currencyCode = secrets["Currency"]?.ToString();
        var clientId = secrets["ClientId"];
        var clientSecret = secrets["ClientSecret"];

        // Validate client ID and client secret
        if (clientId == null || clientSecret == null)
        {
            Console.WriteLine("Please provide ClientId and ClientSecret in secrets.json");
            return;
        }

        // Validate currency code
        if (string.IsNullOrEmpty(currencyCode))
        {
            Console.WriteLine("Please provide CurrencyCode in secrets.json");
            return;
        }

        // 1. Create PayPal client using sandbox environment
        PayPalHttpClient client = new PayPalHttpClient(new SandboxEnvironment(clientId.ToString(), clientSecret.ToString()));

        // Wait for user input before proceeding
        bool active = true;
        while (active)
        {
            // Display menu options
            Console.WriteLine("# MAIN MENU #");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Orders");
            Console.WriteLine("2. Payments");
            Console.WriteLine("3. Product Catalog");
            Console.WriteLine("4. Subscriptions");
            Console.WriteLine("5. Webhooks");
            Console.WriteLine("0. Exit.");
            string? input = Console.ReadLine();

            // Validate user input
            if (!int.TryParse(input, out int inputInt))
            {
                Console.WriteLine("Please provide valid integer number.");
                continue;
            }

            // Handle menu selection
            switch (inputInt)
            {
                case 0:
                {
                    // Exit
                    active = false;
                    continue;
                }
                case 1:
                {
                    Console.Clear();
                    await _OrderMainExample.PlayAsync(client, currencyCode);
                    break;
                }
                case 2:
                {
                    Console.Clear();
                    await _PaymentMainExample.PlayAsync(client, currencyCode);
                    break;
                }
                case 3:
                {
                    Console.Clear();
                    await _ProductCatalogMainExample.PlayAsync(client,currencyCode);
                    break;
                }
                case 4:
                {
                    Console.Clear();
                    await _SubscriptionMainExample.PlayAsync(client,currencyCode);
                    break;
                }
                case 5:
                {
                    Console.Clear();
                    await _WebhookMainExample.PlayAsync(client, currencyCode);
                    break;
                }
            }
            
            Console.Clear();
        }
    }
}