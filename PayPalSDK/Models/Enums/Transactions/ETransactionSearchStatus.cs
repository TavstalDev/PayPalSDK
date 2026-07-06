using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Transactions;

/// <summary>
/// Represents the TransactionSearchStatus type.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<ETransactionSearchStatus>))]
public enum ETransactionSearchStatus
{
    /// <summary>
    /// PayPal or merchant rules denied the transaction.
    /// </summary>
    D = 0,
    /// <summary>
    /// The transaction is pending.
    /// The transaction was created but waits for another payment process to complete, such as an ACH transaction, before the status changes to S.
    /// </summary>
    P = 1,
    /// <summary>
    /// The transaction successfully completed without a denial and after any pending statuses.
    /// </summary>
    S = 2,
    /// <summary>
    /// A successful transaction was reversed and funds were refunded to the original sender.
    /// </summary>
    V = 3
}
