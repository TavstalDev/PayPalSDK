# Invoices API Examples

The Invoices API allows you to create, send, and manage invoices.

## Create Draft Invoice

Create a draft invoice that can be edited before sending.

```csharp
using Tavstal.PayPalSDK.Models.Invoices;
using Tavstal.PayPalSDK.Models.Invoices.Bodies;
using Tavstal.PayPalSDK.Models.Common.Invoices;

// Create invoice body
var body = new InvoiceCreateDraftRequestBody
{
    Detail = new Detail
    {
        Reference    = "deal-ref",
        InvoiceDate  = "2025-01-15",
        CurrencyCode = "USD",
        Note         = "Thank you for your business.",
        TermsAndConditions         = "No refunds after 30 days.",
        Memo         = "This is a long contract",
        PaymentTerm  = new PaymentTerm
        {
            TermType = "NET_10",
            DueDate  = "2025-01-25"
        },
        OrderDetails       = "Order #12345 placed on January 10, 2025.",
        ProjectDetails     = "Website redesign project for client XYZ Corp.",
        ServiceDetails     = "Consulting services provided from Jan-Mar 2025.",
        CancellationPolicy = "Services may be cancelled with 14-day notice.",
        PaymentTerms       = "Payment due within 10 days of invoice date.",
        ReturnPolicy       = "All sales are final. No returns accepted after 30 days.",
        ServiceAgreement   = "Services provided as per agreement dated Jan 1, 2025.",
        TipPresets         = 
            [ 
                new TipPreset { Percent = "15" }, 
                new TipPreset { Percent = "20" },
                new TipPreset { Percent = "25" }
            ]
    },
    Invoicer = new Invoicer
    {
        Name = new NameInfo
        {
            GivenName = "David",
            Surname   = "Larusso"
        },
        Address = new Address
        {
            AddressLineOne = "1234 First Street",
            AddressLineTwo = "337673 Hillside Court",
            AdminAreaTwo   = "Anytown",
            AdminAreaOne   = "CA",
            PostalCode   = "98765",
            CountryCode  = "US"
        },
        EmailAddress = "merchant@example.com",
        Phones =
            [
                new InvoicePhone
                {
                    CountryCode    = "001",
                    NationalNumber = "4085551234",
                    PhoneType      = "MOBILE"
                }
            ],
        Website         = "www.test.com",
        TaxId           = "ABcNkWSfb5ICTt73nD3QON1fnnpgNKBy- Jb5SeuGj185MNNw6g",
        LogoUrl         = "https://example.com/logo.PNG",
        AdditionalNotes = "2-4"
    },
    PrimaryRecipients = 
    [
        new Recipient
        {
            BillingInfo = new BusinessBillingInfo
            {
                Name = new NameInfo
                {
                    GivenName = "Stephanie",
                    Surname   = "Meyers"
                },
                Address = new Address
                {
                    AddressLineOne = "1234 Main Street",
                    AdminAreaTwo   = "Anytown",
                    AdminAreaOne   = "CA",
                    PostalCode   = "98765",
                    CountryCode  = "US"
                },
                EmailAddress       = "bill-me@example.com",
                Phones = 
               [
                   new InvoicePhone
                   {
                       CountryCode    = "001",
                       NationalNumber = "4884551234",
                       PhoneType      = "HOME"
                   }
               ],
                AdditionalInfo = "add-info"
            },
            ShippingInfo = new ShippingInfo
            {
                Name = new NameInfo
                {
                    GivenName = "Stephanie",
                    Surname   = "Meyers"
                },
                Address = new Address
                {
                    AddressLineOne = "1234 Main Street",
                    AdminAreaTwo   = "Anytown",
                    AdminAreaOne   = "CA",
                    PostalCode   = "98765",
                    CountryCode  = "US"
                }
            }
        }
    ],
    Items =
    [
        new InvoiceItem
        {
            Name        = "Yoga Mat",
            Description = "Elastic mat to practice yoga.",
            Quantity    = "1",
            UnitAmount  = new Money { CurrencyCode = "USD", Value = "50.00" },
            Tax         = new Tax { Name = "Sales Tax", Percent = "7.25" },
            Discount    = new Discount { Percent = "5" },
            UnitOfMeasure = "QUANTITY"
        },
        new InvoiceItem
        {
            Name       = "Yoga t-shirt",
            Quantity   = "1",
            UnitAmount = new Money { CurrencyCode = "USD", Value = "10.00" },
            Tax        = new Tax
            {
                Name    = "Sales Tax",
                Percent = "7.25",
                TaxNote = "Reduced tax rate"
            },
            Discount = new Discount
            {
                Amount = new Money { CurrencyCode = "USD", Value = "5.00" }
            },
            UnitOfMeasure = "QUANTITY"
        }
    ],
    Configuration = new InvoiceConfig
    {
        PartialPayment = new PartialPayment
        {
            AllowPartialPayment = true,
            MinimalAmountDue    = new Money { CurrencyCode = "USD", Value = "20.00" }
        },
        AllowTip                   = true,
        TaxCalculatedAfterDiscount = true,
        TaxInclusive               = false,
        ShowAdditionalItemFields   = true,
        TemplateId                 = "TEMP-19V05281TU309413B",
        Theme = new InvoiceTheme
        {
            PrimaryColor = "#4A90D9"
        }
    },
    Amount = new InvoiceAmount
    {
        Breakdown = new InvoiceBreakdown
        {
            Custom = new InvoiceBreakdownCustom
            {
                Label  = "Packing Charges",
                Amount = new Money { CurrencyCode = "USD", Value = "10.00" }
            },
            Shipping = new InvoiceBreakdownShipping
            {
                Amount = new Money { CurrencyCode = "USD", Value = "10.00" },
                Tax    = new Tax { Name = "Sales Tax", Percent = "7.25" }
            },
            Discount = new InvoiceBreakdownDiscount
            {
                InvoiceDiscount = new InvoiceDiscount { Percent = "5" }
            }
        }
    },
    Settings = new InvoiceSettings
    {
        InvoiceItemSettings =
        [
            new InvoiceFieldSetting { FieldName = "ITEM_DESCRIPTION", DisplayPreference = new InvoiceFieldDisplayPreference { Hidden = false } },
            new InvoiceFieldSetting { FieldName = "ITEM_DATE",        DisplayPreference = new InvoiceFieldDisplayPreference { Hidden = true  } },
            new InvoiceFieldSetting { FieldName = "ITEM_TAX",         DisplayPreference = new InvoiceFieldDisplayPreference { Hidden = false } },
            new InvoiceFieldSetting { FieldName = "ITEM_DISCOUNT",    DisplayPreference = new InvoiceFieldDisplayPreference { Hidden = false } }
       ],
        InvoiceAdditionalSettings =
        [
           new InvoiceFieldSetting { FieldName = "ATTACHMENT", DisplayPreference = new InvoiceFieldDisplayPreference { Hidden = false } },
           new InvoiceFieldSetting { FieldName = "MEMO",        DisplayPreference = new InvoiceFieldDisplayPreference { Hidden = false } },
           new InvoiceFieldSetting { FieldName = "REFERENCE",   DisplayPreference = new InvoiceFieldDisplayPreference { Hidden = false } }
        ],
        InvoicePolicyAndAgreementSettings =
        [
            new InvoiceFieldSetting { FieldName = "TERMS_AND_CONDITIONS", DisplayPreference = new InvoiceFieldDisplayPreference { Hidden = false } },
            new InvoiceFieldSetting { FieldName = "PAYMENT_TERMS",        DisplayPreference = new InvoiceFieldDisplayPreference { Hidden = false } }
        ],
        InvoiceDetailsSettings =
        [
            new InvoiceFieldSetting { FieldName = "ORDER_DETAILS",   DisplayPreference = new InvoiceFieldDisplayPreference { Hidden = false } },
            new InvoiceFieldSetting { FieldName = "PROJECT_DETAILS",  DisplayPreference = new InvoiceFieldDisplayPreference { Hidden = true  } }
        ]
    }
};

// Create the draft invoice
var request = new InvoiceCreateDraftRequest(body);
var response = await client.SendAsync(request);

// Parse the response
var invoice = await request.GetResponseBodyAsync(response);

Console.WriteLine($"Invoice ID: {invoice?.Id}");
Console.WriteLine($"Status: {invoice?.Status}");
```

