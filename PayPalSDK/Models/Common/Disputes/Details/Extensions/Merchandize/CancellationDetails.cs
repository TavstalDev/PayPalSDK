using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Utils;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details.Extensions.Merchandize;

/// <summary>
/// Represents the details of a cancellation in a PayPal dispute, including cancellation number, status, mode, and date.
/// </summary>
[DataContract]
public class CancellationDetails
{
    /// <summary>
    /// Gets or sets the cancellation number associated with the cancellation in the dispute.
    /// </summary>
    [JsonPropertyName("cancellation_number")]
    [StringLength(127)]
    public string? CancellationNumber { get; set; }
    
    /// <summary>
    /// Gets or sets a value indicating whether the cancellation has been completed in the dispute.
    /// </summary>
    [JsonPropertyName("cancelled")]
    public bool Cancelled { get; set; }
    
    /// <summary>
    /// Gets or sets the cancellation mode associated with the cancellation in the dispute.
    /// </summary>
    [JsonPropertyName("cancellation_mode")]
    [StringLength(255)]
    public string? CancellationMode { get; set; }
    
    /// <summary>
    /// Gets or sets the cancellation date associated with the cancellation in the dispute, in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("cancellation_date")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? CancellationDate { get; set; }
    
    /// <summary>
    /// Gets the cancellation date as a <see cref="DateTime"/> object, if valid.
    /// </summary>
    public DateTime? CancellationDateAsDateTime => DateTimeHelper.FromISO8601(CancellationDate);
}