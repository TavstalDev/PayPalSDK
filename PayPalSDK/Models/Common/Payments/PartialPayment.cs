using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Payments;

/// <summary>
/// Represents the partial payment options for an invoice, including whether partial payments are allowed and the minimum amount due.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class PartialPayment
{
    /// <summary>
    /// Gets or sets a value indicating whether partial payments are allowed for the invoice.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("allow_partial_payment")]
    public bool AllowPartialPayment { get; set; }

    /// <summary>
    /// Gets or sets the minimum amount due for a partial payment.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("minimum_amount_due")]
    public Money? MinimalAmountDue { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}