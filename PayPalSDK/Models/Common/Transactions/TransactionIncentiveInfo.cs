using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Transactions;

/// <summary>
/// Represents incentive-related information for a transaction, including
/// one or more incentive detail entries returned by the API.
/// </summary>
[DataContract]
public class TransactionIncentiveInfo
{
    /// <summary>
    /// Gets or sets the collection of incentive detail records applied to the transaction.
    /// </summary>
    [JsonPropertyName("incentive_details")]
    public List<IncentiveDetail>? IncentiveDetails { get; set; }
}