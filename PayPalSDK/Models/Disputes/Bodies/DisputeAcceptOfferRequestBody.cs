using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Disputes.Bodies;

/// <summary>
/// Represents the request body for accepting an offer in a PayPal dispute.
/// </summary>
public class DisputeAcceptOfferRequestBody
{
    /// <summary>
    /// Gets or sets the note content to be included when accepting the offer in the dispute.
    /// </summary>
    [JsonPropertyName("note")]
    [StringLength(2000)]
    public required string Note { get; set; }
}