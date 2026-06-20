# Payments API Examples

The Payments API allows you to authorize, capture, refund, and get details about payments.

## Capture Payment

Capture an authorized payment.

```csharp
using Tavstal.PayPalSDK.Models.Payments;
using Tavstal.PayPalSDK.Models.Payments.Bodies;
using Tavstal.PayPalSDK.Models.Common.Payments;

// Create capture request with optional details
var body = new PaymentCaptureRequestBody
{
    Amount = new Money
    {
        CurrencyCode = "USD",
        Value = "100.00"
    },
    InvoiceId = "INV-123456",
    FinalCapture = true
};

// Capture the authorized payment
var request = new PaymentCaptureRequest("2GG279541U471931P", body);
var response = await client.SendAsync(request);

// Parse the response
var captured = await request.GetResponseBodyAsync(response);

Console.WriteLine($"Capture ID: {captured?.Id}");
Console.WriteLine($"Invoice ID: {captured?.InvoiceId}");
Console.WriteLine($"Status: {captured?.Status}");
```

## Refund Payment

Refund a previously captured payment.

```csharp
using Tavstal.PayPalSDK.Models.Payments;
using Tavstal.PayPalSDK.Models.Payments.Bodies;
using Tavstal.PayPalSDK.Models.Common.Payments;

// Create refund request with optional amount and reason
var body = new PaymentRefundRequestBody
{
    Amount = new Money
    {
        CurrencyCode = "USD",
        Value = "50.00"
    },
    NoteToPayer = "Partial refund for order adjustment"
};

// Refund the captured payment
var request = new PaymentRefundRequest("0K35355239430361V", body);
var response = await client.SendAsync(request);

// Parse the response
var refund = await request.GetResponseBodyAsync(response);

Console.WriteLine($"Refund ID: {refund?.Id}");
Console.WriteLine($"Status: {refund?.Status}");
```

## Get Authorized Payment Details

Retrieve detailed information about a captured payment.

```csharp
using Tavstal.PayPalSDK.Models.Payments;

// Get details about a captured payment
var request = new PaymentGetAuthorizedDetailsRequest("0K35355239430361V");
var response = await client.SendAsync(request);

// Parse the response
var details = await request.GetResponseBodyAsync(response);

Console.WriteLine($"Payment ID: {details?.Id}");
Console.WriteLine($"Amount: {details?.Amount?.Value} {details?.Amount?.CurrencyCode}");
Console.WriteLine($"Status: {details?.Status}");
```

## Get Captured Payment Details

Retrieve details about a specific capture.

```csharp
using Tavstal.PayPalSDK.Models.Payments;

// Get details about a specific capture
var request = new PaymentGetCapturedDetailsRequest("0K35355239430361V");
var response = await client.SendAsync(request);

// Parse the response
var capture = await request.GetResponseBodyAsync(response);

Console.WriteLine($"Capture ID: {capture?.Id}");
Console.WriteLine($"Invoice ID: {capture?.InvoiceId}");
```

## Get Refund Details

Retrieve details about a specific refund.

```csharp
using Tavstal.PayPalSDK.Models.Payments;

// Get details about a specific refund
var request = new PaymentGetRefundDetailsRequest("1L897452387439294");
var response = await client.SendAsync(request);

// Parse the response
var refund = await request.GetResponseBodyAsync(response);

Console.WriteLine($"Refund ID: {refund?.Id}");
Console.WriteLine($"Status: {refund?.Status}");
Console.WriteLine($"Amount: {refund?.Amount?.Value}");
```

## Void Payment

Void a previously authorized payment.

```csharp
using Tavstal.PayPalSDK.Models.Payments;

// Void an authorized payment
var request = new PaymentVoidRequest("2GG279541U471931P");
var response = await client.SendAsync(request);

Console.WriteLine("Payment voided successfully");
```

## Reauthorize Payment

Reauthorize a previously authorized payment.

```csharp
using Tavstal.PayPalSDK.Models.Payments;
using Tavstal.PayPalSDK.Models.Payments.Bodies;
using Tavstal.PayPalSDK.Models.Common.Payments;

// Reauthorize with optional amount adjustment
var body = new PaymentReauthorizeRequestBody
{
    Amount = new Money
    {
        CurrencyCode = "USD",
        Value = "150.00"
    }
};

// Reauthorize the payment
var request = new PaymentReauthorizeRequest("2GG279541U471931P", body);
var response = await client.SendAsync(request);

// Parse the response
var reauth = await request.GetResponseBodyAsync(response);

Console.WriteLine("Payment reauthorized successfully");
```

## Find Eligible Payments

Find payments that are eligible for processing.

```csharp
using Tavstal.PayPalSDK.Models.Payments;

var body = new PaymentFindEligibleMethodsRequestBody
{
    Customer = new EligibleCustomer
    {
        CountryCode = "US",
        Channel = new EligibleChannel
        {
            BrowserType = "SAFARI",
            DeviceType = "MOBILE",
            ClientOs = "IOS"
        }
    },
    Preferences = new EligiblePreference
    {
        PaymentSourceConstraint = new EligibleConstraint
        {
            ConstraintType = "EXCLUDE",
            PaymentSources = [ "PAYPAL" ]
        }
    },
    PurchaseUnits = 
    [ 
       new PurchaseUnit
       {
           Amount = new MoneyBreakdown
           {
               Value = "100.00",
               CurrencyCode = "USD"
           }
       } 
    ]
};
        
// Find eligible payments
var request = new PaymentFindEligibleMethodsRequest(body);
var response = await client.SendAsync(request);

// Parse the response
var eligiblePayments = await request.GetResponseBodyAsync(response);

if (eligiblePayments is { PaymentTokens: not null })
    foreach (var payment in eligiblePayments.PaymentTokens)
        Console.WriteLine($"Payment ID: {payment.Id}");
```

