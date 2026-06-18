using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Disputes.Details.Extensions;
using Tavstal.PayPalSDK.Utils;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details;

[DataContract]
public class DisputeExtensions
{
    [JsonPropertyName("merchant_contacted")]
    public bool MerchantContacted { get; set; }
    
    [JsonPropertyName("buyer_contacted_channel")]
    [StringLength(255)]
    public string? BuyerContactedChannel { get; set; }
    
    [JsonPropertyName("merchant_contacted_outcome")]
    [StringLength(255)]
    [RegularExpression("^[0-9A-Z_]+$")]
    public string? MerchantContactedOutcome { get; set; }
    
    [JsonPropertyName("merchant_contacted_time")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? MerchantContactedTime { get; set; }
    
    [JsonPropertyName("merchant_contacted_mode")]
    [StringLength(255)]
    [RegularExpression("^[0-9A-Z_]+$")]
    public string? MerchantContactedMode { get; set; }
    
    [JsonPropertyName("buyer_contacted_time")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? BuyerContactedTime { get; set; }
    
    [JsonPropertyName("billing_dispute_properties")]
    public BillingDisputeProperties? BillingDisputeProperties { get; set; }
    
    [JsonPropertyName("merchandize_dispute_properties")]
    public MerchandizeDisputeProperties? MerchandizeDisputeProperties { get; set; }
    
    [JsonPropertyName("reported_source")]
    [StringLength(255)]
    [RegularExpression("^[A-Z0-9_]+$")]
    public string? ReportedSource { get; set; }
    
    public DateTime? MerchantContactedTimeAsDateTime => DateTimeHelper.FromISO8601(MerchantContactedTime);
    
    public DateTime? BuyerContactedTimeAsDateTime => DateTimeHelper.FromISO8601(BuyerContactedTime);
}