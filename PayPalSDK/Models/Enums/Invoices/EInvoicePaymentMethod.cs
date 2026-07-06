using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Invoices;

/// <summary>
/// The payment method for an invoice.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EInvoicePaymentMethod>))]
public enum EInvoicePaymentMethod
{
    /// <summary>
    /// Bank transfer payment method.
    /// </summary>
    BANK_TRANSFER = 0,
    /// <summary>
    /// Cash payment method.
    /// </summary>
    CASH = 1,
    /// <summary>
    /// Check payment method.
    /// </summary>
    CHECK = 2,
    /// <summary>
    /// Credit card payment method.
    /// </summary>
    CREDIT_CARD = 3,
    /// <summary>
    /// Debit card payment method.
    /// </summary>
    DEBIT_CARD = 4,
    /// <summary>
    /// PayPal payment method.
    /// </summary>
    PAYPAL = 5,
    /// <summary>
    /// Wire transfer payment method.
    /// </summary>
    WIRE_TRANSFER = 6,
    /// <summary>
    /// Other payment method or reason.
    /// </summary>
    OTHER = 7
}
