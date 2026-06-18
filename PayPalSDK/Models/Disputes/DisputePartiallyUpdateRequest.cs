using System.ComponentModel.DataAnnotations;
using System.Net.Http.Json;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Serialization;

namespace Tavstal.PayPalSDK.Models.Disputes;

public class DisputePartiallyUpdateRequest : HttpRequestBase
{
    public DisputePartiallyUpdateRequest([StringLength(255)] string id, List<UpdateOperation> body)
        : base(HttpMethod.Patch,  $"/v1/customer/disputes/{id}")
    {
        // Sets the content of the HTTP request to the serialized JSON representation of the order creation details.
        Content = JsonContent.Create(body, PayPalSDKJsonContext.Default.ListUpdateOperation);
    }
}