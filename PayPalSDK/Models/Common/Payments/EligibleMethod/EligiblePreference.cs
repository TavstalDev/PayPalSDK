using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Payments.EligibleMethod;

/// <summary>
/// Represents user preferences that influence eligible payment method evaluation.
/// </summary>
public class EligiblePreference
{
    /// <summary>
    /// Gets or sets the payment flow to use when evaluating eligibility.
    /// </summary>
    [JsonPropertyName("payment_flow")]
    public string? PaymentFlow { get; set; }
    
    /// <summary>
    /// Gets or sets a value indicating whether account details should be included.
    /// </summary>
    [JsonPropertyName("include_account_details")]
    public bool IncludeAccountDetails { get; set; }
    
    /// <summary>
    /// Gets or sets a value indicating whether vault tokens should be included.
    /// </summary>
    [JsonPropertyName("include_vault_tokens")]
    public bool IncludeVaultTokens { get; set; }
    
    /// <summary>
    /// Gets or sets the payment source constraint applied to eligibility.
    /// </summary>
    [JsonPropertyName("payment_source_constraint")]
    public EligibleConstraint? PaymentSourceConstraint { get; set; }
}