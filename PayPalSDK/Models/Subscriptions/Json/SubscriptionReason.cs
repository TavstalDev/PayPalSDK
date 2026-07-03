using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Subscriptions.Json;

/// <summary>
/// Represents a payload containing a human-readable reason associated with a subscription action
/// (for example, suspend or cancel operations in the PayPal Subscriptions API).
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class SubscriptionReason
{
    /// <summary>
    /// Gets or sets the reason text sent to the API.
    /// </summary>
    [FluentMember(0)]
    [JsonPropertyName("reason")]
    [StringLength(128)]
    [Required]
    public string? Reason { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(1, "Build")]
    public void Build() { }
}