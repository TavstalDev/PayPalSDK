using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Utils;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details.Extensions.Merchandize;

/// <summary>
/// Represents the details of a return in a PayPal dispute, including return mode, receipt status, confirmation number, and return time.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class ReturnDetails
{
    /// <summary>
    /// Gets or sets the mode of the return in the dispute, indicating how the item was returned (e.g., mail, in-person).
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("mode")]
    [StringLength(255)]
    public string?  Mode { get; set; }
    
    /// <summary>
    /// Gets or sets a value indicating whether a receipt was provided for the return in the dispute.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("receipt")]
    public bool Receipt { get; set; }
    
    /// <summary>
    /// Gets or sets the confirmation number associated with the return in the dispute, which may be used for tracking or verification purposes.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("return_confirmation_number")]
    [StringLength(255)]
    public string?  ReturnConfirmationNumber { get; set; }
    
    /// <summary>
    /// Gets or sets a value indicating whether the item has been returned in the dispute.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("returned")]
    public bool Returned { get; set; }
    
    /// <summary>
    /// Gets or sets the time when the item was returned in the dispute, in ISO 8601 format. This property is used to record the exact date and time of the return event.
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("return_time")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string?  ReturnTime { get; set; }
    
    /// <summary>
    /// Gets the return time as a <see cref="DateTime"/> object, if valid. This property converts the ISO 8601 formatted string into a DateTime object for easier manipulation and comparison in code.
    /// </summary>
    public DateTime? ReturnTimeAsDateTime => DateTimeHelper.FromISO8601(ReturnTime);

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(5, "Build")]
    public void Build() { }
}