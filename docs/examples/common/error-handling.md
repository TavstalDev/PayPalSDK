## Error Handling

All requests return an HTTP response. You should always check if the request was successful before using the result.

If the request fails, you can read the error details using `GetErrorResponseAsync()`. This gives you the HTTP status code and an error message from PayPal.

```csharp
try
{
    var response = await _client.SendAsync(orderRequest);

    if (!response.IsSuccessStatusCode)
    {
        var errorResponse = await orderRequest.GetErrorResponseAsync(response);

        if (errorResponse != null)
            Console.WriteLine($"Error creating order (HTTP {response.StatusCode}): {errorResponse.Message}");
        else
            Console.WriteLine($"Error creating order (HTTP {response.StatusCode}): No details available.");

        return;
    }
}
catch (HttpRequestException ex)
{
    Console.WriteLine($"Request failed: {ex.Message}");
}
```

> **Note:** `errorResponse` can be `null` if the error did not come from PayPal's servers directly.  
> A `HttpRequestException` can be thrown if the request could not be sent at all. For example, due to a network issue or a connection timeout. Always handle both cases.