using System.Net.Http.Json;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Orders;

namespace Tavstal.PayPalSDK.Tests;

/// <summary>
/// Represents an example for refunding a PayPal order using the PayPal SDK.
/// </summary>
public class RefundOrderExample
{
    private readonly PayPalHttpClient _client; // The PayPal HTTP client used to send requests.
    private readonly string _currencyCode; // The currency code for the order.

    /// <summary>
    /// Initializes a new instance of the <see cref="RefundOrderExample"/> class.
    /// </summary>
    /// <param name="client">The PayPal HTTP client used to send requests.</param>
    /// <param name="currencyCode">The currency code for the order.</param>
    public RefundOrderExample(PayPalHttpClient client, string currencyCode)
    {
        _client = client;
        _currencyCode = currencyCode;
    }

    /// <summary>
    /// Executes the process of refunding a PayPal order.
    /// </summary>
    /// <param name="orderId">The ID of the order to refund.</param>
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

                // Find the refund link in the order response.
                var refundLink = orderResponse.Links.Find(x => x.Rel == "refund");
                if (refundLink == null)
                {
                    Console.WriteLine("No refund link found in the order response.");
                    return false;
                }

                // Log the refund link, typically used to initiate the refund process.
                Console.WriteLine("Refund link found: " + refundLink.Href);
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