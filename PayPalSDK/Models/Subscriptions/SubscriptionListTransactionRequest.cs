using System.ComponentModel.DataAnnotations;
using Tavstal.PayPalSDK.Http;

namespace Tavstal.PayPalSDK.Models.Subscriptions;

/// <summary>
/// Represents a request to list subscription transactions.
/// </summary>
public class SubscriptionListTransactionRequest : HttpRequestBase<SubscriptionListTransactionRequestBody>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SubscriptionListTransactionRequest"/> class.
    /// </summary>
    /// <param name="id">The unique identifier of the subscription.</param>
    /// <param name="startTime">The start time for the transaction list in ISO 8601 format.</param>
    /// <param name="endTime">The end time for the transaction list in ISO 8601 format.</param>
    public SubscriptionListTransactionRequest(string id,
        [StringLength(64), RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
        string startTime,
        [StringLength(64), RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
        string endTime
    )
        : base(HttpMethod.Get, $"/v1/billing/subscriptions/{id}/transactions?start_time={startTime}&end_time={endTime}")
    {
        // No content is needed for this request
    }
}