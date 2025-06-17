using System.Text;
using Newtonsoft.Json.Linq;
using Tavstal.PayPalSDK.Config;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Tests.Orders;

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
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Create Order");
            Console.WriteLine("2. Complete Order");
            Console.WriteLine("3. Get Order");
            Console.WriteLine("4. Refund Order");
            Console.WriteLine("Or press Escape to exit.");
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
                case 1:
                {
                    // Create Order
                    var createOrderExample = new CreateOrderExample(client, currencyCode);
                    await createOrderExample.DoAsync();
                    break;
                }
                case 2:
                {
                    // Complete Order
                    var completeOrderExample = new CompleteOrderExample(client, currencyCode);
                    Console.WriteLine("Please provide Order ID to complete:");
                    string? orderId = Console.ReadLine();
                    if (string.IsNullOrEmpty(orderId))
                    {
                        Console.WriteLine("Order ID cannot be empty.");
                        continue;
                    }

                    await completeOrderExample.DoAsync(orderId);
                    break;
                }
                case 3:
                {
                    // Get Order
                    var getOrderExample = new GetOrderExample(client, currencyCode);
                    Console.WriteLine("Please provide Order ID to get details:");
                    string? orderId = Console.ReadLine();
                    if (string.IsNullOrEmpty(orderId))
                    {
                        Console.WriteLine("Order ID cannot be empty.");
                        continue;
                    }

                    await getOrderExample.DoAsync(orderId);
                    break;
                }
                case 4:
                {
                    // Refund Order
                    var refundOrderExample = new RefundOrderExample(client, currencyCode);
                    Console.WriteLine("Please provide Order ID to refund:");
                    string? orderId = Console.ReadLine();
                    if (string.IsNullOrEmpty(orderId))
                    {
                        Console.WriteLine("Order ID cannot be empty.");
                        continue;
                    }

                    await refundOrderExample.DoAsync(orderId);
                    break;
                }
            }

            // Wait for user input before continuing
            Console.WriteLine("Press any key to continue.");
            var key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape)
                active = false;
            else
                Console.Clear();
        }
    }
}