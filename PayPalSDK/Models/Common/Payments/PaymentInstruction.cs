using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;
using Tavstal.PayPalSDK.Models.Enums.Shipping;

namespace Tavstal.PayPalSDK.Models.Common.Payments;

/// <summary>
/// Represents payment instructions in the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class PaymentInstruction
{
    /// <summary>
    /// Gets or sets the list of platform fees associated with the payment instruction.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the fees charged by the platform.
    /// </remarks>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("platform_fees")]
    public List<PlatformFee>? PlatformFees { get; set; }

    /// <summary>
    /// Gets or sets the payee pricing tier ID.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 20 characters.
    /// </remarks>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("payee_pricing_tier_id")]
    [StringLength(20)]
    public string? PayeePricingTierId { get; set; }

    /// <summary>
    /// Gets or sets the payee receivable foreign exchange rate ID.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 4000 characters.
    /// </remarks>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("payee_receivable_fx_rate_id")]
    [StringLength(4000)]
    public string? PayeeReceivableFxRateId { get; set; }

    /// <summary>
    /// Gets or sets the disbursement mode.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("disbursement_mode")]
    public EDisbursementMode? DisbursementMode { get; set; } = EDisbursementMode.INSTANT;

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(4, "Build")]
    public void Build() { }
}