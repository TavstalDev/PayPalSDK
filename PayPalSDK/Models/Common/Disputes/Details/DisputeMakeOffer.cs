using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details;

/// <summary>
/// Represents the offer-making details in a PayPal dispute, including the types of offers that can be made.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class DisputeMakeOffer
{
    /// <summary>
    /// Gets or sets the list of offer types that can be made in the dispute.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("offer_types")]
    public List<string>? OfferTypes { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(1, "Build")]
    public void Build() { }
}