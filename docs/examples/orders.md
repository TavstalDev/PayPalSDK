# Orders API Examples

The Orders API lets you create, authorize, and capture orders. An order represents a request to purchase goods or services.

## Create Order

Create a new order with purchase units.

```csharp
using Tavstal.PayPalSDK.Models.Orders;
using Tavstal.PayPalSDK.Models.Orders.Bodies;
using Tavstal.PayPalSDK.Models.Common.Orders.Supplementary;
using Tavstal.PayPalSDK.Models.Common.Payments;

// Create a purchase unit with basic order information
var purchaseUnit = new PurchaseUnit
{
    Amount = new MoneyBreakdown
    {
        CurrencyCode = "USD",
        Value = "100.00"
    }
};

// Create the order request body
var body = new OrderCreateRequestBody
{
    Intent = PayPalIntent.CAPTURE,
    PurchaseUnits = [purchaseUnit]
};

// Create the order
var request = new OrderCreateRequest(body);
var response = await client.SendAsync(request);

// Get the created order
var order = await request.GetResponseBodyAsync(response);
Console.WriteLine($"Order ID: {order!.Id}");
Console.WriteLine($"Order Status: {order.Status}");
```

> **High-level alternative:**
> ```csharp
> using Tavstal.PayPalSDK.Http.Clients;
> 
> var result = await client.Orders.CreateAsync(body);
> if (result.IsSuccess)
> {
>     Console.WriteLine($"Order ID: {result.Value.Id}");
>     Console.WriteLine($"Order Status: {result.Value.Status}");
> }
> else
>     Console.WriteLine($"Error: {result.Error?.Message}");
> ```

## Get Order

Retrieve details about a specific order.

```csharp
using Tavstal.PayPalSDK.Models.Orders;

// Get details about an order
var request = new OrderGetDetailsRequest("3RV7CCHPCMDG8");
var response = await client.SendAsync(request);

// Parse the response
var order = await request.GetResponseBodyAsync(response);

Console.WriteLine($"Order ID: {order!.Id}");
Console.WriteLine($"Status: {order.Status}");
Console.WriteLine($"Amount: {order.PurchaseUnits?[0].Amount?.Value} {order.PurchaseUnits?[0].Amount?.CurrencyCode}");
```

> **High-level alternative:**
> ```csharp
> var result = await client.Orders.GetAsync("3RV7CCHPCMDG8");
> if (result.IsSuccess)
> {
>     Console.WriteLine($"Order ID: {result.Value.Id}");
>     Console.WriteLine($"Status: {result.Value.Status}");
> }
> else
>     Console.WriteLine($"Error: {result.Error?.Message}");
> ```

## Authorize Payment for Order

Authorize a payment for a specific order.

```csharp
using Tavstal.PayPalSDK.Models.Orders;

// Authorize the payment for an order
var request = new OrderAuthorizeRequest("3RV7CCHPCMDG8");
var response = await client.SendAsync(request);

// Parse the response
var order = await request.GetResponseBodyAsync(response);

Console.WriteLine($"Authorization successful for order: {order!.Id}");
```

> **High-level alternative:**
> ```csharp
> var result = await client.Orders.AuthorizeAsync("3RV7CCHPCMDG8");
> if (result.IsSuccess)
>     Console.WriteLine($"Authorization successful for order: {result.Value.Id}");
> else
>     Console.WriteLine($"Error: {result.Error?.Message}");
> ```

## Capture Payment for Order

Capture a previously authorized payment.

```csharp
using Tavstal.PayPalSDK.Models.Orders;

// Capture payment for an order
var request = new OrderCaptureRequest("3RV7CCHPCMDG8");
var response = await client.SendAsync(request);

// Parse the response
var order = await request.GetResponseBodyAsync(response);

Console.WriteLine($"Payment captured for order: {order!.Id}");
```

> **High-level alternative:**
> ```csharp
> var result = await client.Orders.CaptureAsync("3RV7CCHPCMDG8");
> if (result.IsSuccess)
>     Console.WriteLine($"Payment captured for order: {result.Value.Id}");
> else
>     Console.WriteLine($"Error: {result.Error?.Message}");
> ```

## Update Order

Update an existing order.

```csharp
using Tavstal.PayPalSDK.Models.Orders;
using Tavstal.PayPalSDK.Models.Common;

// Create update operations using JSON Patch
var updateOperations = new List<UpdateOperation>
{
    new UpdateOperation
    {
        Op = "replace",
        Path = "/purchase_units/@reference_id=='default'/custom_id",
        Value = "CUSTOM123"
    }
};

// Update the order
var request = new OrderUpdateRequest("3RV7CCHPCMDG8", updateOperations);
var response = await client.SendAsync(request);

Console.WriteLine("Order updated successfully");
```

