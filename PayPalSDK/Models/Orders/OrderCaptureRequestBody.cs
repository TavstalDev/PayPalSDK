using System.Runtime.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;

namespace Tavstal.PayPalSDK.Models.Orders;

/// <summary>
/// Represents the request body for capturing an order within the PayPal SDK.
/// </summary>
[DataContract]
public class OrderCaptureRequestBody
{
    /// <summary>
    /// Gets or sets the payment source for the order capture.
    /// </summary>
    /// <remarks>
    /// This field is optional and specifies the payment method or source used for the transaction.
    /// </remarks>
    [DataMember(Name = "payment_source", EmitDefaultValue = false)]
    public PaymentSource PaymentSource { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="OrderCaptureRequestBody"/> class.
    /// </summary>
    /// <param name="paymentSource">The payment source for the order capture.</param>
    public OrderCaptureRequestBody(PaymentSource paymentSource)
    {
        PaymentSource = paymentSource;
    }
}

