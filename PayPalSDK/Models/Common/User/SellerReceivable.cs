using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using System.ComponentModel.DataAnnotations;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.User;

/// <summary>
/// Represents the seller receivable details in a PayPal transaction.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class SellerReceivable
{
    /// <summary>
    /// A list of platform fees associated with the transaction.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("platform_fees")]
    public List<PlatformFee>? PlatformFees { get; set; }

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
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("paypal_fee")]
    public Money? PaypalFee { get; set; }

    /// <summary>
    /// The PayPal fee in the receivable currency.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("paypal_fee_in_receivable_currency")]
    public Money? PaypalFeeInReceivableCurrency { get; set; }

    /// <summary>
    /// The net amount after deductions.
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("net_amount")]
    public Money? NetAmount { get; set; }

    /// <summary>
    /// The amount receivable by the seller.
    /// </summary>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("receivable_amount")]
    public Money? ReceivableAmount { get; set; }

    /// <summary>
    /// The exchange rate details for the transaction.
    /// </summary>
    [FluentMember(6)]
    [FluentSkippable]
    [JsonPropertyName("exchange_rate")]
    public ExchangeRate? ExchangeRate { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(7, "Build")]
    public void Build() { }
}