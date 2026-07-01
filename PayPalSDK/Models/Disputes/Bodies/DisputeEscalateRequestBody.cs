using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Disputes.Bodies;

/// <summary>
/// Represents the request body for escalating a PayPal dispute.
/// </summary>
public class DisputeEscalateRequestBody
{
    /// <summary>
    /// Gets or sets the note content to be included when escalating the dispute.
    /// </summary>
    [JsonPropertyName("note")]
    [StringLength(2000)]
    public required string Note { get; set; }
}