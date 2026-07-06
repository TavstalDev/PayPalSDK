using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Models.Common.Orders;
using Tavstal.PayPalSDK.Models.Common.Payments;
using Tavstal.PayPalSDK.Models.Common.User;
using Tavstal.PayPalSDK.Utils;
using M31.FluentApi.Attributes;
using Tavstal.PayPalSDK.Models.Enums;
using Tavstal.PayPalSDK.Models.Enums.Orders;

namespace Tavstal.PayPalSDK.Models.Orders.Bodies;

/// <summary>
/// Represents the body of an order within the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class OrderBody
{
    /// <summary>
    /// Gets or sets the unique identifier of the order.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the order ID.
    /// </remarks>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the processing instruction for the order.
    /// </summary>
    /// <remarks>
    /// This field is optional and specifies how the order should be processed.
    /// </remarks>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("processing_instruction")]
    public string? ProcessingInstruction { get; set; }

    /// <summary>
    /// Gets or sets the list of purchase units for the order.
    /// </summary>
    /// <remarks>
    /// This field is optional and contains details of the items or services being purchased.
    /// </remarks>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("purchase_units")]
    public List<PurchaseUnit>? PurchaseUnits { get; set; }

    /// <summary>
    /// Gets or sets the list of links associated with the order.
    /// </summary>
    /// <remarks>
    /// This field is optional and provides hyperlinks related to the order.
    /// </remarks>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("links")]
    public List<Link>? Links { get; set; }

    /// <summary>
    /// Gets or sets the payment source for the order.
    /// </summary>
    /// <remarks>
    /// This field is optional and specifies the payment method or source used for the transaction.
    /// </remarks>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("payment_source")]
    public PaymentSource? PaymentSource { get; set; }

    /// <summary>
    /// Gets or sets the intent of the order.
    /// </summary>
    /// <remarks>
    /// This field is optional.
    /// </remarks>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("intent")]
    public EIntent? Intent { get; set; }

    /// <summary>
    /// Gets or sets the payer details for the order.
    /// </summary>
    /// <remarks>
    /// This field is optional and contains information about the payer.
    /// </remarks>
    [FluentMember(6)]
    [FluentSkippable]
    [JsonPropertyName("payer")]
    public Payer? Payer { get; set; }

    /// <summary>
    /// Gets or sets the status of the order.
    /// </summary>
    /// <remarks>
    /// This field is optional.
    /// </remarks>
    [FluentMember(7)]
    [FluentSkippable]
    [JsonPropertyName("status")]
    public EOrderStatus? Status { get; set; }

    /// <summary>
    /// Gets or sets the creation time of the order.
    /// </summary>
    /// <remarks>
    /// This field is optional and must follow the ISO 8601 format (YYYY-MM-DDTHH:mm:ssZ).
    /// </remarks>
    [FluentMember(8)]
    [FluentSkippable]
    [JsonPropertyName("create_time")]
    [StringLength(64)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? CreateTime { get; set; }

    /// <summary>
    /// Gets or sets the last update time of the order.
    /// </summary>
    /// <remarks>
    /// This field is optional and must follow the ISO 8601 format (YYYY-MM-DDTHH:mm:ssZ).
    /// </remarks>
    [FluentMember(9)]
    [FluentSkippable]
    [JsonPropertyName("update_time")]
    [StringLength(64)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? UpdateTime { get; set; }
    
    /// <summary>
    /// Gets the creation time of the order as a nullable DateTime object.
    /// </summary>
    public DateTime? CreateTimeAsDateTime => DateTimeHelper.FromISO8601(CreateTime);
    
    /// <summary>
    /// Gets the last update time of the order as a nullable DateTime object.
    /// </summary>
    public DateTime? UpdateTimeAsDateTime => DateTimeHelper.FromISO8601(UpdateTime);

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(10, "Build")]
    public void Build() { }
}