using System.Net.Http.Json;
using Tavstal.PayPalSDK.Constants;
using Tavstal.PayPalSDK.Constants.Experience;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Common.Addressing;
using Tavstal.PayPalSDK.Models.Common.Orders;
using Tavstal.PayPalSDK.Models.Common.Payments;
using Tavstal.PayPalSDK.Models.Common.Payments.Sources;
using Tavstal.PayPalSDK.Models.Common.User;
using Tavstal.PayPalSDK.Models.Orders;

namespace Tavstal.PayPalSDK.Tests;

public class CreateOrderExample
{
    private readonly PayPalHttpClient _client;
    private readonly string _currencyCode;

    public CreateOrderExample(PayPalHttpClient client, string currencyCode)
    {
        _client = client;
        _currencyCode = currencyCode;
    }

    public async Task<bool> DoAsync()
    {
        // 3. Create order request body
        var orderRequestBody = new OrderCreateRequestBody
        {
            Intent = PayPalIntent.CAPTURE,
            PurchaseUnits = new List<PurchaseUnit>()
            {
                new()
                {
                    Amount = new MoneyBreakdown
                    {
                        CurrencyCode = _currencyCode,
                        Value = "10.00",
                        Breakdown = new Breakdown()
                        {
                            ItemTotal = new Money
                            {
                                CurrencyCode = _currencyCode,
                                Value = "10.00"
                            }
                        }
                    },
                    Description = "Test Order",
                    CustomId = "CustomId123",
                    Items =
                    [
                        new()
                        {
                            Category = ItemCategory.DIGITAL_GOODS,
                            Name = "Test Item",
                            Description = "This is a test item",
                            Sku = "ITEM123",
                            UnitAmount = new Money
                            {
                                CurrencyCode = _currencyCode,
                                Value = "10.00"
                            },
                            Quantity = "1",
                            Tax = new Money
                            {
                                CurrencyCode = _currencyCode,
                                Value = "0.00"
                            }
                        }
                    ],
                    // Used for billing
                    Shipping = new Shipping
                    {
                        EmailAddress = "sdk-customer@personal.example.com",
                        Name = new Person
                        {
                            FullName = "John Doe"
                        },
                        Address = new Address
                        {
                            AddressLineOne = "123 Test St",
                            AddressLineTwo = "Apt 4B",
                            AdminAreaOne = "CA",
                            AdminAreaTwo = "Los Angeles",
                            PostalCode = "90001",
                            CountryCode = "US"
                        }
                    },
                    Payee = new Payee
                    {
                        EmailAddress = "sdk-merchant@business.example.com"
                    }
                }
            },
            PaymentSource = new PaymentSource
            {
                PayPal = new PayPalSource
                {
                    ExperienceContext = new ExperienceContext
                    {
                        UserAction = UserAction.PAY_NOW,
                        BrandName = "My Test Store",
                        Locale = "en-US",
                        ShippingPreference = ShippingPreference.NO_SHIPPING,
                        LandingPage = LandingPages.LOGIN,
                        PaymentMethodPreference = PaymentPreference.IMMEDIATE_PAYMENT_REQUIRED,
                        ReturnUrl = "https://localhost:5000/success",
                        CancelUrl = "https://localhost:5000/cancel",
                    }
                }
            }
        };

        // 4. Create order request
        var orderRequest = new OrderCreateRequest(orderRequestBody);
        var response = await _client.SendAsync(orderRequest);

        if (response.IsSuccessStatusCode)
        {
            var orderResponse = await response.Content.ReadFromJsonAsync<OrderBody>();
            if (orderResponse != null)
            {
                Console.WriteLine($"Order created successfully: {orderResponse.Id}");
                
                var approvalLink = orderResponse.Links.Find(link => link.Rel == "payer-action");
                Console.WriteLine("Approval link found: " + approvalLink?.Href);
                return true;
            }

            Console.WriteLine("Failed to deserialize order response.");
            return false;
        }

        var errorContent = await response.Content.ReadAsStringAsync();
        Console.WriteLine($"Failed to create order. Status Code: {response.StatusCode}, Error: \n{errorContent}");
        return false;
    }
}