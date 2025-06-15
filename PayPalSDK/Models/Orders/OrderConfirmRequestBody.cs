using System.Runtime.Serialization;
using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Models.Common.Payments;

namespace Tavstal.PayPalSDK.Models.Orders;

/// <summary>
/// Represents the request body for confirming an order within the PayPal SDK.
/// </summary>
[DataContract]
public class OrderConfirmRequestBody
{
    /// <summary>
    /// Gets or sets the application context for the PayPal transaction.
    /// </summary>
    /// <remarks>
    /// This field is optional and provides additional details about the transaction, such as branding and URLs.
    /// </remarks>
    [DataMember(Name = "application_context", EmitDefaultValue = false)]
    public ApplicationContext ApplicationContext { get; set; }

    /// <summary>
    /// Gets or sets the payment source for the order confirmation.
    /// </summary>
    /// <remarks>
    /// This field is required and specifies the payment method or source used for the transaction.
    /// </remarks>
    [DataMember(Name = "payment_source", EmitDefaultValue = false)]
    public required PaymentSource PaymentSource { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="OrderConfirmRequestBody"/> class.
    /// </summary>
    /// <param name="applicationContext">The application context for the PayPal transaction.</param>
    /// <param name="paymentSource">The payment source for the order confirmation.</param>
    public OrderConfirmRequestBody(ApplicationContext applicationContext, PaymentSource paymentSource)
    {
        ApplicationContext = applicationContext;
        PaymentSource = paymentSource;
    }
}
