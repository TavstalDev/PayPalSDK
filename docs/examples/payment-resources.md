# Payment Resources API Examples

The Payment Resources API allows you to create and manage payment links and buttons that can be embedded on websites or shared with customers.

## Create Payment Resource

Create a new payment resource with line items.

```csharp
using Tavstal.PayPalSDK.Models.PaymentResources;
using Tavstal.PayPalSDK.Models.PaymentResources.Bodies;
using Tavstal.PayPalSDK.Models.Common.PaymentResources;
using Tavstal.PayPalSDK.Models.Common.Payments;

// Create payment resource request body
var body = new PaymentResourceCreateRequestBody
{
    IntegrationMode = EPaymentResourceIntegration.LINK,
    Type = EPaymentResourceType.BUY_NOW,
    Reusable = "true",
    ReturnUrl = "https://example.com/return",
    LineItems =
    [
        new PaymentLineItem
        {
            Name = "T-Shirt",
            Description = "Cotton T-Shirt",
            UnitAmount = new Money
            {
                CurrencyCode = "USD",
                Value = "25.00"
            },
            CollectShippingAddress = true
        }
    ]
};

// Create the payment resource
var request = new PaymentResourceCreateRequest(body);
var response = await client.SendAsync(request);

// Parse the response
var resource = await request.GetResponseBodyAsync(response);

Console.WriteLine($"Resource ID: {resource?.Id}");
Console.WriteLine($"Payment Link: {resource?.PaymentLink}");
Console.WriteLine($"Status: {resource?.Status}");
```

> **High-level alternative:**
> ```csharp
> using Tavstal.PayPalSDK.Http.Clients;
> 
> var result = await client.PaymentResources.CreateAsync(body);
> if (result.IsSuccess)
> {
>     Console.WriteLine($"Resource ID: {result.Value.Id}");
>     Console.WriteLine($"Payment Link: {result.Value.PaymentLink}");
> }
> else
>     Console.WriteLine($"Error: {result.Error?.Message}");
> ```

## Retrieve Payment Resource

Retrieve details about a specific payment resource.

```csharp
using Tavstal.PayPalSDK.Models.PaymentResources;

// Get payment resource details
var request = new PaymentResourceRetrieveRequest("RES-123456");
var response = await client.SendAsync(request);

// Parse the response
var resource = await request.GetResponseBodyAsync(response);

Console.WriteLine($"Resource ID: {resource?.Id}");
Console.WriteLine($"Integration Mode: {resource?.IntegrationMode}");
Console.WriteLine($"Reusable: {resource?.Reusable}");
```

> **High-level alternative:**
> ```csharp
> var result = await client.PaymentResources.GetAsync("RES-123456");
> if (result.IsSuccess)
>     Console.WriteLine($"Resource ID: {result.Value.Id}");
> else
>     Console.WriteLine($"Error: {result.Error?.Message}");
> ```

## List Payment Resources

List payment resources with pagination.

```csharp
using Tavstal.PayPalSDK.Models.PaymentResources;

// List payment resources
var request = new PaymentResourceListRequest(pageSize: 20);
var response = await client.SendAsync(request);

// Parse the response
var resources = await request.GetResponseBodyAsync(response);

Console.WriteLine($"Total Items: {resources?.TotalItems}");
if (resources?.Resources != null)
{
    foreach (var resource in resources.Resources)
    {
        Console.WriteLine($"Resource ID: {resource.Id}, Status: {resource.Status}");
    }
}
```

> **High-level alternative:**
> ```csharp
> var result = await client.PaymentResources.ListAsync(pageSize: 20);
> if (result.IsSuccess && result.Value.Resources != null)
> {
>     Console.WriteLine($"Total Items: {result.Value.TotalItems}");
>     foreach (var resource in result.Value.Resources)
>         Console.WriteLine($"Resource ID: {resource.Id}, Status: {resource.Status}");
> }
> else
>     Console.WriteLine($"Error: {result.Error?.Message}");
> ```

## Replace Payment Resource

Replace or update an existing payment resource.

```csharp
using Tavstal.PayPalSDK.Models.PaymentResources;
using Tavstal.PayPalSDK.Models.PaymentResources.Bodies;
using Tavstal.PayPalSDK.Models.Common.PaymentResources;
using Tavstal.PayPalSDK.Models.Common.Payments;

// Create replacement body
var body = new PaymentResourceReplaceRequestBody
{
    IntegrationMode = EPaymentResourceIntegration.LINK,
    Type = EPaymentResourceType.BUY_NOW,
    Reusable = "false",
    ReturnUrl = "https://example.com/new-return",
    LineItems =
    [
        new PaymentLineItem
        {
            Name = "Premium T-Shirt",
            UnitAmount = new Money
            {
                CurrencyCode = "USD",
                Value = "35.00"
            }
        }
    ]
};

// Replace the payment resource
var request = new PaymentResourceReplaceRequest("RES-123456", body);
var response = await client.SendAsync(request);

Console.WriteLine("Payment resource updated successfully");
```

> **High-level alternative:**
> ```csharp
> var updateResult = await client.PaymentResources.UpdateAsync("RES-123456", body);
> if (updateResult.IsSuccess)
>     Console.WriteLine("Payment resource updated successfully");
> else
>     Console.WriteLine($"Error: {updateResult.Error?.Message}");
> ```

## Delete Payment Resource

Delete a payment resource.

```csharp
using Tavstal.PayPalSDK.Models.PaymentResources;

// Delete the payment resource
var request = new PaymentResourceDeleteRequest("RES-123456");
var response = await client.SendAsync(request);

Console.WriteLine("Payment resource deleted successfully");
```

> **High-level alternative:**
> ```csharp
> var deleteResult = await client.PaymentResources.DeleteAsync("RES-123456");
> if (deleteResult.IsSuccess)
>     Console.WriteLine("Payment resource deleted successfully");
> else
>     Console.WriteLine($"Error: {deleteResult.Error?.Message}");
> ```