> **High-level alternative:**
> ```csharp
> var result = await client.Orders.UpdateAsync("3RV7CCHPCMDG8", updateOperations);
> if (result.IsSuccess)
>     Console.WriteLine("Order updated successfully");
> else
>     Console.WriteLine($"Error: {result.Error?.Message}");
> ```

## Confirm Order

Confirm an order and complete authorization.

```csharp
using Tavstal.PayPalSDK.Models.Orders;
using Tavstal.PayPalSDK.Models.Orders.Bodies;

// Confirm the order with payment source details
var body = new OrderConfirmRequestBody
{
    PaymentSource = new PaymentSource
    {
        PayPal = new PayPalSource
        {
            Name = new Name
            {
                GivenName = "John",
                Surname = "Doe"
            },
            EmailAddress = "johndoe@example.com",
            ExperienceContext = new ExperienceContext
            {
                PaymentMethodPreference = PaymentPreference.IMMEDIATE_PAYMENT_REQUIRED,
                BrandName = "EXAMPLE INC",
                Locale = "en-US",
                LandingPage = "LOGIN",
                ShippingPreference = ShippingPreference.SET_PROVIDED_ADDRESS,
                UserAction = UserAction.PAY_NOW,
                ReturnUrl = "https://example.com/returnUrl",
                CancelUrl =  "https://example.com/cancelUrl", 
            }
        },
    }
};

// Confirm the order
var request = new OrderConfirmRequest("3RV7CCHPCMDG8", body);
var response = await client.SendAsync(request);

// Parse the response
var order = await request.GetResponseBodyAsync(response);

Console.WriteLine($"Order confirmed: {order!.Id}");
```

> **High-level alternative:**
> ```csharp
> var result = await client.Orders.ConfirmAsync("3RV7CCHPCMDG8", body);
> if (result.IsSuccess)
>     Console.WriteLine($"Order confirmed: {result.Value.Id}");
> else
>     Console.WriteLine($"Error: {result.Error?.Message}");
> ```

## Add Tracking for Order

Add shipment tracking information for an order.

```csharp
using Tavstal.PayPalSDK.Models.Orders;
using Tavstal.PayPalSDK.Models.Orders.Bodies;
using Tavstal.PayPalSDK.Models.Common.Tracking;

// Create request body
var body = new OrderTrackingRequestBody
{
    CaptureId = "8MC585209K746392H",
    Carrier = "FEDEX",
    TrackingNumber = "123456789",
    Items = [ 
            new TrackingItem
            {
                Name = "T-Shirt",
                Sku = "sku02",
                Quantity = "1",
                UPC = new UPC 
                {
                    Type = "UPC-A",
                    Code = "12345678901"
                },
                ImageUrl = "https://www.example.com/example.jpg",
                Url = "https://www.example.com/example"
            }
        ]
};

var request = new OrderAddTrackingRequest("3RV7CCHPCMDG8", body);
var response = await client.SendAsync(request);
        
var result = await request.GetResponseBodyAsync(response);

Console.WriteLine("ID: " + result!.Id);
```

> **High-level alternative:**
> ```csharp
> var addResult = await client.Orders.AddTrackingAsync("3RV7CCHPCMDG8", body);
> if (addResult.IsSuccess)
>     Console.WriteLine($"ID: {addResult.Value.Id}");
> else
>     Console.WriteLine($"Error: {addResult.Error?.Message}");
> ```

## Update Tracking for Order

Update shipment tracking information for an order.

```csharp
using Tavstal.PayPalSDK.Models.Orders;
using Tavstal.PayPalSDK.Models.Orders.Bodies;

// Create updated tracking information
var body = new List<UpdateOperation>
{
    new UpdateOperation
    {
        Op = "replace",
        Path = "/status",
        Value = "CANCELLED"
    }
};

var request = new OrderUpdateTrackingRequest("5O190127TN364715T", "8MC585209K746392H443844607820", body);
var response = await client.SendAsync(request);

Console.WriteLine("Tracking information updated successfully");
```

> **High-level alternative:**
> ```csharp
> var updateResult = await client.Orders.UpdateTrackingAsync("5O190127TN364715T", "8MC585209K746392H443844607820", body);
> if (updateResult.IsSuccess)
>     Console.WriteLine("Tracking information updated successfully");
> else
>     Console.WriteLine($"Error: {updateResult.Error?.Message}");
> ```
