using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Addressing;
using Tavstal.PayPalSDK.Models.Common.Payments;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Orders;

/// <summary>
/// Represents a purchase unit in the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class PurchaseUnit
{
    /// <summary>
    /// Gets or sets the reference ID for the purchase unit.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 256 characters.
    /// </remarks>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("reference_id")]
    [StringLength(256)]
    public string? ReferenceId { get; set; }

    /// <summary>
    /// Gets or sets the description of the purchase unit.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 127 characters.
    /// </remarks>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("description")]
    [StringLength(127)]
    public string? Description { get; set; }

    /// <summary>
    /// Gets or sets the custom ID for the purchase unit.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 255 characters.
    /// </remarks>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("custom_id")]
    [StringLength(255)]
    public string? CustomId { get; set; }

    /// <summary>
    /// Gets or sets the invoice ID for the purchase unit.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 127 characters.
    /// </remarks>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("invoice_id")]
    [StringLength(127)]
    public string? InvoiceId { get; set; }

    /// <summary>
    /// Gets or sets the soft descriptor for the purchase unit.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 22 characters.
    /// </remarks>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("soft_descriptor")]
    [StringLength(22)]
    public string? SoftDescriptor { get; set; }

    /// <summary>
    /// Gets or sets the list of items in the purchase unit.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the items included in the purchase unit.
    /// </remarks>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("items")]
    public List<Item>? Items { get; set; }

    /// <summary>
    /// Gets or sets the monetary breakdown of the purchase unit.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the amount details for the purchase unit.
    /// </remarks>
    [FluentMember(6)]
    [FluentSkippable]
    [JsonPropertyName("amount")]
    public MoneyBreakdown? Amount { get; set; }

    /// <summary>
    /// Gets or sets the payee information for the purchase unit.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the recipient of the payment.
    /// </remarks>
    [FluentMember(7)]
    [FluentSkippable]
    [JsonPropertyName("payee")]
    public Payee? Payee { get; set; }

    /// <summary>
    /// Gets or sets the payment instructions for the purchase unit.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents specific payment instructions.
    /// </remarks>
    [FluentMember(8)]
    [FluentSkippable]
    [JsonPropertyName("payment_instruction")]
    public PaymentInstruction? PaymentInstruction { get; set; }

    /// <summary>
    /// Gets or sets the shipping information for the purchase unit.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the shipping details for the purchase unit.
    /// </remarks>
    [FluentMember(9)]
    [FluentSkippable]
    [JsonPropertyName("shipping")]
    public Shipping? Shipping { get; set; }

    /// <summary>
    /// Gets or sets the supplementary data for the purchase unit.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents additional data related to the purchase unit.
    /// </remarks>
    [FluentMember(10)]
    [FluentSkippable]
    [JsonPropertyName("supplementary_data")]
    public SupplementaryData? SupplementaryData { get; set; }
    
    /// <summary>
    /// Gets or sets the payments information for the purchase unit.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the details of payments associated with the purchase unit.
    /// </remarks>
    [FluentMember(11)]
    [FluentSkippable]
    [JsonPropertyName("payments")]
    public PaymentsUnit? Payments { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(12, "Build")]
    public void Build() { }
}