> **High-level alternative:**
> ```csharp
> using Tavstal.PayPalSDK.Http.Clients;
> 
> var result = await client.Invoices.CreateDraftAsync(body);
> if (result.IsSuccess)
> {
>     Console.WriteLine($"Invoice ID: {result.Value.Id}");
>     Console.WriteLine($"Status: {result.Value.Status}");
> }
> else
>     Console.WriteLine($"Error: {result.Error?.Message}");
> ```

## Show Invoice

Retrieve details about a specific invoice.

```csharp
using Tavstal.PayPalSDK.Models.Invoices;

// Get invoice details
var request = new InvoiceShowRequest("INV2-Z56S-5LLA-Q52L-CPZ5");
var response = await client.SendAsync(request);

// Parse the response
var invoice = await request.GetResponseBodyAsync(response);

Console.WriteLine($"Invoice ID: {invoice?.Id}");
Console.WriteLine($"Status: {invoice?.Status}");
Console.WriteLine($"Amount: {invoice?.Amount?.Value} {invoice?.Amount?.CurrencyCode}");
```

> **High-level alternative:**
> ```csharp
> var result = await client.Invoices.ShowAsync("INV2-Z56S-5LLA-Q52L-CPZ5");
> if (result.IsSuccess)
> {
>     Console.WriteLine($"Invoice ID: {result.Value.Id}");
>     Console.WriteLine($"Status: {result.Value.Status}");
> }
> else
>     Console.WriteLine($"Error: {result.Error?.Message}");
> ```

