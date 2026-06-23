# PayPalSDK

A C# SDK for interacting with the PayPal API. It provides a clean, type-safe interface for common PayPal operations and supports both Sandbox and Live environments.

## Installation

Install the package via NuGet:

```bash
dotnet add package PayPalSDK
```

Or search for `PayPalSDK` in the NuGet Package Manager in your IDE.

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

### 1. Creating The Client
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

### 2. Low-Level Pattern
```csharp
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

## Documentation

Full documentation is available on the [GitHub repository](https://github.com/TavstalDev/PayPalSDK):

| Document | Description                    |
|----------|--------------------------------|
| [Getting Started](https://github.com/TavstalDev/PayPalSDK/blob/stable/docs/GETTING_STARTED.md) | Installation and first request |
| [Examples](https://github.com/TavstalDev/PayPalSDK/blob/stable/docs/EXAMPLES.md) | Usage examples                 |
| [API Status](https://github.com/TavstalDev/PayPalSDK/blob/stable/docs/API_STATUS.md) | Endpoint implementation status |

## License

This project is licensed under the **MIT License**.  
See the [LICENSE](https://github.com/TavstalDev/PayPalSDK/blob/stable/LICENSE) file for more details.

Attribution is appreciated but not required. If you use this SDK, please consider mentioning `TavstalDev/PayPalSDK` in your documentation.

## Issues & Support

For bug reports or feature requests, please use the [GitHub issue tracker](https://github.com/TavstalDev/PayPalSDK/issues).

## Disclaimer

This SDK is not affiliated with or endorsed by PayPal, Inc. Use at your own risk.