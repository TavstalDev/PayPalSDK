using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Disputes.Bodies;

/// <summary>
/// Represents the request body for settling a PayPal dispute.
/// </summary>
public class DisputeSettleRequestBody
{
    /// <summary>
    /// Gets or sets the outcome of the adjudication for the dispute settlement.
    /// This property is required and has a maximum length of 255 characters.
    /// </summary>
    [JsonPropertyName("adjudication_outcome")]
    [StringLength(255)]
    public required string AdjudicationOutcome { get; set; }
}