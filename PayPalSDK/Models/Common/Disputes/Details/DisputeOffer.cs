using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details;

/// <summary>
/// Represents offer information within a dispute, including offer history
/// and current buyer/seller amounts.
/// </summary>
public class DisputeOffer
{
    /// <summary>
    /// Gets or sets the chronological history of offer-related dispute events.
    /// </summary>
    [JsonPropertyName("history")]
    public List<DisputeHistory>? History { get; set; }
    
    /// <summary>
    /// Gets or sets the amount requested by the buyer.
    /// </summary>
    [JsonPropertyName("buyer_requested_amount")]
    public Money? BuyerRequestedAmount { get; set; }
    
    /// <summary>
    /// Gets or sets the amount offered by the seller.
    /// </summary>
    [JsonPropertyName("seller_offered_amount")]
    public Money? SellerOfferedAmount { get; set; }
    
    /// <summary>
    /// Gets or sets the offer type code.
    /// </summary>
    [JsonPropertyName("offer_type")]
    [StringLength(255)]
    [RegularExpression("^[0-9A-Z_]+$")]
    public string? OfferType { get; set; }
}