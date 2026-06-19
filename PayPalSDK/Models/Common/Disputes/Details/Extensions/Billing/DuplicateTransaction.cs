using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details.Extensions.Billing;


[DataContract]
public class DuplicateTransaction
{
    [JsonPropertyName("received_duplicate")]
    public bool ReceivedDuplicate { get; set; }
    
    [JsonPropertyName("original_transaction")]
    public DisputedTransaction? OriginalTransaction { get; set; }
}