using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Invoices.Bodies;

/// <summary>
/// Represents the body of a request for sending a reminder for a PayPal invoice.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class InvoiceSendReminderRequestBody
{
    /// <summary>
    /// Gets or sets the subject of the reminder email.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("subject")]
    [StringLength(4000)]
    public string? Subject { get; set; }

    /// <summary>
    /// Gets or sets the note to be included in the reminder email.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("note")]
    [StringLength(4000)]
    public string? Note { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the reminder should be sent to the invoicer.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("send_to_invoicer")]
    public bool SendToInvoicer { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the reminder should be sent to the recipient.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("send_to_recipient")]
    public bool SendToRecipient { get; set; }
    
    /// <summary>
    /// Gets or sets a list of additional recipients to receive the reminder.
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("additional_recipients")]
    public List<string>? AdditionalRecipients { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(5, "Build")]
    public void Build() { }
}