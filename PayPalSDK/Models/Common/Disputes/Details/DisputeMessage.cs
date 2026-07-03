using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Utils;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details;

/// <summary>
/// Represents a message exchanged within a dispute conversation.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class DisputeMessage
{
    /// <summary>
    /// Gets or sets the actor who posted the message.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("posted_by")]
    [StringLength(255)]
    public string? PostedBy { get; set; }
    
    /// <summary>
    /// Gets or sets the textual content of the message.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("content")]
    [StringLength(255)]
    public string? Content { get; set; }
    
    /// <summary>
    /// Gets or sets documents attached to the message.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("documents")]
    public List<EvidenceDocument>? Documents { get; set; }
    
    /// <summary>
    /// Gets or sets the timestamp when the message was posted, in ISO 8601 / RFC 3339 format.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("time_posted")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? TimePosted { get; set; }
    
    /// <summary>
    /// Gets the <see cref="TimePosted"/> value parsed as a <see cref="DateTime"/>, if valid.
    /// </summary>
    public DateTime? TimePostedDateTime => DateTimeHelper.FromISO8601(TimePosted);

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(4, "Build")]
    public void Build() { }
}