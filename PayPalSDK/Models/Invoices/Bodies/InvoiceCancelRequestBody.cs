using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Invoices.Bodies;

/// <summary>
/// Represents the request body used to cancel an invoice in the PayPal Invoicing API.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class InvoiceCancelRequestBody
{
    /// <summary>
    /// Gets or sets a value indicating whether a notification should be sent to the invoicer.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("send_to_invoicer")]
    public bool SendToInvoicer { get; set; }
    
    /// <summary>
    /// Gets or sets a value indicating whether a notification should be sent to the recipient.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("send_to_recipient")]
    public bool SendToRecipient { get; set; }
    
    /// <summary>
    /// Gets or sets the list of additional recipient email addresses.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("additional_recipients")]
    public List<string>? AdditionalRecipients { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(3, "Build")]
    public void Build() { }
}