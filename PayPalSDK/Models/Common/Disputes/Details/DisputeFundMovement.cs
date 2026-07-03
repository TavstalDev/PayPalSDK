using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using Tavstal.PayPalSDK.Utils;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details;

/// <summary>
/// Represents a movement of funds associated with a dispute lifecycle event.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class DisputeFundMovement
{
    /// <summary>
    /// Gets or sets the party associated with the fund movement.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("party")]
    [StringLength(255)]
    public string? Party { get; set; }
    
    /// <summary>
    /// Gets or sets the type of fund movement.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("type")]
    [StringLength(255)]
    public string? Type { get; set; }
    
    /// <summary>
    /// Gets or sets the monetary amount moved in the dispute flow.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("amount")]
    public Money? Amount { get; set; }
    
    /// <summary>
    /// Gets or sets asset-specific details when the movement is represented as an asset.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("asset")]
    public Asset? Asset { get; set; }
    
    /// <summary>
    /// Gets or sets the timestamp when the fund movement was initiated, in ISO 8601 / RFC 3339 format.
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("initiated_time")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? InitiatedTime { get; set; }
    
    /// <summary>
    /// Gets or sets the reason code for the fund movement.
    /// </summary>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("reason")]
    [StringLength(255)]
    [RegularExpression("^[0-9A-Z_]+$")]
    public string? Reason { get; set; }
    
    /// <summary>
    /// Gets the <see cref="InitiatedTime"/> value parsed as a <see cref="DateTime"/>, if valid.
    /// </summary>
    public DateTime? InitiatedTimeAsDateTime => DateTimeHelper.FromISO8601(InitiatedTime);

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(6, "Build")]
    public void Build() { }
}