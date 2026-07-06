using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;
using Tavstal.PayPalSDK.Models.Enums;

namespace Tavstal.PayPalSDK.Models.Common.Payments.Sources.PayPal;

/// <summary>
/// Represents tax information associated with a payment source in the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class TaxInfo
{
    /// <summary>
    /// Gets or sets the tax identification number.
    /// </summary>
    /// <remarks>
    /// This field is required and has a maximum length of 14 characters.
    /// </remarks>
    [FluentMember(0)]
    [JsonPropertyName("tax_id")]
    [StringLength(14)]
    [Required]
    public string? TaxId { get; set; }

    /// <summary>
    /// Gets or sets the type of the tax identification number.
    /// </summary>
    /// <remarks>
    /// This field is required and has a maximum length of 14 characters.
    /// </remarks>
    [FluentMember(1)]
    [Required]
    [JsonPropertyName("tax_id_type")]
    [StringLength(14)]
    public ETaxIdType TaxIdType { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}