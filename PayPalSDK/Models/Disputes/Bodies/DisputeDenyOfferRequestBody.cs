using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Disputes.Bodies;

/// <summary>
/// Represents the request body for denying an offer in a PayPal dispute.
/// </summary>
[DataContract]
public class DisputeDenyOfferRequestBody
{
    /// <summary>
    /// Gets or sets the note content to be included when denying the offer in the dispute.
    /// </summary>
    [JsonPropertyName("note")]
    [StringLength(2000)]
    public required string Note { get; set; }
}