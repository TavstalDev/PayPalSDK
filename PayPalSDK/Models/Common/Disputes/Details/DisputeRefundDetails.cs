using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details;

[DataContract]
public class DisputeRefundDetails
{
    [JsonPropertyName("transactions")]
    public List<DisputeRefundTransaction>? Transactions { get; set; }
    
    [JsonPropertyName("allowed_refund_amount")]
    public Money? AllowedRefundAmount { get; set; }
}