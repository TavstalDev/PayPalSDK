using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Disputes.Bodies;

/// <summary>
/// Represents the request body for updating the status of a PayPal dispute.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class DisputeUpdateStatusRequestBody
{
    /// <summary>
    /// Gets or sets the action to be performed on the dispute.
    /// This property is required and has a maximum length of 255 characters.
    /// </summary>
    [FluentMember(0)]
    [JsonPropertyName("action")]
    [StringLength(255)]
    [Required]
    public string? Action { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(1, "Build")]
    public void Build() { }
}