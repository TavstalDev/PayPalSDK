## Error Handling

All requests return an HTTP response. You should always check if the request was successful before using the result.

If the request fails, you can read the error details using `GetErrorResponseAsync()`. This gives you the HTTP status code and an error message from PayPal.

### Low-Level Pattern

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

### High-Level Pattern

When using domain-specific clients, errors are returned as `Result<T, ErrorResponse>` — no try/catch needed.

```csharp
var result = await client.Orders.CreateAsync(orderRequestBody);

if (result.IsSuccess)
{
    Console.WriteLine($"Order ID: {result.Value.Id}");
}
else
{
    Console.WriteLine($"Error: {result.Error.Name} — {result.Error.Message}");
    Console.WriteLine($"Debug ID: {result.Error.DebugId}");
}
```

You can also use `Match` or `Switch` to handle both branches:

```csharp
// Match: executes one of two functions and returns a value
var message = result.Match(
    onSuccess: order => $"Order {order.Id} created",
    onFailure: error => $"Failed: {error.Message}"
);

// Switch: executes one of two actions (void)
result.Switch(
    onSuccess: order => Console.WriteLine($"Order {order.Id} created"),
    onFailure: error => Console.WriteLine($"Failed: {error.Message}")
);
```

> **Note:** The high-level pattern catches network errors, auth failures, and API errors automatically. All failure modes are returned as `ErrorResponse` inside the `Result`.