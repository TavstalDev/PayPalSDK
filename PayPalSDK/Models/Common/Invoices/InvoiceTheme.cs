using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Invoices;

/// <summary>
/// Represents visual theme settings for an invoice.
/// </summary>
/// <remarks>
/// This model currently supports customization of the invoice primary color.
/// </remarks>
[FluentApi(builderClassName: "{Name}Builder")]
public class InvoiceTheme
{
    /// <summary>
    /// Gets or sets the primary color used in the invoice theme.
    /// </summary>
    /// <remarks>
    /// The value length must be between 4 and 7 characters, typically corresponding
    /// to short or full hexadecimal color notation (for example, <c>#FFF</c> or <c>#FFFFFF</c>).
    /// </remarks>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("primary_color")]
    [StringLength(7, MinimumLength = 4)]
    public string? PrimaryColor { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(1, "Build")]
    public void Build() { }
}