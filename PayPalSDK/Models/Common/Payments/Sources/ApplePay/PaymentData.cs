using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Payments.Sources.ApplePay;

/// <summary>
/// Represents payment data for Apple Pay transactions within the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class PaymentData
{
    /// <summary>
    /// Gets or sets the cryptogram associated with the Apple Pay payment data.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 2000 characters.
    /// </remarks>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("cryptogram")]
    [StringLength(2000)]
    public string? Cryptogram { get; set; }

    /// <summary>
    /// Gets or sets the ECI (Electronic Commerce Indicator) associated with the Apple Pay payment data.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 256 characters.
    /// </remarks>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("eci_indicator")]
    [StringLength(256)]
    public string? EciIndicator { get; set; }

    /// <summary>
    /// Gets or sets the EMV (Europay, Mastercard, and Visa) data associated with the Apple Pay payment data.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 2000 characters.
    /// </remarks>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("emv_data")]
    [StringLength(2000)]
    public string? EmvData { get; set; }

    /// <summary>
    /// Gets or sets the PIN associated with the Apple Pay payment data.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 2000 characters.
    /// </remarks>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("pin")]
    [StringLength(2000)]
    public string? Pin { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(4, "Build")]
    public void Build() { }
}