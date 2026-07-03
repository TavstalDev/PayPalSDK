using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Disputes.Bodies;

/// <summary>
/// Represents the request body for settling a PayPal dispute.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class DisputeSettleRequestBody
{
    /// <summary>
    /// Gets or sets the outcome of the adjudication for the dispute settlement.
    /// This property is required and has a maximum length of 255 characters.
    /// </summary>
    [FluentMember(0)]
    [JsonPropertyName("adjudication_outcome")]
    [StringLength(255)]
    [Required]
    public string? AdjudicationOutcome { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(1, "Build")]
    public void Build() { }
}