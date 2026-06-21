using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Disputes.Bodies;

/// <summary>
/// Represents the request body for sending a message in a PayPal dispute.
/// </summary>
[DataContract]
public class DisputeSendMessageRequestBody
{
    /// <summary>
    /// Gets or sets the message content to be sent in the dispute thread.
    /// This property is required and has a maximum length of 2000 characters.
    /// </summary>
    [JsonPropertyName("message")]
    [StringLength(2000)]
    public required string Message { get; set; }
}