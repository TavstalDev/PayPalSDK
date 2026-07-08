using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Addressing;

/// <summary>
/// Represents return shipping information associated with a transaction, including whether to save the address to the buyer's profile and the return address details.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class ReturnShippingInfo
{
    /// <summary>
    /// Gets or sets a value indicating whether the return address should be saved to the buyer's profile.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("save_to_profile")]
    public bool? SaveToProfile { get; set; }
    
    /// <summary>
    /// Gets or sets the return shipping address.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("address")]
    public Address? Address { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}