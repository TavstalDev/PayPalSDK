using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using M31.FluentApi.Attributes;
using Tavstal.PayPalSDK.Models.Enums.Disputes;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details;

/// <summary>
/// Represents the outcome of a PayPal dispute, including the outcome code, reason, refunded amount, and refunded asset.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class DisputeOutcome
{
   /// <summary>
   /// Gets or sets the outcome code of the dispute, indicating the result of the dispute resolution.
   /// </summary>
   [FluentMember(0)]
   [FluentSkippable]
   [JsonPropertyName("outcome_code")]
   public EDisputeOutcomeCode? OutcomeCode { get; set; }
   
   /// <summary>
   /// Gets or sets the outcome reason of the dispute, providing additional context for the outcome code.
   /// </summary>
   [FluentMember(1)]
   [FluentSkippable]
   [JsonPropertyName("outcome_reason")]
   public EAdjudicationReason? OutcomeReason { get; set; }
   
   /// <summary>
   /// Gets or sets the amount refunded as a result of the dispute resolution, if applicable.
   /// </summary>
   [FluentMember(2)]
   [FluentSkippable]
   [JsonPropertyName("amount_refunded")]
   public Money? AmountRefunded { get; set; }
   
   /// <summary>
   /// Gets or sets the asset refunded as a result of the dispute resolution, if applicable.
   /// </summary>
   [FluentMember(3)]
   [FluentSkippable]
   [JsonPropertyName("asset_refunded")]
   public Asset? AssetRefunded { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(4, "Build")]
    public void Build() { }
}