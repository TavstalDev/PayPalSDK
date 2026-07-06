using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using M31.FluentApi.Attributes;
using Tavstal.PayPalSDK.Models.Enums.Disputes;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details;

/// <summary>
/// Represents offer information within a dispute, including offer history
/// and current buyer/seller amounts.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class DisputeOffer
{
    /// <summary>
    /// Gets or sets the chronological history of offer-related dispute events.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("history")]
    public List<DisputeHistory>? History { get; set; }
    
    /// <summary>
    /// Gets or sets the amount requested by the buyer.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("buyer_requested_amount")]
    public Money? BuyerRequestedAmount { get; set; }
    
    /// <summary>
    /// Gets or sets the amount offered by the seller.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("seller_offered_amount")]
    public Money? SellerOfferedAmount { get; set; }
    
    /// <summary>
    /// Gets or sets the offer type code.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("offer_type")]
    public EDisputeOffer? OfferType { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(4, "Build")]
    public void Build() { }
}