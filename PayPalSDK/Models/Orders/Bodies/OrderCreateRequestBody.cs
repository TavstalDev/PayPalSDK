using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Orders;
using Tavstal.PayPalSDK.Models.Common.Payments;
using System.ComponentModel.DataAnnotations;
using M31.FluentApi.Attributes;
using Tavstal.PayPalSDK.Models.Enums;

namespace Tavstal.PayPalSDK.Models.Orders.Bodies;

/// <summary>
/// Represents the request body for creating an order within the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class OrderCreateRequestBody
{
    /// <summary>
    /// Gets or sets the list of purchase units for the order.
    /// </summary>
    /// <remarks>
    /// This field is required and represents the details of the items or services being purchased.
    /// </remarks>
    [FluentMember(0)]
    [JsonPropertyName("purchase_units")]
    [Required]
    public List<PurchaseUnit>? PurchaseUnits { get; set; }

    /// <summary>
    /// Gets or sets the intent of the order.
    /// </summary>
    /// <remarks>
    /// This field is required.
    /// </remarks>
    [FluentMember(1)]
    [Required]
    [JsonPropertyName("intent")]
    public EIntent Intent { get; set; }

    /// <summary>
    /// Gets or sets the payment source for the order.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the payment method or source used for the transaction.
    /// </remarks>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("payment_source")]
    public PaymentSource? PaymentSource { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(3, "Build")]
    public void Build() { }
}