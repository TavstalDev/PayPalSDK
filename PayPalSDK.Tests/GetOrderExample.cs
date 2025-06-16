using System.Net.Http.Json;
using System.Text.Json;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Orders;

namespace Tavstal.PayPalSDK.Tests;

public class GetOrderExample
{
    private readonly PayPalHttpClient _client;
    private readonly string _currencyCode;

    public GetOrderExample(PayPalHttpClient client, string currencyCode)
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
        Console.WriteLine($"Failed to retrieve order details. Status Code: {response.StatusCode}");
        return false;
    }
}