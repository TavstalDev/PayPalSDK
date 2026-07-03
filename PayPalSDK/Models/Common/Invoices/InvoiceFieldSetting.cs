using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Invoices;

/// <summary>
/// Represents configuration for a specific invoice field, including
/// the field identifier and its display preferences.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class InvoiceFieldSetting
{
    /// <summary>
    /// Gets or sets the invoice field name identifier.
    /// </summary>
    /// <remarks>
    /// Serialized as <c>field_name</c>. Maximum length is 255 characters.
    /// The value must match <c>^[A-Z0-9_]+$</c> (uppercase letters, digits, and underscores).
    /// </remarks>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("field_name")]
    [StringLength(255)]
    [RegularExpression("^[A-Z0-9_]+$")]
    public string? FieldName { get; set; }

    /// <summary>
    /// Gets or sets display preferences for the specified field.
    /// </summary>
    /// <remarks>
    /// Serialized as <c>display_preference</c> in the PayPal invoice payload.
    /// </remarks>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("display_preference")]
    public InvoiceFieldDisplayPreference? DisplayPreference { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}