## Send Invoice

Send an invoice to the recipient.

```csharp
using Tavstal.PayPalSDK.Models.Invoices;
using Tavstal.PayPalSDK.Models.Invoices.Bodies;

// Create send request
var body = new InvoiceSendRequestBody
{
    SendToInvoicer = true
};

// Send the invoice
var request = new InvoiceSendRequest("INV2-Z56S-5LLA-Q52L-CPZ5", body);
var response = await client.SendAsync(request);

Console.WriteLine("Invoice sent successfully");
```

> **High-level alternative:**
> ```csharp
> var result = await client.Invoices.SendAsync("INV2-Z56S-5LLA-Q52L-CPZ5", body);
> if (result.IsSuccess)
>     Console.WriteLine("Invoice sent successfully");
> else
>     Console.WriteLine($"Error: {result.Error?.Message}");
> ```

## List Invoices

List invoices with optional filtering.

```csharp
using Tavstal.PayPalSDK.Models.Invoices;

// List invoices
var request = new InvoiceListRequest();

var response = await client.SendAsync(request);

// Parse the response
var invoices = await request.GetResponseBodyAsync(response);

if (invoices?.Items != null)
{
    foreach (var invoice in invoices.Items)
    {
        Console.WriteLine($"Invoice ID: {invoice.Id}, Status: {invoice.Status}");
    }
}
```

> **High-level alternative:**
> ```csharp
> var result = await client.Invoices.ListAsync();
> if (result.IsSuccess && result.Value.Items != null)
>     foreach (var invoice in result.Value.Items)
>         Console.WriteLine($"Invoice ID: {invoice.Id}, Status: {invoice.Status}");
> else
>     Console.WriteLine($"Error: {result.Error?.Message}");
> ```

## Update Invoice

Update an existing invoice.

