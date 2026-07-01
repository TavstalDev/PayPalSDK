using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Utils;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details;

/// <summary>
/// Represents a message exchanged within a dispute conversation.
/// </summary>
public class DisputeMessage
{
    /// <summary>
    /// Gets or sets the actor who posted the message.
    /// </summary>
    [JsonPropertyName("posted_by")]
    [StringLength(255)]
    public string? PostedBy { get; set; }
    
    /// <summary>
    /// Gets or sets the textual content of the message.
    /// </summary>
    [JsonPropertyName("content")]
    [StringLength(255)]
    public string? Content { get; set; }
    
    /// <summary>
    /// Gets or sets documents attached to the message.
    /// </summary>
    [JsonPropertyName("documents")]
    public List<EvidenceDocument>? Documents { get; set; }
    
    /// <summary>
    /// Gets or sets the timestamp when the message was posted, in ISO 8601 / RFC 3339 format.
    /// </summary>
    [JsonPropertyName("time_posted")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? TimePosted { get; set; }
    
    /// <summary>
    /// Gets the <see cref="TimePosted"/> value parsed as a <see cref="DateTime"/>, if valid.
    /// </summary>
    public DateTime? TimePostedDateTime => DateTimeHelper.FromISO8601(TimePosted);
}