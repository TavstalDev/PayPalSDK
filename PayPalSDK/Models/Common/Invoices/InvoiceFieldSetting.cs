using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Invoices;

/// <summary>
/// Represents configuration for a specific invoice field, including
/// the field identifier and its display preferences.
/// </summary>
[DataContract]
public class InvoiceFieldSetting
{
    /// <summary>
    /// Gets or sets the invoice field name identifier.
    /// </summary>
    /// <remarks>
    /// Serialized as <c>field_name</c>. Maximum length is 255 characters.
    /// The value must match <c>^[A-Z0-9_]+$</c> (uppercase letters, digits, and underscores).
    /// </remarks>
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
    [JsonPropertyName("display_preference")]
    public InvoiceFieldDisplayPreference? DisplayPreference { get; set; }
}