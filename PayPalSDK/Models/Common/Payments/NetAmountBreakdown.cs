using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Payments;

/// <summary>
/// Represents the breakdown of the net amount in a payment transaction.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class NetAmountBreakdown
{
    /// <summary>
    /// The amount payable in the transaction.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("payable_amount")]
    public Money? PayableAmount { get; set; }

    /// <summary>
    /// The converted amount in the transaction's currency.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("converted_amount")]
    public Money? ConvertedAmount { get; set; }

    /// <summary>
    /// The exchange rate details used for the conversion.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("exchange_rate")]
    public ExchangeRate? ExchangeRate { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(3, "Build")]
    public void Build() { }
}