# Payment Method Tokens API Examples

The Payment Method Tokens API allows you to create, retrieve, and manage payment method tokens for recurring payments.

## Create Payment Method Token

Create a new payment method token.

```csharp
using Tavstal.PayPalSDK.Models.PaymentMethodTokens;
using Tavstal.PayPalSDK.Models.PaymentMethodTokens.Bodies;

// Create payment method token
var body = new PaymentTokenCreateRequestBody
{
    PaymentSource = new PaymentSource
    {
        Token = new TokenSource
        {
            Id = "4BD1763VB2781894",
            Type = "SETUP_TOKEN"
        }
    }
};

// Create the token
var request = new PaymentTokenCreateRequest(body);
var response = await client.SendAsync(request);

// Parse the response
var token = await request.GetResponseBodyAsync(response);

Console.WriteLine($"Token ID: {token?.Id}");
```

> **High-level alternative:**
> ```csharp
> using Tavstal.PayPalSDK.Http.Clients;
> 
> var result = await client.PaymentMethodTokens.CreateAsync(body);
> if (result.IsSuccess)
>     Console.WriteLine($"Token ID: {result.Value.Id}");
> else
>     Console.WriteLine($"Error: {result.Error?.Message}");
> ```

## Create Payment Method Token Setup

Create a setup for payment method token.

```csharp
using Tavstal.PayPalSDK.Models.PaymentMethodTokens;
using Tavstal.PayPalSDK.Models.PaymentMethodTokens.Bodies;

// Create token setup
var body = new PaymentTokenCreateRequestBody
{
    PaymentSource = new PaymentSource
    {
        Token = new TokenSource
        {
            Id = "4BD1763VB2781894",
            Type = "SETUP_TOKEN"
        }
    }
};

// Create the setup
var request = new PaymentTokenSetupCreateRequest(body);
var response = await client.SendAsync(request);

Console.WriteLine("Token setup created successfully");
```

> **High-level alternative:**
> ```csharp
> var result = await client.PaymentMethodTokens.CreateSetupAsync(body);
> if (result.IsSuccess)
>     Console.WriteLine("Token setup created successfully");
> else
>     Console.WriteLine($"Error: {result.Error?.Message}");
> ```

## Retrieve Payment Method Token

Retrieve a specific payment method token.

```csharp
using Tavstal.PayPalSDK.Models.PaymentMethodTokens;

// Get token details
var request = new PaymentTokenRetrieveRequest("token-id-123");
var response = await client.SendAsync(request);

// Parse the response
var token = await request.GetResponseBodyAsync(response);

Console.WriteLine($"Token ID: {token?.Id}");
```

> **High-level alternative:**
> ```csharp
> var result = await client.PaymentMethodTokens.GetAsync("token-id-123");
> if (result.IsSuccess)
>     Console.WriteLine($"Token ID: {result.Value.Id}");
> else
>     Console.WriteLine($"Error: {result.Error?.Message}");
> ```

## Retrieve Payment Method Token Setup

Retrieve token setup details.

```csharp
using Tavstal.PayPalSDK.Models.PaymentMethodTokens;

// Get token setup details
var request = new PaymentTokenSetupRetrieveRequest("setup-id-123");
var response = await client.SendAsync(request);

// Parse the response
var setup = await request.GetResponseBodyAsync(response);

Console.WriteLine("Token setup retrieved successfully");
```

> **High-level alternative:**
> ```csharp
> var result = await client.PaymentMethodTokens.GetSetupAsync("setup-id-123");
> if (result.IsSuccess)
>     Console.WriteLine("Token setup retrieved successfully");
> else
>     Console.WriteLine($"Error: {result.Error?.Message}");
> ```

## List All Payment Method Tokens

List all payment method tokens.

```csharp
using Tavstal.PayPalSDK.Models.PaymentMethodTokens;

// List tokens
var request = new PaymentTokenListAllRequest("BygeLlrpZF");
var response = await client.SendAsync(request);

// Parse the response
var tokens = await request.GetResponseBodyAsync(response);

if (tokens?.PaymentTokens != null)
    foreach (var token in tokens.PaymentTokens)
    {
        Console.WriteLine($"Token ID: {token.Id}");
    }
```

> **High-level alternative:**
> ```csharp
> var result = await client.PaymentMethodTokens.ListAsync("BygeLlrpZF");
> if (result.IsSuccess && result.Value.PaymentTokens != null)
>     foreach (var token in result.Value.PaymentTokens)
>         Console.WriteLine($"Token ID: {token.Id}");
> else
>     Console.WriteLine($"Error: {result.Error?.Message}");
> ```

## Delete Payment Method Token

Delete a payment method token.

```csharp
using Tavstal.PayPalSDK.Models.PaymentMethodTokens;

// Delete the token
var request = new PaymentTokenDeleteRequest("token-id-123");
var response = await client.SendAsync(request);

Console.WriteLine("Token deleted successfully");
```

> **High-level alternative:**
> ```csharp
> var result = await client.PaymentMethodTokens.DeleteAsync("token-id-123");
> if (result.IsSuccess)
>     Console.WriteLine("Token deleted successfully");
> else
>     Console.WriteLine($"Error: {result.Error?.Message}");
> ```
