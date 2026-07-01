using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Disputes.Bodies;

/// <summary>
/// Represents the request body for updating the status of a PayPal dispute.
/// </summary>
public class DisputeUpdateStatusRequestBody
{
    /// <summary>
    /// Gets or sets the action to be performed on the dispute.
    /// This property is required and has a maximum length of 255 characters.
    /// </summary>
    [JsonPropertyName("action")]
    [StringLength(255)]
    public required string Action { get; set; }
}