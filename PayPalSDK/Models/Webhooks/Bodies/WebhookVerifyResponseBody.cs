using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Webhooks.Bodies;

/// <summary>
/// Represents the response body for verifying a webhook in the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class WebhookVerifyResponseBody
{
    /// <summary>
    /// Gets or sets the verification status of the webhook.
    /// </summary>
    /// <remarks>
    /// The verification status indicates whether the webhook is successfully verified.
    /// </remarks>
    [FluentMember(0)]
    [JsonPropertyName("verification_status")]
    [Required]
    public string? VerificationStatus { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(1, "Build")]
    public void Build() { }
}