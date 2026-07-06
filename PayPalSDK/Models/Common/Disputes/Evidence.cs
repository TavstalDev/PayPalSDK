using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;
using Tavstal.PayPalSDK.Models.Enums.Disputes;

namespace Tavstal.PayPalSDK.Models.Common.Disputes;

/// <summary>
/// Represents evidence used in PayPal dispute models.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class Evidence
{
    /// <summary>
    /// Gets or sets the type of evidence. This property can be null.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("evidence_type")]
    public EDisputeEvidenceType? EvidenceType { get; set; }
    
    /// <summary>
    /// Gets or sets the list of evidence documents associated with the evidence. This property can be null and represents the collection of documents supporting the evidence.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("documents")]
    public List<EvidenceDocument>? Documents { get; set; }
    
    /// <summary>
    /// Gets or sets the notes related to the evidence. This property can be null and has a maximum length of 2000 characters.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("notes")]
    [StringLength(2000)]
    public string? Notes { get; set; }
    
    /// <summary>
    /// Gets or sets the item ID associated with the evidence. This property can be null and has a maximum length of 255 characters.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("item_id")]
    [StringLength(255)]
    public string? ItemId { get; set; }
    
    /// <summary>
    /// Gets or sets the list of evidence information associated with the evidence. This property can be null and represents additional details or metadata related to the evidence.
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("evidence_info")]
    public List<EvidenceInfo>? EvidenceInfo { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(5, "Build")]
    public void Build() { }
}