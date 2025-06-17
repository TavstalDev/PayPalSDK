using System.Net.Http.Json;
using System.Text.Json;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Orders;

namespace Tavstal.PayPalSDK.Tests;

/// <summary>
/// Represents an example for retrieving PayPal order details using the PayPal SDK.
/// </summary>
public class GetOrderExample
{
    private readonly PayPalHttpClient _client; // The PayPal HTTP client used to send requests.
    private readonly string _currencyCode; // The currency code for the order.

    /// <summary>
    /// Initializes a new instance of the <see cref="GetOrderExample"/> class.
    /// </summary>
    /// <param name="client">The PayPal HTTP client used to send requests.</param>
    /// <param name="currencyCode">The currency code for the order.</param>
    public GetOrderExample(PayPalHttpClient client, string currencyCode)
    {
        _client = client;
        _currencyCode = currencyCode;
    }

    /// <summary>
    /// Executes the process of retrieving PayPal order details.
    /// </summary>
    /// <param name="orderId">The ID of the order to retrieve details for.</param>
    /// <returns>
    /// A task that represents the asynchronous operation.
    /// The task result contains a boolean indicating success or failure.
    /// </returns>
    public async Task<bool> DoAsync(string orderId)
    {
        // Create the request to get order details.
        var request = new OrderGetDetailsRequest(orderId);
        var response = await _client.SendAsync(request);

        if (response.IsSuccessStatusCode)
        {
            // Deserialize the response and check for success.
            var orderResponse = await response.Content.ReadFromJsonAsync<OrderBody>();
            if (orderResponse != null)
            {
                Console.WriteLine($"Order details retrieved successfully: {orderResponse.Id}");

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

        // Log the error details if the request fails.
        Console.WriteLine($"Failed to retrieve order details. Status Code: {response.StatusCode}");
        return false;
    }
}