using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Utils;
using M31.FluentApi.Attributes;
using Tavstal.PayPalSDK.Models.Enums.Disputes;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details.Extensions.Merchandize;

/// <summary>
/// Represents the details of a cancellation in a PayPal dispute, including cancellation number, status, mode, and date.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class CancellationDetails
{
    /// <summary>
    /// Gets or sets the cancellation number associated with the cancellation in the dispute.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("cancellation_number")]
    [StringLength(127)]
    public string? CancellationNumber { get; set; }
    
    /// <summary>
    /// Gets or sets a value indicating whether the cancellation has been completed in the dispute.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("canceled")]
    public bool Cancelled { get; set; }
    
    /// <summary>
    /// Gets or sets the cancellation mode associated with the cancellation in the dispute.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("cancellation_mode")]
    public EDisputeCancellationMode? CancellationMode { get; set; }
    
    /// <summary>
    /// Gets or sets the cancellation date associated with the cancellation in the dispute, in ISO 8601 format.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("cancellation_date")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? CancellationDate { get; set; }
    
    /// <summary>
    /// Gets the cancellation date as a <see cref="DateTime"/> object, if valid.
    /// </summary>
    public DateTime? CancellationDateAsDateTime => DateTimeHelper.FromISO8601(CancellationDate);

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(4, "Build")]
    public void Build() { }
}