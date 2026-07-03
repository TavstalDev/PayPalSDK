using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Addressing;
using Tavstal.PayPalSDK.Models.Common.Payments;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Invoices;

/// <summary>
/// Represents a transaction associated with a PayPal invoice, including payment details, type, method, and shipping information.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class InvoiceTransaction
{
    /// <summary>
    /// Gets or sets the unique identifier for the payment associated with the transaction.
    /// </summary>
    /// <remarks>
    /// The payment ID must not exceed 22 characters.
    /// </remarks>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("payment_id")]
    [StringLength(22)]
    public string? PaymentId { get; set; }

    /// <summary>
    /// Gets or sets the note associated with the transaction.
    /// </summary>
    /// <remarks>
    /// The note must not exceed 2000 characters.
    /// </remarks>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("note")]
    [StringLength(2000)]
    public string? Note { get; set; }

    /// <summary>
    /// Gets or sets the type of the transaction.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the payment date for the transaction.
    /// </summary>
    /// <remarks>
    /// The date must follow the format YYYY-MM-DD.
    /// </remarks>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("payment_date")]
    [StringLength(10)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])$")]
    public string? PaymentDate { get; set; }

    /// <summary>
    /// Gets or sets the transaction method used for the payment.
    /// </summary>
    /// <remarks>
    /// Refer to <see cref="Tavstal.PayPalSDK.Constants.TransactionMethod"/> for valid values.
    /// </remarks>
    [FluentMember(0)]
    [Required]
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>
    /// Gets or sets the amount associated with the transaction.
    /// </summary>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("amount")]
    public Money? Amount { get; set; }

    /// <summary>
    /// Gets or sets the shipping information associated with the transaction.
    /// </summary>
    [FluentMember(6)]
    [FluentSkippable]
    [JsonPropertyName("shipping_info")]
    public ShippingInfo? ShippingInfo { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(7, "Build")]
    public void Build() { }
}