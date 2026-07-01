using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Disputes;

/// <summary>
/// Represents evidence used in PayPal dispute models.
/// </summary>
public class Evidence
{
    /// <summary>
    /// Gets or sets the type of evidence. This property can be null, has a maximum length of 255 characters, and must match the specified regular expression pattern (only uppercase letters, digits, and underscores are allowed).
    /// </summary>
    [JsonPropertyName("evidence_type")]
    [StringLength(255)]
    [RegularExpression("^[A-Z0-9_]+$")]
    public string? EvidenceType { get; set; }
    
    /// <summary>
    /// Gets or sets the list of evidence documents associated with the evidence. This property can be null and represents the collection of documents supporting the evidence.
    /// </summary>
    [JsonPropertyName("documents")]
    public List<EvidenceDocument>? Documents { get; set; }
    
    /// <summary>
    /// Gets or sets the notes related to the evidence. This property can be null and has a maximum length of 2000 characters.
    /// </summary>
    [JsonPropertyName("notes")]
    [StringLength(2000)]
    public string? Notes { get; set; }
    
    /// <summary>
    /// Gets or sets the item ID associated with the evidence. This property can be null and has a maximum length of 255 characters.
    /// </summary>
    [JsonPropertyName("item_id")]
    [StringLength(255)]
    public string? ItemId { get; set; }
    
    /// <summary>
    /// Gets or sets the list of evidence information associated with the evidence. This property can be null and represents additional details or metadata related to the evidence.
    /// </summary>
    [JsonPropertyName("evidence_info")]
    public List<EvidenceInfo>? EvidenceInfo { get; set; }
}