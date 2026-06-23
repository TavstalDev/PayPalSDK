# Getting Started with PayPalSDK

This guide will help you install, configure, and use PayPalSDK to make your first API call.

---

## Table of Contents

- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Configuration](#configuration)
- [Quick Start](#quick-start)
- [Next Steps](#next-steps)

---

## Prerequisites

Before you start, make sure you have:

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download) or a newer version
- A [PayPal Developer account](https://developer.paypal.com/)
- A PayPal REST API application with a **Client ID** and **Client Secret**
    - You can create one on the [PayPal Developer Dashboard](https://developer.paypal.com/developer/applications)
    - Use a **Sandbox** application for testing and a **Live** application for real payments

---

## Installation

> **Note:** Packages for NuGet and GitHub Releases will be available with the `1.0.0` release. For now, please build the project from the source code.

### Build from Source

Clone the repository and build the solution:

```bash
git clone https://github.com/TavstalDev/PayPalSDK.git
cd PayPalSDK
dotnet build
```

Then, add a reference to the ``PayPalSDK`` project in your ``.csproj`` file:

```xml
<ItemGroup>
  <ProjectReference Include="../PayPalSDK/PayPalSDK.csproj" />
</ItemGroup>
```

---

## Configuration

PayPalSDK works with both Sandbox (testing) and Live (production) environments. You can choose which environment to use when you start the client.

You will need:

| Value          | Where to find it |
|----------------|---|
| `ClientId`     | PayPal Developer Dashboard → Your App → Client ID |
| `ClientSecret` | PayPal Developer Dashboard → Your App → Secret |
| `Environment`  | `sandbox` for testing, `live` for production |

> **Never hard-code credentials in source code.** Use environment variables, `appsettings.json`, or a secrets manager (e.g. `dotnet user-secrets` during development).

Example using `appsettings.json`:

```json
{
  "PayPal": {
    "ClientId": "your-client-id-here",
    "ClientSecret": "your-client-secret-here",
    "Environment": "sandbox"
  }
}
```

---

## Quick Start

### 1. Set Up the Client

Create a `PayPalClient` instance using your credentials. Pass `true` for the sandbox environment, or `false` for live:

```csharp
using PayPalSDK;

// Example: Use sandbox for testing
var client = new PayPalHttpClient(
    new SandboxEnvironment("your-client-id-here", "your-client-secret-here") 
);

// Example: Use live for production
var client = new PayPalHttpClient(
    new LiveEnvironment("your-client-id-here", "your-client-secret-here") 
);
```

The client manages login tokens automatically. It gets and saves a Bearer token from PayPal before sending any requests.

---

### 2. Create an Order

When the client is ready, you can create a new PayPal order:

```csharp
using PayPalSDK.Models.Orders;

var orderRequestBody = new OrderCreateRequestBody
{
    Intent = PayPalIntent.CAPTURE, // Specifies the intent of the order (e.g., capture payment).
    PurchaseUnits = 
    [
        new PurchaseUnit
        {
            Amount = new MoneyBreakdown
            {
                CurrencyCode = "EUR", // Sets the currency code for the order.
                Value = "10.00", // Specifies the total value of the order.
                Breakdown = new Breakdown
                {
                    ItemTotal = new Money
                    {
                        CurrencyCode = "EUR",
                        Value = "10.00" // Specifies the total value of items in the order.
                    }
                }
            },
            Description = "Test Order", // Description of the order.
            CustomId = "CustomId123", // Custom identifier for the order.
            Items =
            [
                new Item
                {
                    Category = ItemCategory.DIGITAL_GOODS, // Specifies the category of the item.
                    Name = "Test Item", // Name of the item.
                    Description = "This is a test item", // Description of the item.
                    Sku = "ITEM123", // Stock keeping unit identifier for the item.
                    UnitAmount = new Money
                    {
                        CurrencyCode = "EUR",
                        Value = "10.00" // Price per unit of the item.
                    },
                    Quantity = "1", // Quantity of the item.
                    Tax = new Money
                    {
                        CurrencyCode = "EUR",
                        Value = "0.00" // Tax amount for the item.
                    }
                }
            ],
            Shipping = new Shipping
            {
                EmailAddress = "sdk-customer@personal.example.com", // Customer's email address.
                Name = new Person
                {
                    FullName = "John Doe" // Full name of the customer.
                },
                Address = new Address
                {
                    AddressLineOne = "123 Test St", // First line of the shipping address.
                    AddressLineTwo = "Apt 4B", // Second line of the shipping address.
                    AdminAreaOne = "CA", // State or province.
                    AdminAreaTwo = "Los Angeles", // City.
                    PostalCode = "90001", // Postal code.
                    CountryCode = "US" // Country code.
                }
            },
            Payee = new Payee
            {
                EmailAddress = "sdk-merchant@business.example.com" // Merchant's email address.
            }
        }
    ]
};

// Create the order request and send it using the PayPal client.
var orderRequest = new OrderCreateRequest(orderRequestBody);
var response = await _client.SendAsync(orderRequest);

if (!response.IsSuccessStatusCode)
{
    var errorResponse = await orderRequest.GetErrorResponseAsync(response);
    Console.WriteLine($"Error creating order (HTTP {response.StatusCode}): {errorResponse?.Message}");
    return;
}

var orderResponse = await orderRequest.GetResponseBodyAsync(response);
Console.WriteLine($"Order ID: {orderResponse?.Id}");
```

### 3. High-Level Pattern (Recommended)

The SDK also provides a higher-level client pattern that wraps the request and error handling into a single call:

```csharp
using Tavstal.PayPalSDK.Http.Clients;

var result = await client.Orders.CreateAsync(orderRequestBody);

if (result.IsSuccess)
{
    Console.WriteLine($"Order ID: {result.Value.Id}");
    Console.WriteLine($"Order Status: {result.Value.Status}");
}
else
{
    Console.WriteLine($"Error: {result.Error?.Message}");
}
```

A new order will start with a CREATED status. To finish the payment, the buyer must approve the order through PayPal's checkout page. After that, you can capture the payment.

---

### Environments Quick View

| Environment | Class to Use      | Credentials from                         |
|---|-------------------|------------------------------------------|
| Sandbox (testing) | SandboxEnvironment | PayPal Developer Dashboard → Sandbox app |
| Live (production) | LiveEnvironment   | PayPal Developer Dashboard → Live app    |

When using Sandbox, you are not using real money. You can use PayPal's [Sandbox test accounts]((https://developer.paypal.com/developer/accounts)) to test buyer and seller actions.

---

## Next Steps

Now that you can connect and create orders, you can explore more details about the SDK:

| Document | Description                                     |
|---|-------------------------------------------------|
| [API Status](API_STATUS.md) | Which PayPal endpoints are currently implemented |
| [Examples](EXAMPLES.md) | Example projects and usage scenarios            |
| [Contributing](../CONTRIBUTING.md) | How to contribute to PayPalSDK                  |

For full details on the PayPal Orders API, see the [official PayPal API documentation](https://developer.paypal.com/docs/api/orders/v2/).