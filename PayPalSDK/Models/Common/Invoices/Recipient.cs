using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Addressing;
using Tavstal.PayPalSDK.Models.Common.Billing;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Invoices;

/// <summary>
/// Represents the recipient information for an invoice.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class Recipient
{
    /// <summary>
    /// Gets or sets the billing information of the recipient.
    /// </summary>
    /// <remarks>
    /// This includes details such as the business name, contact information, and address.
    /// </remarks>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("billing_info")]
    public BusinessBillingInfo? BillingInfo { get; set; }

    /// <summary>
    /// Gets or sets the shipping information of the recipient.
    /// </summary>
    /// <remarks>
    /// This includes details such as the shipping address and recipient name.
    /// </remarks>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("shipping_info")]
    public ShippingInfo? ShippingInfo { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}