using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using System.ComponentModel.DataAnnotations;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.User;

/// <summary>
/// Represents the details of the seller's payable amounts in a transaction.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class SellerPayable
{
    /// <summary>
    /// A list of platform fees associated with the transaction.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("platform_fees")]
    public List<PlatformFee>? PlatformFees { get; set; }

    /// <summary>
    /// A breakdown of the net amount in the transaction.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("net_amount_breakdown")]
    public List<NetAmountBreakdown>? NetAmountBreakdown { get; set; }

    /// <summary>
    /// The gross amount of the transaction.
    /// </summary>
    [FluentMember(0)]
    [Required]
    [JsonPropertyName("gross_amount")]
    public Money? GrossAmount { get; set; }

    /// <summary>
    /// The PayPal fee deducted from the transaction.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("paypal_fee")]
    public Money? PaypalFee { get; set; }

    /// <summary>
    /// The PayPal fee in the receivable currency.
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("paypal_fee_in_receivable_currency")]
    public Money? PaypalFeeInReceivableCurrency { get; set; }

    /// <summary>
    /// The net amount after deductions.
    /// </summary>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("net_amount")]
    public Money? NetAmount { get; set; }

    /// <summary>
    /// The net amount in the receivable currency after deductions.
    /// </summary>
    [FluentMember(6)]
    [FluentSkippable]
    [JsonPropertyName("net_amount_in_receivable_currency")]
    public Money? NetAmountInReceivableCurrency { get; set; }

    /// <summary>
    /// The total refunded amount in the transaction.
    /// </summary>
    [FluentMember(7)]
    [FluentSkippable]
    [JsonPropertyName("total_refunded_amount")]
    public Money? TotalRefundedAmount { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(8, "Build")]
    public void Build() { }
}