using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Invoices;

/// <summary>
/// The type of invoice transaction.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EInvoiceTransactionType>))]
public enum EInvoiceTransactionType
{
    /// <summary>PayPal payment method.</summary>
    PAYPAL = 0,
    /// <summary>External refund or transaction.</summary>
    EXTERNAL = 1
}
