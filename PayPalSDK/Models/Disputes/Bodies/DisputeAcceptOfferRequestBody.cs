using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Disputes.Bodies;

/// <summary>
/// Represents the request body for accepting an offer in a PayPal dispute.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class DisputeAcceptOfferRequestBody
{
    /// <summary>
    /// Gets or sets the note content to be included when accepting the offer in the dispute.
    /// </summary>
    [FluentMember(0)]
    [JsonPropertyName("note")]
    [StringLength(2000)]
    [Required]
    public string? Note { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(1, "Build")]
    public void Build() { }
}