using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Invoices;

/// <summary>
/// Represents display preferences for a specific invoice field.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class InvoiceFieldDisplayPreference
{
    /// <summary>
    /// Gets or sets a value indicating whether the associated invoice field
    /// is hidden from display.
    /// </summary>
    /// <remarks>
    /// Serialized as <c>hidden</c> in the PayPal invoice payload.
    /// </remarks>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("hidden")]
    public bool Hidden { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(1, "Build")]
    public void Build() { }
}