using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details;

[DataContract]
public class DisputeOutcome
{
   [JsonPropertyName("outcome_code")]
   [StringLength(255)]
   [RegularExpression("^[A-Z0-9_]+$")]
   public string? OutcomeCode { get; set; }
   
   [JsonPropertyName("outcome_reason")]
   [StringLength(255)]
   [RegularExpression("^[A-Z0-9_]+$")]
   public string? OutcomeReason { get; set; }
   
   [JsonPropertyName("amount_refunded")]
   public Money? AmountRefunded { get; set; }
   
   [JsonPropertyName("asset_refunded")]
   public GrossAsset? AssetRefunded { get; set; }
}