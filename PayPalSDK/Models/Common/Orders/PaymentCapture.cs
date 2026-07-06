using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using Tavstal.PayPalSDK.Models.Common.Payments.Sources.Card;
using Tavstal.PayPalSDK.Models.Common.User;
using Tavstal.PayPalSDK.Utils;
using M31.FluentApi.Attributes;
using Tavstal.PayPalSDK.Models.Enums.Shipping;

namespace Tavstal.PayPalSDK.Models.Common.Orders;

/// <summary>
/// Represents the details of a payment capture, including its metadata, amount, and related information.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class PaymentCapture
{
    /// <summary>
    /// Gets or sets the creation time of the payment capture.
    /// </summary>
    /// <remarks>
    /// The time is represented as an ISO 8601 string.
    /// </remarks>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("create_time")]
    public string? CreateTime { get; set; }

    /// <summary>
    /// Gets or sets the last update time of the payment capture.
    /// </summary>
    /// <remarks>
    /// The time is represented as an ISO 8601 string.
    /// </remarks>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("update_time")]
    public string? UpdateTime { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the payment capture.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the invoice ID associated with the payment capture.
    /// </summary>
    /// <remarks>
    /// This field is optional and can be used for tracking purposes.
    /// </remarks>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("invoice_id")]
    public string? InvoiceId { get; set; }

    /// <summary>
    /// Gets or sets the custom ID associated with the payment capture.
    /// </summary>
    /// <remarks>
    /// This field is optional and can be used for custom tracking purposes.
    /// </remarks>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("custom_id")]
    public string? CustomId { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this is the final capture for the payment.
    /// </summary>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("final_capture")]
    public bool FinalCapture { get; set; }

    /// <summary>
    /// Gets or sets the list of related links for the payment capture.
    /// </summary>
    /// <remarks>
    /// These links provide HATEOAS (Hypermedia as the Engine of Application State) navigation.
    /// </remarks>
    [FluentMember(6)]
    [FluentSkippable]
    [JsonPropertyName("links")]
    public List<Link>? Links { get; set; }

    /// <summary>
    /// Gets or sets the monetary amount captured in the payment.
    /// </summary>
    [FluentMember(7)]
    [FluentSkippable]
    [JsonPropertyName("amount")]
    public Money? Amount { get; set; }

    /// <summary>
    /// Gets or sets the network transaction reference for the payment capture.
    /// </summary>
    /// <remarks>
    /// This field contains details about the network transaction.
    /// </remarks>
    [FluentMember(8)]
    [FluentSkippable]
    [JsonPropertyName("network_transaction_reference")]
    public NetworkTransactionReference? NetworkTransactionReference { get; set; }

    /// <summary>
    /// Gets or sets the seller protection information for the payment capture.
    /// </summary>
    /// <remarks>
    /// This field provides details about the seller protection status.
    /// </remarks>
    [FluentMember(9)]
    [FluentSkippable]
    [JsonPropertyName("seller_protection")]
    public SellerProtection? SellerProtection { get; set; }

    /// <summary>
    /// Gets or sets the disbursement mode for the payment capture.
    /// </summary>
    /// <remarks>
    /// This field indicates how the funds are disbursed (e.g., INSTANT or DELAYED).
    /// </remarks>
    [FluentMember(10)]
    [FluentSkippable]
    [JsonPropertyName("disbursement_mode")]
    public EDisbursementMode? DisbursementMode { get; set; }

    /// <summary>
    /// Gets or sets the processor response for the payment capture.
    /// </summary>
    /// <remarks>
    /// This field contains details about the response from the payment processor.
    /// </remarks>
    [FluentMember(11)]
    [FluentSkippable]
    [JsonPropertyName("processor_response")]
    public ProcessorResponse? ProcessorResponse { get; set; }
    
    /// <summary>
    /// Gets the parsed <see cref="DateTime"/> representation of <see cref="CreateTime"/>, if valid.
    /// </summary>
    public DateTime? CreateTimeAsDateTime => DateTimeHelper.FromISO8601(CreateTime);

    /// <summary>
    /// Gets the parsed <see cref="DateTime"/> representation of <see cref="UpdateTime"/>, if valid.
    /// </summary>
    public DateTime? UpdateTimeAsDateTime => DateTimeHelper.FromISO8601(UpdateTime);

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(12, "Build")]
    public void Build() { }
}