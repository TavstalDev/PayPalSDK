using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Disputes;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Disputes.Bodies;

/// <summary>
/// Represents the request body for acknowledging a return in a PayPal dispute.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class DisputeAcknowledgeReturnRequestBody
{
    /// <summary>
    /// Gets or sets the note content to be included when acknowledging the return in the dispute.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("note")]
    [StringLength(2000)]
    public string? Note { get; set; }
    
    /// <summary>
    /// Gets or sets the list of evidences to be submitted for acknowledging the return in the dispute.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("evidences")]
    public List<Evidence>? Evidences { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}