```csharp
using Tavstal.PayPalSDK.Models.Invoices;
using Tavstal.PayPalSDK.Models.Invoices.Bodies;

// Create updated invoice body
var body = new InvoiceUpdateRequestBody
{     
    Detail = new  Detail
    {
        Reference    = "deal-refernce-update",
        InvoiceDate  = "2025-01-15",
        CurrencyCode = "USD",
        Note         = "Thank you for your business.",
        TermsAndConditions = "No refunds after 30 days.",
        Memo         = "This is a long contract",
        PaymentTerm  = new PaymentTerm
        {
            TermType = "NET_10",
            DueDate  = "2025-01-25"
        },
        OrderDetails       = "Updated order #12345 details from Jan 10, 2025.",
        ProjectDetails     = "Updated website redesign project for XYZ Corp - added mobile optimization.",
        ServiceDetails     = "Additional consulting services Jan-Apr 2025.",
        CancellationPolicy = "Updated: Services may be cancelled with 30-day notice.",
        PaymentTerms       = "Updated: Payment due within 15 days of invoice date.",
        ReturnPolicy       = "Updated: All sales are final. No returns accepted after 15 days.",
        ServiceAgreement   = "Updated: Services provided as per revised agreement dated Feb 1, 2025.",
        TipPresets         =
            [
                new TipPreset { Percent = "15" }, 
                new TipPreset { Percent = "20" }, 
                new TipPreset { Percent = "25" }
            ]
    },
    Invoicer = new Invoicer
    {
        Name = new NameInfo
        {
            GivenName = "David",
            Surname   = "Larusso"
        },
        Address = new Address
        {
            AddressLineOne = "1234 First Street",
            AddressLineTwo = "337673 Hillside Court",
            AdminAreaTwo   = "Anytown",
            AdminAreaOne   = "CA",
            PostalCode   = "98765",
            CountryCode  = "US"
        },
        EmailAddress    = "merchant@example.com",
        Phones =
            [
                new InvoicePhone
                {
                    CountryCode    = "001",
                    NationalNumber = "4085551234",
                    PhoneType      = "MOBILE"
                }
            ],
        Website         = "www.test.com",
        TaxId           = "ABcNkWSfb5ICTt73nD3QON1fnnpgNKBy-Jb5SeuGj185MNNw6g",
        LogoUrl         = "https://example.com/logo.PNG",
        AdditionalNotes = "2-4"
    },
    PrimaryRecipients =
        [
            new Recipient
            {
                BillingInfo = new BusinessBillingInfo
                {
                    Name = new NameInfo
                    {
                        GivenName = "Stephanie",
                        Surname   = "Meyers"
                    },
                    Address = new Address
                    {
                        AddressLineOne = "1234 Main Street",
                        AdminAreaTwo   = "Anytown",
                        AdminAreaOne   = "CA",
                        PostalCode   = "98765",
                        CountryCode  = "US"
                    },
                    EmailAddress        = "bill-me@example.com",
                    Phones =
                        [
                            new InvoicePhone 
                            {
                                CountryCode    = "001",
                                NationalNumber = "4884551234",
                                PhoneType      = "HOME"
                            }
                        ],
                    AdditionalInfo = "add-info"
                },
                ShippingInfo = new ShippingInfo
                {
                    Name = new NameInfo
                    {
                        GivenName = "Stephanie",
                        Surname   = "Meyers"
                    },
                    Address = new Address
                    {
                        AddressLineOne = "1234 Main Street",
                        AdminAreaTwo   = "Anytown",
                        AdminAreaOne   = "CA",
                        PostalCode   = "98765",
                        CountryCode  = "US"
                    } 
                }
            }
        ],
    Items =
        [
            new InvoiceItem
            {
                Name        = "Yoga Mat",
                Description = "Elastic mat to practice yoga.",
                Quantity    = "1",
                UnitAmount  = new Money { CurrencyCode = "USD", Value = "50.00" },
                Tax = new Tax
                {
                    Name    = "Sales Tax",
                    Percent = "7.25",
                    TaxNote = "Reduced tax rate",
                    Amount  = new Money { CurrencyCode = "USD", Value = "3.27" }
                },
                Discount = new Discount
                {
                    Percent = "5",
                    Amount  = new Money { CurrencyCode = "USD", Value = "2.5" }
                },
                UnitOfMeasure = "QUANTITY"
            }, 
            new InvoiceItem
            {
                Name       = "Yoga t-shirt",
                Quantity   = "1",
                UnitAmount = new Money { CurrencyCode = "USD", Value = "10.00" },
                Tax = new Tax
                {
                    Name    = "Sales Tax",
                    Percent = "7.25",
                    Amount  = new Money { CurrencyCode = "USD", Value = "0.34" }
                },
                Discount = new Discount
                {
                    Amount = new Money { CurrencyCode = "USD", Value = "5.00" }
                },
                UnitOfMeasure = "QUANTITY"
            }
        ],
    Configuration = new InvoiceConfig
    {
        PartialPayment = new PartialPayment
        {
            AllowPartialPayment = true, 
            MinimalAmountDue    = new Money { CurrencyCode = "USD", Value = "20.00" }
        },
        AllowTip                   = true,
        TaxCalculatedAfterDiscount = true,
        TaxInclusive               = false,
        ShowAdditionalItemFields   = true,
        TemplateId                 = "TEMP-19V05281TU309413B",
        Theme = new InvoiceTheme
        {
            PrimaryColor = "#4A90D9"
        }
    },
    Amount = new InvoiceAmount
    {
        CurrencyCode = "USD",
        Value        = "74.21",
        Breakdown    = new InvoiceBreakdown
        {
            ItemTotal = new Money { CurrencyCode = "USD", Value = "60.00" },
            Custom = new InvoiceBreakdownCustom
            {
                Label  = "Packing Charges",
                Amount = new Money { CurrencyCode = "USD", Value = "10.00" }
            },
            Shipping = new InvoiceBreakdownShipping
            {
                Amount = new Money { CurrencyCode = "USD", Value = "10.00" },
                Tax = new Tax
                {
                    Name    = "Sales Tax",
                    Percent = "7.25",
                    Amount  = new Money { CurrencyCode = "USD", Value = "0.73" }
                }
            },
            Discount = new InvoiceBreakdownDiscount
            {
                ItemDiscount = new Money { CurrencyCode = "USD", Value = "-7.50" },
                InvoiceDiscount = new InvoiceDiscount
                {
                    Percent = "5",
                    Amount  = new Money { CurrencyCode = "USD", Value = "-2.63" }
                }
            },
            TaxTotal = new Money { CurrencyCode = "USD", Value = "4.34" }
        }
    },
    Settings = new InvoiceSettings
    {
                InvoiceItemSettings =
                [
                    new InvoiceFieldSetting { FieldName = "ITEM_DESCRIPTION", DisplayPreference = new InvoiceFieldDisplayPreference { Hidden = false } },
                    new InvoiceFieldSetting { FieldName = "ITEM_DATE",        DisplayPreference = new InvoiceFieldDisplayPreference { Hidden = true  } },
                    new InvoiceFieldSetting { FieldName = "ITEM_TAX",         DisplayPreference = new InvoiceFieldDisplayPreference { Hidden = false } },
                    new InvoiceFieldSetting { FieldName = "ITEM_DISCOUNT",    DisplayPreference = new InvoiceFieldDisplayPreference { Hidden = true  } }
                ],
                InvoiceAdditionalSettings =
                [
                    new InvoiceFieldSetting { FieldName = "ATTACHMENT", DisplayPreference = new InvoiceFieldDisplayPreference { Hidden = false } },
                    new InvoiceFieldSetting { FieldName = "MEMO",        DisplayPreference = new InvoiceFieldDisplayPreference { Hidden = false } },
                    new InvoiceFieldSetting { FieldName = "REFERENCE",   DisplayPreference = new InvoiceFieldDisplayPreference { Hidden = true  } }
                ],
                InvoicePolicyAndAgreementSettings =
                [
                    new InvoiceFieldSetting { FieldName = "TERMS_AND_CONDITIONS", DisplayPreference = new InvoiceFieldDisplayPreference { Hidden = false } },
                    new InvoiceFieldSetting { FieldName = "PAYMENT_TERMS",        DisplayPreference = new InvoiceFieldDisplayPreference { Hidden = false } },
                    new InvoiceFieldSetting { FieldName = "CANCELLATION_POLICY",  DisplayPreference = new InvoiceFieldDisplayPreference { Hidden = false } }
                ],
                InvoiceDetailsSettings =
                [
                    new InvoiceFieldSetting { FieldName = "SERVICE_DETAILS", DisplayPreference = new InvoiceFieldDisplayPreference { Hidden = false } }
                ]
    }
};

// Update the invoice
var request = new InvoiceUpdateRequest("INV2-Z56S-5LLA-Q52L-CPZ5", body);
var response = await client.SendAsync(request);

Console.WriteLine("Invoice updated successfully");
```

