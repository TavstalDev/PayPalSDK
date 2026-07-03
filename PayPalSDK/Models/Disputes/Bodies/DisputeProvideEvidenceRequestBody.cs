using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Addressing;
using Tavstal.PayPalSDK.Models.Common.Disputes;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Disputes.Bodies;

/// <summary>
/// Represents the request payload used to provide evidence for a dispute.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class DisputeProvideEvidenceRequestBody
{
    /// <summary>
    /// Gets or sets the collection of evidence entries submitted for the dispute.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("evidences")]
    public List<Evidence>? Evidences { get; set; }
    
    /// <summary>
    /// Gets or sets the return shipping address associated with the disputed item.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("return_shipping_address")]
    public Address? ReturnShippingAddress { get; set; }
    
    /// <summary>
    /// Gets or sets additional return shipping information, such as tracking details.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("return_shipping_address_info")]
    public ReturnShippingInfo? ReturnShippingAddressInfo { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(3, "Build")]
    public void Build() { }
}