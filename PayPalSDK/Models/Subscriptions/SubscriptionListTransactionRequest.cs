using Tavstal.PayPalSDK.Http;

namespace Tavstal.PayPalSDK.Models.Subscriptions;

public class SubscriptionListTransactionRequest : HttpRequestBase<>
{
    public SubscriptionListTransactionRequest(string id, 
        string startTime, string endTime)
        : base(HttpMethod.Get, $"/v1/billing/subscriptions/{id}/transactions?start_time={startTime}&end_time={endTime}")
    {
        // No content is needed for this request
    }
}