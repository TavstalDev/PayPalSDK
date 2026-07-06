using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Addressing;
using M31.FluentApi.Attributes;
using Tavstal.PayPalSDK.Models.Enums;

namespace Tavstal.PayPalSDK.Models.Common.User;

/// <summary>
/// Represents a phone object in the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class Phone
{
    /// <summary>
    /// Gets or sets the type of the phone.
    /// </summary>
    /// <remarks>
    /// This field is optional.
    /// </remarks>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("phone_type")]
    public EPhoneType? PhoneType { get; set; }

    /// <summary>
    /// Gets or sets the phone number details.
    /// </summary>
    /// <remarks>
    /// This field is required and represents the phone number associated with the phone object.
    /// </remarks>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("phone_number")]
    public PhoneNumber? PhoneNumber { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}