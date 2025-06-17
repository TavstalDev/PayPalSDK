using System.Net.Http.Json;
using System.Text.Json;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Orders;

namespace Tavstal.PayPalSDK.Tests;

/// <summary>
/// Represents an example for completing a PayPal order using the PayPal SDK.
/// </summary>
public class CompleteOrderExample
{
    private readonly PayPalHttpClient _client; // The PayPal HTTP client used to send requests.
    private readonly string _currencyCode; // The currency code for the order.

    /// <summary>
    /// Initializes a new instance of the <see cref="CompleteOrderExample"/> class.
    /// </summary>
    /// <param name="client">The PayPal HTTP client used to send requests.</param>
    /// <param name="currencyCode">The currency code for the order.</param>
    public CompleteOrderExample(PayPalHttpClient client, string currencyCode)
    {
        _client = client;
        _currencyCode = currencyCode;
    }

    /// <summary>
    /// Executes the process of completing a PayPal order.
    /// </summary>
    /// <param name="orderId">The ID of the order to complete.</param>
    /// <returns>
    /// A task that represents the asynchronous operation.
    /// The task result contains a boolean indicating success or failure.
    /// </returns>
    public async Task<bool> DoAsync(string orderId)
    {
        // Create the request to capture the order.
        var request = new OrderCaptureRequest(orderId, new OrderCaptureRequestBody());
        var response = await _client.SendAsync(request);

        if (response.IsSuccessStatusCode)
        {
            // Deserialize the response and check for success.
            var orderResponse = await response.Content.ReadFromJsonAsync<OrderBody>();
            if (orderResponse != null)
            {
                Console.WriteLine($"Order completed successfully: {orderResponse.Id}");

                // Log the response body in a formatted JSON string.
                Console.WriteLine($"Body: \n" + JsonSerializer.Serialize(orderResponse,
                    new JsonSerializerOptions
                    {
                        WriteIndented = true
                    }));
                return true;
            }

            Console.WriteLine("Failed to deserialize order response.");
            return false;
        }

        // Return false if the response indicates failure.
        return false;
    }
}