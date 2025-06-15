using System.Runtime.Serialization;
using Newtonsoft.Json;
using Tavstal.PayPalSDK.Models.Common.Orders;
using Tavstal.PayPalSDK.Models.Common.Payments;

namespace Tavstal.PayPalSDK.Models.Orders;

/// <summary>
/// Represents the request body for creating an order within the PayPal SDK.
/// </summary>
[DataContract]
public class OrderCreateRequestBody
{
    /// <summary>
    /// Gets or sets the list of purchase units for the order.
    /// </summary>
    /// <remarks>
    /// This field is required and represents the details of the items or services being purchased.
    /// </remarks>
    [DataMember(Name = "purchase_units", EmitDefaultValue = false)]
    [JsonRequired]
    public required List<PurchaseUnit> PurchaseUnits { get; set; }

    /// <summary>
    /// Gets or sets the intent of the order.
    /// </summary>
    /// <remarks>
    /// This field is required and specifies the purpose of the order, such as "CAPTURE" or "AUTHORIZE".
    /// </remarks>
    [DataMember(Name = "intent", EmitDefaultValue = false)]
    [JsonRequired]
    public required string Intent { get; set; }

    /// <summary>
    /// Gets or sets the payment source for the order.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the payment method or source used for the transaction.
    /// </remarks>
    [DataMember(Name = "payment_source", EmitDefaultValue = false)]
    public PaymentSource PaymentSource { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="OrderCreateRequestBody"/> class.
    /// </summary>
    /// <param name="purchaseUnits">The list of purchase units for the order.</param>
    /// <param name="intent">The intent of the order.</param>
    /// <param name="paymentSource">The payment source for the order.</param>
    public OrderCreateRequestBody(List<PurchaseUnit> purchaseUnits, string intent, PaymentSource paymentSource)
    {
        PurchaseUnits = purchaseUnits;
        Intent = intent;
        PaymentSource = paymentSource;
    }
}