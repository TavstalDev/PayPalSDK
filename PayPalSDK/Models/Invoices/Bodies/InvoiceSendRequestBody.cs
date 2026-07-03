using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Invoices.Bodies;

/// <summary>
/// Represents the request body for sending a PayPal invoice, including subject, note, recipient options, and additional recipients.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class InvoiceSendRequestBody
{
    /// <summary>
    /// Gets or sets the subject line of the email sent to recipients.
    /// </summary>
    /// <remarks>
    /// The subject must not exceed 4000 characters.
    /// </remarks>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("subject")]
    [StringLength(4000)]
    public string? Subject { get; set; }

    /// <summary>
    /// Gets or sets the note to include in the email sent to recipients.
    /// </summary>
    /// <remarks>
    /// The note must not exceed 4000 characters.
    /// </remarks>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("note")]
    [StringLength(4000)]
    public string? Note { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to send the invoice to the invoicer.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("send_to_invoicer")]
    public bool SendToInvoicer { get; set; } 

    /// <summary>
    /// Gets or sets a value indicating whether to send the invoice to the recipient.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("send_to_recipient")]
    public bool SendToRecipient { get; set; }

    /// <summary>
    /// Gets or sets the list of additional recipient email addresses.
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