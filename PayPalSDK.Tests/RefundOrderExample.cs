using System.Net.Http.Json;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Orders;

namespace Tavstal.PayPalSDK.Tests;

public class RefundOrderExample
{
    private readonly PayPalHttpClient _client;
    private readonly string _currencyCode;
    
    public RefundOrderExample(PayPalHttpClient client, string currencyCode)
    {
        _client = client;
        _currencyCode = currencyCode;
    }
    
    public async Task<bool> DoAsync(string orderId)
    {
        var request = new OrderGetDetailsRequest(orderId);
        var response = await _client.SendAsync(request);
        
        if (response.IsSuccessStatusCode)
        {
            var orderResponse = await response.Content.ReadFromJsonAsync<OrderBody>();
            if (orderResponse != null)
            {
                Console.WriteLine($"Order details retrieved successfully: {orderResponse.Id}");

                var refundLink = orderResponse.Links.Find(x => x.Rel == "refund");
                if (refundLink == null)
                {
                    Console.WriteLine("No refund link found in the order response.");
                    return false;
                }
                
                // The refund link is typically a URL to initiate the refund process.
                Console.WriteLine("Refund link found: " + refundLink.Href);
                return true;
            }

            Console.WriteLine("Failed to deserialize order response.");
            return false;
        }
        Console.WriteLine($"Failed to retrieve order details. Status Code: {response.StatusCode}");
        return false;
    }
}