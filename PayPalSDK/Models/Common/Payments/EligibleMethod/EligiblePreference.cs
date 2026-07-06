using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;
using Tavstal.PayPalSDK.Models.Enums.Payment;

namespace Tavstal.PayPalSDK.Models.Common.Payments.EligibleMethod;

/// <summary>
/// Represents user preferences that influence eligible payment method evaluation.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class EligiblePreference
{
    /// <summary>
    /// Gets or sets the payment flow to use when evaluating eligibility.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("payment_flow")]
    public EPaymentFlow? PaymentFlow { get; set; }
    
    /// <summary>
    /// Gets or sets a value indicating whether account details should be included.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("include_account_details")]
    public bool IncludeAccountDetails { get; set; }
    
    /// <summary>
    /// Gets or sets a value indicating whether vault tokens should be included.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("include_vault_tokens")]
    public bool IncludeVaultTokens { get; set; }
    
    /// <summary>
    /// Gets or sets the payment source constraint applied to eligibility.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("payment_source_constraint")]
    public EligibleConstraint? PaymentSourceConstraint { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(4, "Build")]
    public void Build() { }
}