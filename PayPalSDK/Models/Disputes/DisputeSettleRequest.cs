using System.ComponentModel.DataAnnotations;
using System.Net.Http.Json;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Models.Disputes.Bodies;
using Tavstal.PayPalSDK.Serialization;

namespace Tavstal.PayPalSDK.Models.Disputes;

/// <summary>
/// Represents a request to adjudicate and settle a customer dispute.
/// </summary>
[Obsolete("This endpoint only works in sandbox environment.")]
public class DisputeSettleRequest : HttpRequestBase<LinksResponseBody>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DisputeSettleRequest"/> class.
    /// </summary>
    /// <param name="id">
    /// The unique identifier of the dispute to settle. Maximum length is 255 characters.
    /// </param>
    /// <param name="body">
    /// The request payload containing adjudication details for the dispute settlement.
    /// </param>
    public DisputeSettleRequest([StringLength(255)] string id, DisputeSettleRequestBody body)
        : base(HttpMethod.Post,  $"/v1/customer/disputes/{id}/adjudicate")
    {
        // Sets the content of the HTTP request to the serialized JSON representation of the order creation details.
        Content = JsonContent.Create(body, PayPalSDKJsonContext.Default.DisputeSettleRequestBody);
    }
}