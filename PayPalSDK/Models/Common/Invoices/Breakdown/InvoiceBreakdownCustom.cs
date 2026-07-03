using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Invoices.Breakdown;

/// <summary>
/// Represents a custom invoice breakdown line, defined by a user-provided label
/// and an associated monetary amount.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class InvoiceBreakdownCustom
{
    /// <summary>
    /// Gets or sets the custom label for this breakdown entry.
    /// </summary>
    /// <remarks>
    /// This property is required and serialized as <c>label</c>.
    /// Maximum length is 50 characters.
    /// </remarks>
    [FluentMember(0)]
    [JsonPropertyName("label")]
    [StringLength(50)]
    [Required]
    public string? Label { get; set; }

    /// <summary>
    /// Gets or sets the monetary amount associated with the custom label.
    /// </summary>
    /// <remarks>
    /// Serialized as <c>amount</c> in the PayPal invoice payload.
    /// </remarks>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("amount")]
    public Money? Amount { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}