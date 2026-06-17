using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Transactions;

[DataContract]
public class TransactionIncentiveInfo
{
    [JsonPropertyName("incentive_details")]
    public List<IncentiveDetail>? IncentiveDetails { get; set; }
}