> **High-level alternative:**
> ```csharp
> var result = await client.Invoices.UpdateAsync("INV2-Z56S-5LLA-Q52L-CPZ5", body);
> if (result.IsSuccess)
>     Console.WriteLine("Invoice updated successfully");
> else
>     Console.WriteLine($"Error: {result.Error?.Message}");
> ```

## Record Payment

Record a payment for an invoice.

```csharp
using Tavstal.PayPalSDK.Models.Invoices;
using Tavstal.PayPalSDK.Models.Invoices.Bodies;
using Tavstal.PayPalSDK.Models.Common.Payments;

// Create payment record
var body = new InvoiceRecordPaymentRequestBody
{
    Method = "BANK_TRANSFER",
    Amount = new Money
    {
        CurrencyCode = "USD",
        Value = "100.00"
    },
    PaymentDate = "2018-05-01"
};

// Record the payment
var request = new InvoiceRecordPaymentRequest("INV2-Z56S-5LLA-Q52L-CPZ5", body);
var response = await client.SendAsync(request);

Console.WriteLine("Payment recorded successfully");
```

> **High-level alternative:**
> ```csharp
> var result = await client.Invoices.RecordPaymentAsync("INV2-Z56S-5LLA-Q52L-CPZ5", body);
> if (result.IsSuccess)
>     Console.WriteLine("Payment recorded successfully");
> else
>     Console.WriteLine($"Error: {result.Error?.Message}");
> ```

