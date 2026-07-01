using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details;

/// <summary>
/// Represents the communication details in a PayPal dispute, including notes, email, and the time the communication was posted.
/// </summary>
public class DisputeCommunicationDetails
{
    /// <summary>
    /// Gets or sets the note associated with the communication in the dispute. The note can contain additional information or context related to the dispute.
    /// </summary>
    [JsonPropertyName("note")]
    [StringLength(2000)]
    public string? Note { get; set; }
    
    /// <summary>
    /// Gets or sets the email address associated with the communication in the dispute. The email address must be a valid email format and is used for communication purposes.
    /// </summary>
    [JsonPropertyName("email")]
    [StringLength(254, MinimumLength = 3)]
    [RegularExpression("^(?:[A-Za-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[A-Za-z0-9!#$%&'*+/=?^_`{|}~-]+)*|\"(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21\\x23-\\x5b\\x5d-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])*\")@(?:(?:[A-Za-z0-9](?:[A-Za-z0-9-]*[A-Za-z0-9])?\\.)+[A-Za-z0-9](?:[A-Za-z0-9-]*[A-Za-z0-9])?|\\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[A-Za-z0-9-]*[A-Za-z0-9]:(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21-\\x5a\\x53-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])+)\\])$")]
    public string? Email { get; set; }
    
    /// <summary>
    /// Gets or sets the time when the communication was posted in the dispute, in ISO 8601 format. This property is used to record the exact date and time of the communication event.
    /// </summary>
    [JsonPropertyName("time_posted")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? TimePosted { get; set; }
}