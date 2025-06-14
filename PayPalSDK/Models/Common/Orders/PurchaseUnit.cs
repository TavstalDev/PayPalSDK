using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Tavstal.PayPalSDK.Models.Common.Addressing;
using Tavstal.PayPalSDK.Models.Common.Payments;

namespace Tavstal.PayPalSDK.Models.Common.Orders;

/// <summary>
/// Represents a purchase unit in the PayPal SDK.
/// </summary>
[DataContract]
public class PurchaseUnit
{
    /// <summary>
    /// Gets or sets the reference ID for the purchase unit.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 256 characters.
    /// </remarks>
    [DataMember(Name = "reference_id", EmitDefaultValue = false)]
    [StringLength(256)]
    public string ReferenceId { get; set; }

    /// <summary>
    /// Gets or sets the description of the purchase unit.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 127 characters.
    /// </remarks>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    [StringLength(127)]
    public string Description { get; set; }

    /// <summary>
    /// Gets or sets the custom ID for the purchase unit.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 255 characters.
    /// </remarks>
    [DataMember(Name = "custom_id", EmitDefaultValue = false)]
    [StringLength(255)]
    public string CustomId { get; set; }

    /// <summary>
    /// Gets or sets the invoice ID for the purchase unit.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 127 characters.
    /// </remarks>
    [DataMember(Name = "invoice_id", EmitDefaultValue = false)]
    [StringLength(127)]
    public string InvoiceId { get; set; }

    /// <summary>
    /// Gets or sets the soft descriptor for the purchase unit.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 22 characters.
    /// </remarks>
    [DataMember(Name = "soft_descriptor", EmitDefaultValue = false)]
    [StringLength(22)]
    public string SoftDescriptor { get; set; }

    /// <summary>
    /// Gets or sets the list of items in the purchase unit.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the items included in the purchase unit.
    /// </remarks>
    [DataMember(Name = "items", EmitDefaultValue = false)]
    public List<Item> Items { get; set; }

    /// <summary>
    /// Gets or sets the monetary breakdown of the purchase unit.
    /// </summary>
    /// <remarks>
    /// This field is required and represents the amount details for the purchase unit.
    /// </remarks>
    [DataMember(Name = "amount", EmitDefaultValue = false)]
    public required MoneyBreakdown Amount { get; set; }

    /// <summary>
    /// Gets or sets the payee information for the purchase unit.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the recipient of the payment.
    /// </remarks>
    [DataMember(Name = "payee", EmitDefaultValue = false)]
    public Payee Payee { get; set; }

    /// <summary>
    /// Gets or sets the payment instructions for the purchase unit.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents specific payment instructions.
    /// </remarks>
    [DataMember(Name = "payment_instruction", EmitDefaultValue = false)]
    public PaymentInstruction PaymentInstruction { get; set; }

    /// <summary>
    /// Gets or sets the shipping information for the purchase unit.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the shipping details for the purchase unit.
    /// </remarks>
    [DataMember(Name = "shipping", EmitDefaultValue = false)]
    public Shipping Shipping { get; set; }

    /// <summary>
    /// Gets or sets the supplementary data for the purchase unit.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents additional data related to the purchase unit.
    /// </remarks>
    [DataMember(Name = "supplementary_data", EmitDefaultValue = false)]
    public SupplementaryData SupplementaryData { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="PurchaseUnit"/> class.
    /// </summary>
    /// <param name="referenceId">The reference ID for the purchase unit.</param>
    /// <param name="description">The description of the purchase unit.</param>
    /// <param name="customId">The custom ID for the purchase unit.</param>
    /// <param name="invoiceId">The invoice ID for the purchase unit.</param>
    /// <param name="softDescriptor">The soft descriptor for the purchase unit.</param>
    /// <param name="items">The list of items in the purchase unit.</param>
    /// <param name="amount">The monetary breakdown of the purchase unit.</param>
    /// <param name="payee">The payee information for the purchase unit.</param>
    /// <param name="paymentInstruction">The payment instructions for the purchase unit.</param>
    /// <param name="shipping">The shipping information for the purchase unit.</param>
    /// <param name="supplementaryData">The supplementary data for the purchase unit.</param>
    public PurchaseUnit(string referenceId, string description, string customId, string invoiceId, string softDescriptor, List<Item> items, MoneyBreakdown amount, Payee payee, PaymentInstruction paymentInstruction, Shipping shipping, SupplementaryData supplementaryData)
    {
        ReferenceId = referenceId;
        Description = description;
        CustomId = customId;
        InvoiceId = invoiceId;
        SoftDescriptor = softDescriptor;
        Items = items;
        Amount = amount;
        Payee = payee;
        PaymentInstruction = paymentInstruction;
        Shipping = shipping;
        SupplementaryData = supplementaryData;
    }
}