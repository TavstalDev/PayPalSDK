using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details;

[DataContract]
public class DisputeOffer
{
    [JsonPropertyName("history")]
    public List<DisputeHistory>? History { get; set; }
    
    [JsonPropertyName("buyer_requested_amount")]
    public Money? BuyerRequestedAmount { get; set; }
    
    [JsonPropertyName("seller_offered_amount")]
    public Money? SellerOfferedAmount { get; set; }
    
    [JsonPropertyName("offer_type")]
    [StringLength(255)]
    [RegularExpression("^[0-9A-Z_]+$")]
    public string? OfferType { get; set; }
}