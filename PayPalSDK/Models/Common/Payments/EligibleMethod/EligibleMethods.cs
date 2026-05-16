using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Payments.EligibleMethod;

/// <summary>
/// Represents a collection of eligible payment methods available for a customer.
/// </summary>
[DataContract]
public class EligibleMethods
{
    /// <summary>
    /// Gets or sets the PayPal payment method eligibility information.
    /// </summary>
    [JsonPropertyName("paypal")]
    public EligibleMethod? PayPal { get; set; }
    
    /// <summary>
    /// Gets or sets the Venmo payment method eligibility information.
    /// </summary>
    [JsonPropertyName("venmo")]
    public EligibleMethod? Venmo { get; set; }
    
    /// <summary>
    /// Gets or sets the PayPal Credit payment method eligibility information.
    /// </summary>
    [JsonPropertyName("paypal_credit")]
    public EligibleMethod? PayPalCredit { get; set; }
    
    /// <summary>
    /// Gets or sets the PayPal Pay Later payment method eligibility information.
    /// </summary>
    [JsonPropertyName("paypal_pay_later")]
    public EligibleMethod? PayPalPayLater { get; set; }
}