## Record Refund

Record a refund for an invoice.

```csharp
using Tavstal.PayPalSDK.Models.Invoices;
using Tavstal.PayPalSDK.Models.Invoices.Bodies;
using Tavstal.PayPalSDK.Models.Common.Payments;

// Create refund record
var body = new InvoiceRecordRefundRequestBody
{
    Method = "BANK_TRANSFER",
    Amount = new Money
    {
        CurrencyCode = "USD",
        Value = "100.00"
    },
    PaymentDate = "2018-05-01"
};

// Record the refund
var request = new InvoiceRecordRefundRequest("INV2-Z56S-5LLA-Q52L-CPZ5", body);
var response = await client.SendAsync(request);

Console.WriteLine("Refund recorded successfully");
```

> **High-level alternative:**
> ```csharp
> var result = await client.Invoices.RecordRefundAsync("INV2-Z56S-5LLA-Q52L-CPZ5", body);
> if (result.IsSuccess)
>     Console.WriteLine("Refund recorded successfully");
> else
>     Console.WriteLine($"Error: {result.Error?.Message}");
> ```

## Send Reminder

Send a payment reminder for an invoice.

```csharp
using Tavstal.PayPalSDK.Models.Invoices;
using Tavstal.PayPalSDK.Models.Invoices.Bodies;

// Create reminder request
var body = new InvoiceSendReminderRequestBody
{
    SendToInvoicer = true,
    SendToRecipient = true
};

// Send reminder
var request = new InvoiceSendReminderRequest("INV2-Z56S-5LLA-Q52L-CPZ5", body);
var response = await client.SendAsync(request);

Console.WriteLine("Reminder sent successfully");
```

