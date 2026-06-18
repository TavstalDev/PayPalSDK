using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details;

[DataContract]
public class DisputeOutcome
{
   [JsonPropertyName("outcome_code")]
   [StringLength(255)]
   [RegularExpression("^[A-Z0-9_]+$")]
   public string? OutcomeCode { get; set; }
   
   // TODO: Finish implementation
}