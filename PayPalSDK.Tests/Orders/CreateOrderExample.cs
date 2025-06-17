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

namespace Tavstal.PayPalSDK.Tests.Orders;

/// <summary>
/// Represents an example for creating a PayPal order using the PayPal SDK.
/// </summary>
public class CreateOrderExample
{
    private readonly PayPalHttpClient _client; // The PayPal HTTP client used to send requests.
    private readonly string _currencyCode; // The currency code for the order.

    /// <summary>
    /// Initializes a new instance of the <see cref="CreateOrderExample"/> class.
    /// </summary>
    /// <param name="client">The PayPal HTTP client used to send requests.</param>
    /// <param name="currencyCode">The currency code for the order.</param>
    public CreateOrderExample(PayPalHttpClient client, string currencyCode)
    {
        _client = client;
        _currencyCode = currencyCode;
    }

    /// <summary>
    /// Executes the process of creating a PayPal order.
    /// </summary>
    /// <returns>
    /// A task that represents the asynchronous operation. 
    /// The task result contains a boolean indicating success or failure.
    /// </returns>
    public async Task<bool> DoAsync()
    {
        // Create the order request body with necessary details.
        var orderRequestBody = new OrderCreateRequestBody
        {
            Intent = PayPalIntent.CAPTURE, // Specifies the intent of the order (e.g., capture payment).
            PurchaseUnits = new List<PurchaseUnit>()
            {
                new()
                {
                    Amount = new MoneyBreakdown
                    {
                        CurrencyCode = _currencyCode, // Sets the currency code for the order.
                        Value = "10.00", // Specifies the total value of the order.
                        Breakdown = new Breakdown()
                        {
                            ItemTotal = new Money
                            {
                                CurrencyCode = _currencyCode,
                                Value = "10.00" // Specifies the total value of items in the order.
                            }
                        }
                    },
                    Description = "Test Order", // Description of the order.
                    CustomId = "CustomId123", // Custom identifier for the order.
                    Items =
                    [
                        new()
                        {
                            Category = ItemCategory.DIGITAL_GOODS, // Specifies the category of the item.
                            Name = "Test Item", // Name of the item.
                            Description = "This is a test item", // Description of the item.
                            Sku = "ITEM123", // Stock keeping unit identifier for the item.
                            UnitAmount = new Money
                            {
                                CurrencyCode = _currencyCode,
                                Value = "10.00" // Price per unit of the item.
                            },
                            Quantity = "1", // Quantity of the item.
                            Tax = new Money
                            {
                                CurrencyCode = _currencyCode,
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
            },
            PaymentSource = new PaymentSource
            {
                PayPal = new PayPalSource
                {
                    ExperienceContext = new ExperienceContext
                    {
                        UserAction = UserAction.PAY_NOW, // Specifies the user action (e.g., pay now).
                        BrandName = "My Test Store", // Brand name displayed to the user.
                        Locale = "en-US", // Locale for the user interface.
                        ShippingPreference = ShippingPreference.NO_SHIPPING, // Shipping preference for the order.
                        LandingPage = LandingPages.LOGIN, // Landing page type for the user.
                        PaymentMethodPreference = PaymentPreference.IMMEDIATE_PAYMENT_REQUIRED, // Payment method preference.
                        ReturnUrl = "https://localhost:5000/success", // URL to redirect the user upon successful payment.
                        CancelUrl = "https://localhost:5000/cancel", // URL to redirect the user upon payment cancellation.
                    }
                }
            }
        };

        // Create the order request and send it using the PayPal client.
        var orderRequest = new OrderCreateRequest(orderRequestBody);
        var response = await _client.SendAsync(orderRequest);

        if (response.IsSuccessStatusCode)
        {
            // Deserialize the response and check for success.
            var orderResponse = await response.Content.ReadFromJsonAsync<OrderBody>();
            if (orderResponse != null)
            {
                Console.WriteLine($"Order created successfully: {orderResponse.Id}");

                // Find and display the approval link for the order.
                var approvalLink = orderResponse.Links.Find(link => link.Rel == "payer-action");
                Console.WriteLine("Approval link found: " + approvalLink?.Href);
                return true;
            }

            Console.WriteLine("Failed to deserialize order response.");
            return false;
        }

        // Log the error details if the request fails.
        var errorContent = await response.Content.ReadAsStringAsync();
        Console.WriteLine($"Failed to create order. Status Code: {response.StatusCode}, Error: \n{errorContent}");
        return false;
    }
}