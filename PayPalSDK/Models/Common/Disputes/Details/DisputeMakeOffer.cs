using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details;

/// <summary>
/// Represents the offer-making details in a PayPal dispute, including the types of offers that can be made.
/// </summary>
public class DisputeMakeOffer
{
    /// <summary>
    /// Gets or sets the list of offer types that can be made in the dispute.
    /// </summary>
    [JsonPropertyName("offer_types")]
    public List<string>? OfferTypes { get; set; }
}