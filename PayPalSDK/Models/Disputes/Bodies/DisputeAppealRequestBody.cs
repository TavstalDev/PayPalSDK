using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Addressing;
using Tavstal.PayPalSDK.Models.Common.Disputes;

namespace Tavstal.PayPalSDK.Models.Disputes.Bodies;

/// <summary>
/// Represents the request body for appealing a PayPal dispute.
/// </summary>
public class DisputeAppealRequestBody
{
    /// <summary>
    /// Gets or sets the list of evidences to be submitted for the dispute appeal.
    /// </summary>
    [JsonPropertyName("evidences")]
    public List<Evidence>? Evidences { get; set; }
    
    /// <summary>
    /// Gets or sets the return shipping address associated with the disputed item.
    /// </summary>
    [JsonPropertyName("return_shipping_address")]
    public Address? ReturnShippingAddress { get; set; }
    
    /// <summary>
    /// Gets or sets additional return shipping information, such as tracking details.
    /// </summary>
    [JsonPropertyName("return_shipping_address_info")]
    public ReturnShippingInfo? ReturnShippingAddressInfo { get; set; }
}