> **High-level alternative:**
> ```csharp
> var result = await client.Invoices.SendReminderAsync("INV2-Z56S-5LLA-Q52L-CPZ5", body);
> if (result.IsSuccess)
>     Console.WriteLine("Reminder sent successfully");
> else
>     Console.WriteLine($"Error: {result.Error?.Message}");
> ```

## Cancel Invoice

Cancel an invoice.

```csharp
using Tavstal.PayPalSDK.Models.Invoices;
using Tavstal.PayPalSDK.Models.Invoices.Bodies;

// Create cancel request
var body = new InvoiceCancelRequestBody
{
    SendToInvoicer = true,
    SendToRecipient = true
};

// Cancel the invoice
var request = new InvoiceCancelRequest("INV2-Z56S-5LLA-Q52L-CPZ5", body);
var response = await client.SendAsync(request);

Console.WriteLine("Invoice cancelled successfully");
```

> **High-level alternative:**
> ```csharp
> var result = await client.Invoices.CancelAsync("INV2-Z56S-5LLA-Q52L-CPZ5", body);
> if (result.IsSuccess)
>     Console.WriteLine("Invoice cancelled successfully");
> else
>     Console.WriteLine($"Error: {result.Error?.Message}");
> ```

## Delete Invoice

Delete a draft invoice.

```csharp
using Tavstal.PayPalSDK.Models.Invoices;

// Delete the invoice
var request = new InvoiceDeleteRequest("INV2-Z56S-5LLA-Q52L-CPZ5");
var response = await client.SendAsync(request);

Console.WriteLine("Invoice deleted successfully");
```

> **High-level alternative:**
> ```csharp
> var result = await client.Invoices.DeleteAsync("INV2-Z56S-5LLA-Q52L-CPZ5");
> if (result.IsSuccess)
>     Console.WriteLine("Invoice deleted successfully");
> else
>     Console.WriteLine($"Error: {result.Error?.Message}");
> ```

## Generate Invoice Number

Generate a unique invoice number.

```csharp
using Tavstal.PayPalSDK.Models.Invoices;

// Generate invoice number
var request = new InvoiceGenerateNumberRequest();
var response = await client.SendAsync(request);

// Parse the response
var result = await request.GetResponseBodyAsync(response);

Console.WriteLine($"Generated Invoice Number: {result?.InvoiceNumber}");
```

> **High-level alternative:**
> ```csharp
> var genResult = await client.Invoices.GenerateNumberAsync();
> if (genResult.IsSuccess)
>     Console.WriteLine($"Generated Invoice Number: {genResult.Value.InvoiceNumber}");
> else
>     Console.WriteLine($"Error: {genResult.Error?.Message}");
> ```

## Search Invoices

Search for invoices using various criteria.

```csharp
using Tavstal.PayPalSDK.Models.Invoices;
using Tavstal.PayPalSDK.Models.Invoices.Bodies;

// Search invoices
var request = new InvoiceSearchRequest();
var response = await client.SendAsync(request);

// Parse the response
var results = await request.GetResponseBodyAsync(response);

Console.WriteLine($"Found {results?.Items?.Count} invoices");
```

> **High-level alternative:**
> ```csharp
> var searchResult = await client.Invoices.SearchAsync();
> if (searchResult.IsSuccess)
>     Console.WriteLine($"Found {searchResult.Value.Items?.Count} invoices");
> else
>     Console.WriteLine($"Error: {searchResult.Error?.Message}");
> ```
