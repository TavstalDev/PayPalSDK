using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;
using Tavstal.PayPalSDK.Models.Enums.Payment;

namespace Tavstal.PayPalSDK.Models.Common.Payments.EligibleMethod;

/// <summary>
/// Represents a restriction or rule that applies to payment method eligibility.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class EligibleConstraint
{
    /// <summary>
    /// Gets or sets the type of constraint applied to eligibility.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("constraint_type")]
    public EPaymentConstraintType? ConstraintType { get; set; }
    
    /// <summary>
    /// Gets or sets the payment sources affected by this constraint.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("payment_sources")]
    public List<EPaymentConstraintSource>? PaymentSources { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}