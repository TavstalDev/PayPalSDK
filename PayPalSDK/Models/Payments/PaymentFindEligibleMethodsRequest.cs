using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Payments.Bodies;

namespace Tavstal.PayPalSDK.Models.Payments;

/// <summary>
/// Represents an HTTP request to retrieve the eligible payment methods for a given payment context.
/// </summary>
public class PaymentFindEligibleMethodsRequest : HttpRequestBase<AuthorizedPaymentBody>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PaymentFindEligibleMethodsRequest"/> class.
    /// </summary>
    /// <param name="body">The request payload describing the payment context for which eligible methods should be returned.</param>
    public PaymentFindEligibleMethodsRequest(PaymentFindEligibleMethodsRequestBody body)
        :
        base(HttpMethod.Post, $"/v2/payments/find-eligible-methods")
    {
        Content = JsonContent.Create(body, options: new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        });
    }
    
    /// <summary>
    /// Adds the PayPal Partner Attribution ID header to the request.
    /// </summary>
    /// <param name="paypalPartnerAttributionId">The PayPal Partner Attribution ID to be added.</param>
    /// <returns>The current instance of <see cref="PaymentFindEligibleMethodsRequest"/> for method chaining.</returns>
    public PaymentFindEligibleMethodsRequest PaypalPartnerAttributionId(string paypalPartnerAttributionId)
    {
        Headers.Add("PayPal-Partner-Attribution-Id", paypalPartnerAttributionId);
        return this;
    }
}