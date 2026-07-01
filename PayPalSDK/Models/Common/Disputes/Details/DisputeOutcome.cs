using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details;

/// <summary>
/// Represents the outcome of a PayPal dispute, including the outcome code, reason, refunded amount, and refunded asset.
/// </summary>
public class DisputeOutcome
{
   /// <summary>
   /// Gets or sets the outcome code of the dispute, indicating the result of the dispute resolution.
   /// </summary>
   [JsonPropertyName("outcome_code")]
   [StringLength(255)]
   [RegularExpression("^[A-Z0-9_]+$")]
   public string? OutcomeCode { get; set; }
   
   /// <summary>
   /// Gets or sets the outcome reason of the dispute, providing additional context for the outcome code.
   /// </summary>
   [JsonPropertyName("outcome_reason")]
   [StringLength(255)]
   [RegularExpression("^[A-Z0-9_]+$")]
   public string? OutcomeReason { get; set; }
   
   /// <summary>
   /// Gets or sets the amount refunded as a result of the dispute resolution, if applicable.
   /// </summary>
   [JsonPropertyName("amount_refunded")]
   public Money? AmountRefunded { get; set; }
   
   /// <summary>
   /// Gets or sets the asset refunded as a result of the dispute resolution, if applicable.
   /// </summary>
   [JsonPropertyName("asset_refunded")]
   public Asset? AssetRefunded { get; set; }
}