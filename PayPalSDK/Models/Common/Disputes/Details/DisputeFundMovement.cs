using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using Tavstal.PayPalSDK.Utils;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details;

/// <summary>
/// Represents a movement of funds associated with a dispute lifecycle event.
/// </summary>
public class DisputeFundMovement
{
    /// <summary>
    /// Gets or sets the party associated with the fund movement.
    /// </summary>
    [JsonPropertyName("party")]
    [StringLength(255)]
    public string? Party { get; set; }
    
    /// <summary>
    /// Gets or sets the type of fund movement.
    /// </summary>
    [JsonPropertyName("type")]
    [StringLength(255)]
    public string? Type { get; set; }
    
    /// <summary>
    /// Gets or sets the monetary amount moved in the dispute flow.
    /// </summary>
    [JsonPropertyName("amount")]
    public Money? Amount { get; set; }
    
    /// <summary>
    /// Gets or sets asset-specific details when the movement is represented as an asset.
    /// </summary>
    [JsonPropertyName("asset")]
    public Asset? Asset { get; set; }
    
    /// <summary>
    /// Gets or sets the timestamp when the fund movement was initiated, in ISO 8601 / RFC 3339 format.
    /// </summary>
    [JsonPropertyName("initiated_time")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? InitiatedTime { get; set; }
    
    /// <summary>
    /// Gets or sets the reason code for the fund movement.
    /// </summary>
    [JsonPropertyName("reason")]
    [StringLength(255)]
    [RegularExpression("^[0-9A-Z_]+$")]
    public string? Reason { get; set; }
    
    /// <summary>
    /// Gets the <see cref="InitiatedTime"/> value parsed as a <see cref="DateTime"/>, if valid.
    /// </summary>
    public DateTime? InitiatedTimeAsDateTime => DateTimeHelper.FromISO8601(InitiatedTime);
}