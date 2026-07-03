using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Webhooks;
using Tavstal.PayPalSDK.Utils;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Webhooks.Bodies;

/// <summary>
/// Represents the request body for verifying a webhook signature in the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class WebhookVerifyRequestBody
{
    /// <summary>
    /// Gets or sets the algorithm used for authentication.
    /// </summary>
    /// <remarks>
    /// The authentication algorithm specifies the method used to sign the webhook transmission.
    /// </remarks>
    [FluentMember(0)]
    [JsonPropertyName("auth_algo")]
    [StringLength(100)]
    [Required]
    public string? AuthAlgo { get; set; }

    /// <summary>
    /// Gets or sets the URL of the certificate used for verification.
    /// </summary>
    /// <remarks>
    /// The certificate URL points to the public key used to verify the webhook signature.
    /// </remarks>
    [FluentMember(1)]
    [Required]
    [JsonPropertyName("cert_url")]
    [StringLength(500)]
    public string? CertUrl { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier of the transmission.
    /// </summary>
    /// <remarks>
    /// The transmission ID is a unique identifier for the webhook event transmission.
    /// </remarks>
    [FluentMember(2)]
    [Required]
    [JsonPropertyName("transmission_id")]
    [StringLength(50)]
    public string? TransmissionId { get; set; }

    /// <summary>
    /// Gets or sets the signature of the transmission.
    /// </summary>
    /// <remarks>
    /// The transmission signature is used to verify the authenticity of the webhook event.
    /// </remarks>
    [FluentMember(3)]
    [Required]
    [JsonPropertyName("transmission_sig")]
    [StringLength(500)]
    public string? TransmissionSig { get; set; }

    /// <summary>
    /// Gets or sets the time of the transmission.
    /// </summary>
    /// <remarks>
    /// The transmission time indicates when the webhook event was sent.
    /// </remarks>
    [FluentMember(4)]
    [Required]
    [JsonPropertyName("transmission_time")]
    [StringLength(100)]
    public string? TransmissionTime { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier of the webhook.
    /// </summary>
    /// <remarks>
    /// The webhook ID identifies the webhook associated with the event.
    /// </remarks>
    [FluentMember(5)]
    [Required]
    [JsonPropertyName("webhook_id")]
    [StringLength(50)]
    public string? WebhookId { get; set; }

    /// <summary>
    /// Gets or sets the webhook event data.
    /// </summary>
    /// <remarks>
    /// The webhook event contains the payload of the event triggered by the webhook.
    /// </remarks>
    [FluentMember(6)]
    [Required]
    [JsonPropertyName("webhook_event")]
    public WebhookEvent? WebhookEvent { get; set; }
    
    /// <summary>
    /// Gets the transmission time as a DateTime object.
    /// </summary>
    public DateTime? TransmissionTimeAsDateTime => DateTimeHelper.FromISO8601(TransmissionTime);

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(7, "Build")]
    public void Build() { }
}