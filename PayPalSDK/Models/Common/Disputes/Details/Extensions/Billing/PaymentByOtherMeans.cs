using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details.Extensions.Billing;

[DataContract]
public class PaymentByOtherMeans
{
    [JsonPropertyName("charge_different_from_original")]
    public bool ChargeDifferentFromOriginal { get; set; }
    
    [JsonPropertyName("received_duplicate")]
    public bool ReceivedDuplicate { get; set; }
    
    [JsonPropertyName("payment_method")]
    [StringLength(255)]
    public string? PaymentMethod { get; set; }
    
    [JsonPropertyName("payment_instrument_suffix")]
    [StringLength(4, MinimumLength = 2)]
    public string? PaymentInstrumentSuffix { get; set; }
}