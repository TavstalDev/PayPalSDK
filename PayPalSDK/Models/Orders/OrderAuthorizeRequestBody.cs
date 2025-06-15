using System.Runtime.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;

namespace Tavstal.PayPalSDK.Models.Orders;

/// <summary>
/// Represents the request body for authorizing an order within the PayPal SDK.
/// </summary>
[DataContract]
public class OrderAuthorizeRequestBody
{
    /// <summary>
    /// Gets or sets the payment source for the order authorization.
    /// </summary>
    /// <remarks>
    /// This field is optional and specifies the payment method or source used for the transaction.
    /// </remarks>
    [DataMember(Name = "payment_source", EmitDefaultValue = false)]
    public PaymentSource PaymentSource { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="OrderAuthorizeRequestBody"/> class.
    /// </summary>
    /// <param name="paymentSource">The payment source for the order authorization.</param>
    public OrderAuthorizeRequestBody(PaymentSource paymentSource)
    {
        PaymentSource = paymentSource;
    }
}
