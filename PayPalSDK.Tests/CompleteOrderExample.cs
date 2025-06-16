using System.Net.Http.Json;
using System.Text.Json;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Orders;

namespace Tavstal.PayPalSDK.Tests;

public class CompleteOrderExample
{
    private readonly PayPalHttpClient _client;
    private readonly string _currencyCode;
    
    
    public CompleteOrderExample(PayPalHttpClient client, string currencyCode)
    {
        _client = client;
        _currencyCode = currencyCode;
    }

    public async Task<bool> DoAsync(string orderId)
    {
        var request = new OrderCaptureRequest(orderId, new OrderCaptureRequestBody());
        var response = await _client.SendAsync(request);

        if (response.IsSuccessStatusCode)
        {
            var orderResponse = await response.Content.ReadFromJsonAsync<OrderBody>();
            if (orderResponse != null)
            {
                Console.WriteLine($"Order completed successfully: {orderResponse.Id}");
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
        
        return false;
    }
}