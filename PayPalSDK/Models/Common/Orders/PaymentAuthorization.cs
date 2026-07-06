using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using Tavstal.PayPalSDK.Models.Common.Payments.Sources.Card;
using Tavstal.PayPalSDK.Models.Common.User;
using Tavstal.PayPalSDK.Utils;
using M31.FluentApi.Attributes;
using Tavstal.PayPalSDK.Models.Enums.Payment;

namespace Tavstal.PayPalSDK.Models.Common.Orders;

/// <summary>
/// Represents the details of a payment authorization, including its status, amount, and related metadata.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class PaymentAuthorization
{
    /// <summary>
    /// Gets or sets the status of the payment authorization.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("status")]
    public EAuthorizationStatus? Status { get; set; }

    /// <summary>
    /// Gets or sets the details of the status for the payment authorization.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("status_details")]
    public StatusDetails? StatusDetails { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the payment authorization.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the invoice ID associated with the payment authorization.
    /// </summary>
    /// <remarks>
    /// This field is optional and can be used for tracking purposes.
    /// </remarks>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("invoice_id")]
    public string? InvoiceId { get; set; }

    /// <summary>
    /// Gets or sets the custom ID associated with the payment authorization.
    /// </summary>
    /// <remarks>
    /// This field is optional and can be used for custom tracking purposes.
    /// </remarks>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("custom_id")]
    public string? CustomId { get; set; }

    /// <summary>
    /// Gets or sets the list of related links for the payment authorization.
    /// </summary>
    /// <remarks>
    /// These links provide HATEOAS (Hypermedia as the Engine of Application State) navigation.
    /// </remarks>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("links")]
    public List<Link>? Links { get; set; }

    /// <summary>
    /// Gets or sets the monetary amount authorized in the payment.
    /// </summary>
    [FluentMember(6)]
    [FluentSkippable]
    [JsonPropertyName("amount")]
    public Money? Amount { get; set; }

    /// <summary>
    /// Gets or sets the network transaction reference for the payment authorization.
    /// </summary>
    /// <remarks>
    /// This field contains details about the network transaction.
    /// </remarks>
    [FluentMember(7)]
    [FluentSkippable]
    [JsonPropertyName("network_transaction_reference")]
    public NetworkTransactionReference? NetworkTransactionReference { get; set; }

    /// <summary>
    /// Gets or sets the seller protection information for the payment authorization.
    /// </summary>
    /// <remarks>
    /// This field provides details about the seller protection status.
    /// </remarks>
    [FluentMember(8)]
    [FluentSkippable]
    [JsonPropertyName("seller_protection")]
    public SellerProtection? SellerProtection { get; set; }

    /// <summary>
    /// Gets or sets the expiration time of the payment authorization.
    /// </summary>
    /// <remarks>
    /// The time is represented as an ISO 8601 string.
    /// </remarks>
    [FluentMember(9)]
    [FluentSkippable]
    [JsonPropertyName("expiration_time")]
    [StringLength(64)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? ExpirationTime { get; set; }

    /// <summary>
    /// Gets or sets the creation time of the payment authorization.
    /// </summary>
    /// <remarks>
    /// The time is represented as an ISO 8601 string.
    /// </remarks>
    [FluentMember(10)]
    [FluentSkippable]
    [JsonPropertyName("create_time")]
    [StringLength(64)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? CreateTime { get; set; }

    /// <summary>
    /// Gets or sets the last update time of the payment authorization.
    /// </summary>
    /// <remarks>
    /// The time is represented as an ISO 8601 string.
    /// </remarks>
    [FluentMember(11)]
    [FluentSkippable]
    [JsonPropertyName("update_time")]
    [StringLength(64)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? UpdateTime { get; set; }

    /// <summary>
    /// Gets or sets the processor response for the payment authorization.
    /// </summary>
    /// <remarks>
    /// This field contains details about the response from the payment processor.
    /// </remarks>
    [FluentMember(12)]
    [FluentSkippable]
    [JsonPropertyName("processor_response")]
    public ProcessorResponse? ProcessorResponse { get; set; }
    
    /// <summary>
    /// Gets the parsed <see cref="DateTime"/> representation of <see cref="ExpirationTime"/>, if valid.
    /// </summary>
    public DateTime? ExpirationAsDateTime => DateTimeHelper.FromISO8601(ExpirationTime);

    /// <summary>
    /// Gets the parsed <see cref="DateTime"/> representation of <see cref="CreateTime"/>, if valid.
    /// </summary>
    public DateTime? CreateAsDateTime => DateTimeHelper.FromISO8601(CreateTime);

    /// <summary>
    /// Gets the parsed <see cref="DateTime"/> representation of <see cref="UpdateTime"/>, if valid.
    /// </summary>
    public DateTime? UpdateAsDateTime => DateTimeHelper.FromISO8601(UpdateTime);

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(13, "Build")]
    public void Build() { }
}