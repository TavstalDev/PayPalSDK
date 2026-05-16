using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Payments.EligibleMethod;

/// <summary>
/// Represents a restriction or rule that applies to payment method eligibility.
/// </summary>
[DataContract]
public class EligibleConstraint
{
    /// <summary>
    /// Gets or sets the type of constraint applied to eligibility.
    /// </summary>
    [JsonPropertyName("constraint_type")]
    public string? ConstraintType { get; set; }
    
    /// <summary>
    /// Gets or sets the payment sources affected by this constraint.
    /// </summary>
    [JsonPropertyName("payment_sources")]
    public List<string>? PaymentSources { get; set; }
}