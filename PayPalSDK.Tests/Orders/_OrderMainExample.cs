using Tavstal.PayPalSDK.Http;

namespace Tavstal.PayPalSDK.Tests.Orders;

/// <summary>
/// Provides an example for interacting with PayPal orders.
/// </summary>
public static class _OrderMainExample
{
    /// <summary>
    /// Executes the main example workflow for managing PayPal orders.
    /// </summary>
    /// <param name="client">The PayPal HTTP client used for API requests.</param>
    /// <param name="currencyCode">The currency code for the orders.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public static async Task PlayAsync(PayPalHttpClient client, string currencyCode)
    {
        bool active = true;
        while (active)
        {
            // Display menu options
            Console.WriteLine("# ORDERS #");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Create Order");
            Console.WriteLine("2. Complete Order");
            Console.WriteLine("3. Get Order");
            Console.WriteLine("4. Refund Order");
            Console.WriteLine("0. Go back.");
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
                    // Exit to main menu
                    active = false;
                    continue;
                }
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
            Console.ReadKey();
            Console.Clear();
        }
    }
}