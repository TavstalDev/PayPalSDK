using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Transactions;

/// <summary>
/// Represents incentive-related information for a transaction, including
/// one or more incentive detail entries returned by the API.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class TransactionIncentiveInfo
{
    /// <summary>
    /// Gets or sets the collection of incentive detail records applied to the transaction.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("incentive_details")]
    public List<IncentiveDetail>? IncentiveDetails { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(1, "Build")]
    public void Build() { }
}