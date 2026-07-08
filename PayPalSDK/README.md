# PayPalSDK

A C# SDK for interacting with the PayPal API. It provides a clean, type-safe interface for common PayPal operations and supports both Sandbox and Live environments.

## Installation

### NuGet

Install the package via NuGet:

```bash
dotnet add package PayPalSDK
```

Or search for `PayPalSDK` in the NuGet Package Manager in your IDE.

### GitHub Releases

Download the latest package from the [GitHub Releases page](https://github.com/TavstalDev/PayPalSDK/releases/tag/v1.0.0).

## Features

- **Orders API** - create, update, confirm, capture, authorize, and track orders
- **Payments API** - manage authorizations, captures, and refunds
- **Subscriptions API** - handle billing plans, subscriptions, and transaction history
- **Invoicing API** - create, send, cancel, and track payments for invoices
- **Webhooks** - register webhooks and verify webhook signatures
- **Payment Method Tokens** - save payment methods securely using the vault
- **Shipment Tracking** - add, update, and find tracking information
- **Catalog Products** - create and manage product listings
- **Currency Exchange** - request live exchange rates
- **Strongly-typed models** for all requests and responses
- **Async/await support** for all methods
- Full support for both **Sandbox** and **Live** environments

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

### 2. Create a request

When the client is ready, you can create a new PayPal request:

<details>
<summary><b>Object initializer example</b> (click to expand)</summary>

```csharp
using Tavstal.PayPalSDK.Models.Orders;

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

## Documentation

Full documentation is available on the [GitHub repository](https://github.com/TavstalDev/PayPalSDK):

| Document | Description                    |
|----------|--------------------------------|
| [Getting Started](https://github.com/TavstalDev/PayPalSDK/blob/stable/docs/GETTING_STARTED.md) | Installation and first request |
| [Examples](https://github.com/TavstalDev/PayPalSDK/blob/stable/docs/EXAMPLES.md) | Usage examples                 |
| [API Status](https://github.com/TavstalDev/PayPalSDK/blob/stable/docs/API_STATUS.md) | Endpoint implementation status |

---

## License

This project is licensed under the **MIT License**.  
See the [LICENSE](https://github.com/TavstalDev/PayPalSDK/blob/stable/LICENSE) file for more details.

Attribution is appreciated but not required. If you use this SDK, please consider mentioning `TavstalDev/PayPalSDK` in your documentation.

---

## Issues & Support

For bug reports or feature requests, please use the [GitHub issue tracker](https://github.com/TavstalDev/PayPalSDK/issues).

---

## Disclaimer

This SDK is not affiliated with or endorsed by PayPal, Inc. Use at your own risk.