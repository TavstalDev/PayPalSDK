using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Models.Common.Orders;
using Tavstal.PayPalSDK.Models.Common.Payments;
using Tavstal.PayPalSDK.Models.Common.User;

namespace Tavstal.PayPalSDK.Models.Orders;

/// <summary>
/// Represents the body of an order within the PayPal SDK.
/// </summary>
[DataContract]
public class OrderBody
{
    /// <summary>
    /// Gets or sets the unique identifier of the order.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the order ID.
    /// </remarks>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }

    /// <summary>
    /// Gets or sets the processing instruction for the order.
    /// </summary>
    /// <remarks>
    /// This field is optional and specifies how the order should be processed.
    /// </remarks>
    [DataMember(Name = "processing_instruction", EmitDefaultValue = false)]
    public string ProcessingInstruction { get; set; }

    /// <summary>
    /// Gets or sets the list of purchase units for the order.
    /// </summary>
    /// <remarks>
    /// This field is optional and contains details of the items or services being purchased.
    /// </remarks>
    [DataMember(Name = "purchase_units", EmitDefaultValue = false)]
    public List<PurchaseUnit> PurchaseUnits { get; set; }

    /// <summary>
    /// Gets or sets the list of links associated with the order.
    /// </summary>
    /// <remarks>
    /// This field is optional and provides hyperlinks related to the order.
    /// </remarks>
    [DataMember(Name = "links", EmitDefaultValue = false)]
    public List<Link> Links { get; set; }

    /// <summary>
    /// Gets or sets the payment source for the order.
    /// </summary>
    /// <remarks>
    /// This field is optional and specifies the payment method or source used for the transaction.
    /// </remarks>
    [DataMember(Name = "payment_source", EmitDefaultValue = false)]
    public PaymentSource PaymentSource { get; set; }

    /// <summary>
    /// Gets or sets the intent of the order.
    /// </summary>
    /// <remarks>
    /// This field is optional and specifies the purpose of the order, such as "CAPTURE" or "AUTHORIZE".
    /// </remarks>
    /// <see cref="Tavstal.PayPalSDK.Constants.PayPalIntent"/>
    [DataMember(Name = "intent", EmitDefaultValue = false)]
    public string Intent { get; set; }

    /// <summary>
    /// Gets or sets the payer details for the order.
    /// </summary>
    /// <remarks>
    /// This field is optional and contains information about the payer.
    /// </remarks>
    [DataMember(Name = "payer", EmitDefaultValue = false)]
    public Payer Payer { get; set; }

    /// <summary>
    /// Gets or sets the status of the order.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the current status of the order.
    /// </remarks>
    /// <see cref="Tavstal.PayPalSDK.Constants.OrderStatus"/>
    [DataMember(Name = "status", EmitDefaultValue = false)]
    [StringLength(255)]
    [RegularExpression("^[0-9A-Z_]+$")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or sets the creation time of the order.
    /// </summary>
    /// <remarks>
    /// This field is optional and must follow the ISO 8601 format (YYYY-MM-DDTHH:mm:ssZ).
    /// </remarks>
    [DataMember(Name = "create_time", EmitDefaultValue = false)]
    [StringLength(64)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string CreateTime { get; set; }

    /// <summary>
    /// Gets or sets the last update time of the order.
    /// </summary>
    /// <remarks>
    /// This field is optional and must follow the ISO 8601 format (YYYY-MM-DDTHH:mm:ssZ).
    /// </remarks>
    [DataMember(Name = "update_time", EmitDefaultValue = false)]
    [StringLength(64)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string UpdateTime { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="OrderBody"/> class.
    /// </summary>
    /// <param name="id">The unique identifier of the order.</param>
    /// <param name="processingInstruction">The processing instruction for the order.</param>
    /// <param name="purchaseUnits">The list of purchase units for the order.</param>
    /// <param name="links">The list of links associated with the order.</param>
    /// <param name="paymentSource">The payment source for the order.</param>
    /// <param name="intent">The intent of the order.</param>
    /// <param name="payer">The payer details for the order.</param>
    /// <param name="status">The status of the order.</param>
    /// <param name="createTime">The creation time of the order.</param>
    /// <param name="updateTime">The last update time of the order.</param>
    public OrderBody(string id, string processingInstruction, List<PurchaseUnit> purchaseUnits, List<Link> links, PaymentSource paymentSource, string intent, Payer payer, string status, string createTime, string updateTime)
    {
        Id = id;
        ProcessingInstruction = processingInstruction;
        PurchaseUnits = purchaseUnits;
        Links = links;
        PaymentSource = paymentSource;
        Intent = intent;
        Payer = payer;
        Status = status;
        CreateTime = createTime;
        UpdateTime = updateTime;
    }
}