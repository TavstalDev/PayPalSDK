using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Invoices;

/// <summary>
/// The payment term for an invoice.
/// </summary>
/// <remarks>Possible values: DUE_ON_RECEIPT, DUE_ON_DATE_SPECIFIED, NET_10, NET_15, NET_30, NET_45, NET_60, NET_90, NO_DUE_DATE</remarks>
[JsonConverter(typeof(JsonStringEnumConverter<EInvoicePaymentTerm>))]
public enum EInvoicePaymentTerm
{
    /// <summary>
    /// Payment due upon receipt.
    /// </summary>
    DUE_ON_RECEIPT = 0,
    /// <summary>
    /// Payment due on a specified date.
    /// </summary>
    DUE_ON_DATE_SPECIFIED = 1,
    /// <summary>
    /// Net 10 days payment term.
    /// </summary>
    NET_10 = 2,
    /// <summary>
    /// Net 15 days payment term.
    /// </summary>
    NET_15 = 3,
    /// <summary>
    /// Net 30 days payment term.
    /// </summary>
    NET_30 = 4,
    /// <summary>
    /// Net 45 days payment term.
    /// </summary>
    NET_45 = 5,
    /// <summary>
    /// Net 60 days payment term.
    /// </summary>
    NET_60 = 6,
    /// <summary>
    /// Net 90 days payment term.
    /// </summary>
    NET_90 = 7,
    /// <summary>
    /// No due date.
    /// </summary>
    NO_DUE_DATE = 8
}
