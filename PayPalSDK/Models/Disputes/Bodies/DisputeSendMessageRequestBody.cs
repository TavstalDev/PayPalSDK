using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Disputes.Bodies;

/// <summary>
/// Represents the request body for sending a message in a PayPal dispute.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class DisputeSendMessageRequestBody
{
    /// <summary>
    /// Gets or sets the message content to be sent in the dispute thread.
    /// This property is required and has a maximum length of 2000 characters.
    /// </summary>
    [FluentMember(0)]
    [JsonPropertyName("message")]
    [StringLength(2000)]
    [Required]
    public string? Message { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(1, "Build")]
    public void Build() { }
}