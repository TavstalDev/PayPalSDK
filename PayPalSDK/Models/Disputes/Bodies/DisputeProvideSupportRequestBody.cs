using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Disputes.Bodies;

/// <summary>
/// Represents the request body for providing support in a PayPal dispute.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class DisputeProvideSupportRequestBody
{
    /// <summary>
    /// Gets or sets the note content to be provided as support in the dispute.
    /// This property is required and has a maximum length of 2000 characters.
    /// </summary>
    [FluentMember(0)]
    [JsonPropertyName("notes")]
    [StringLength(2000)]
    [Required]
    public string? Notes { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(1, "Build")]
    public void Build() { }
}