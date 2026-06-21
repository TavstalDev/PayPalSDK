using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Disputes;

namespace Tavstal.PayPalSDK.Models.Disputes.Bodies;

/// <summary>
/// Represents the request body for acknowledging a return in a PayPal dispute.
/// </summary>
[DataContract]
public class DisputeAcknowledgeReturnRequestBody
{
    /// <summary>
    /// Gets or sets the note content to be included when acknowledging the return in the dispute.
    /// </summary>
    [JsonPropertyName("note")]
    [StringLength(2000)]
    public string? Note { get; set; }
    
    /// <summary>
    /// Gets or sets the list of evidences to be submitted for acknowledging the return in the dispute.
    /// </summary>
    [JsonPropertyName("evidences")]
    public List<Evidence>? Evidences { get; set; }
}