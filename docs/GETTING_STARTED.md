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

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download) or a newer version
- A [PayPal Developer account](https://developer.paypal.com/)
- A PayPal REST API application with a **Client ID** and **Client Secret**
    - You can create one on the [PayPal Developer Dashboard](https://developer.paypal.com/developer/applications)
    - Use a **Sandbox** application for testing and a **Live** application for real payments

---

## Installation

### NuGet

Install the package via NuGet:

```bash
dotnet add package PayPalSDK
```

Or search for `PayPalSDK` in the NuGet Package Manager in your IDE.

### GitHub Releases

Download the latest package from the [GitHub Releases page](https://github.com/TavstalDev/PayPalSDK/releases/tag/v1.0.0).

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

Create a `PayPalClient` instance using your credentials:

<details>
<summary><b>Object initializer example</b> (click to expand)</summary>

```csharp
using Tavstal.PayPalSDK.Http;

// Example: Use sandbox for testing
var client = new PayPalHttpClient(
    new SandboxEnvironment("your-client-id-here", "your-client-secret-here") 
);

// Example: Use live for production
var client = new PayPalHttpClient(
    new LiveEnvironment("your-client-id-here", "your-client-secret-here") 
);
```

</details>

<details>
<summary><b>Fluent API alternative</b> (click to expand)</summary>

```csharp
using Tavstal.PayPalSDK.Http;

PayPalHttpClientBuilder
    // WithEnvironment, WithSandboxEnvironment Or WithLiveEnvironment:
    .WithSandboxEnvironment("your-client-id-here", "your-client-secret-here")
    .WithOptions(PayPalClientOptionsBuilder
      .WithApplicationName("Test App")
      .Build())
    .Build();
```

</details>

The client manages login tokens automatically. It gets and saves a Bearer token from PayPal before sending any requests.

---

### 2. Create a request

When the client is ready, you can create a new PayPal request:

<details>
<summary><b>Object initializer example</b> (click to expand)</summary>

```csharp
using Tavstal.PayPalSDK.Models.Orders;
using Tavstal.PayPalSDK.Models.Orders.Bodies;
using Tavstal.PayPalSDK.Models.Common.Orders;
using Tavstal.PayPalSDK.Models.Common.Payments;
using Tavstal.PayPalSDK.Models.Common.Addressing;
using Tavstal.PayPalSDK.Models.Enums.Orders;
using Tavstal.PayPalSDK.Models.Common;

var orderRequestBody = new OrderCreateRequestBody
{
    Intent = EIntent.CAPTURE, // Specifies the intent of the order (e.g., capture payment).
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
                    Category = EOrderItemCategory.DIGITAL_GOODS, // Specifies the category of the item.
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
```
</details>

<details>
<summary><b>Fluent API alternative</b> (click to expand)</summary>

```csharp
using Tavstal.PayPalSDK.Models.Orders.Bodies;
using Tavstal.PayPalSDK.Models.Common.Orders;
using Tavstal.PayPalSDK.Models.Common.Payments;
using Tavstal.PayPalSDK.Models.Common.Addressing;
using Tavstal.PayPalSDK.Models.Enums.Orders;
using Tavstal.PayPalSDK.Models.Common;

var orderRequestBody = OrderCreateRequestBodyBuilder
    .WithPurchaseUnits([
        PurchaseUnitBuilder
            .WithDescription("Test Order")
            .WithCustomId("CustomId123")
            .WithItems([
                ItemBuilder
                    .WithName("Test Item")
                    .WithQuantity("1")
                    .WithUnitAmount(MoneyBuilder
                        .WithCurrencyCode("EUR")
                        .WithValue("10.00")
                        .Build())
                    .WithDescription("This is a test item")
                    .WithSku("ITEM123")
                    .WithCategory(EOrderItemCategory.DIGITAL_GOODS)
                    .WithTax(MoneyBuilder
                        .WithCurrencyCode("EUR")
                        .WithValue("0.00")
                        .Build())
                    .Build()
            ])
            .WithAmount(MoneyBreakdownBuilder
                .WithCurrencyCode("EUR")
                .WithValue("10.00")
                .WithBreakdown(BreakdownBuilder
                    .WithItemTotal(MoneyBuilder
                        .WithCurrencyCode("EUR")
                        .WithValue("10.00")
                        .Build())
                    .Build())
                .Build())
            .WithPayee(PayeeBuilder
                .WithEmailAddress("sdk-merchant@business.example.com")
                .Build())
            .Build()
    ])
    .WithIntent(EIntent.CAPTURE)
    .Build();
```

</details>

### 3. Send the request

You can send requests using either the low-level pattern (directly calling `SendAsync` on the client and handling responses manually) 
or the high-level pattern (using domain-specific client wrappers like `Orders.CreateAsync` for a more streamlined experience).

<details>
<summary><b>Low-level pattern</b> (click to expand)</summary>

```csharp
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

</details>

<details>
<summary><b>High-level pattern (Recommended)</b> (click to expand)</summary>

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

</details>

A new order will start with a CREATED status. To finish the payment, the buyer must approve the order through PayPal's checkout page. After that, you can capture the payment.

---

### Environments Quick View

| Environment | Class to Use      | Credentials from                         |
|---|-------------------|------------------------------------------|
| Sandbox (testing) | SandboxEnvironment | PayPal Developer Dashboard → Sandbox app |
| Live (production) | LiveEnvironment   | PayPal Developer Dashboard → Live app    |

When using Sandbox, you are not using real money. You can use PayPal's [Sandbox test accounts](https://developer.paypal.com/developer/accounts) to test buyer and seller actions.

---

## Next Steps

Now that you can connect and create orders, you can explore more details about the SDK:

| Document | Description                                     |
|---|-------------------------------------------------|
| [API Status](API_STATUS.md) | Which PayPal endpoints are currently implemented |
| [Examples](EXAMPLES.md) | Example projects and usage scenarios            |
| [Contributing](../CONTRIBUTING.md) | How to contribute to PayPalSDK                  |

For full details on the PayPal Orders API, see the [official PayPal API documentation](https://developer.paypal.com/docs/api/orders/v2/).