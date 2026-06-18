using System.ComponentModel.DataAnnotations;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Common.Disputes;

namespace Tavstal.PayPalSDK.Models.Disputes;

public class DisputeShowDetailsRequest : HttpRequestBase<DisputeDetails>
{
    public DisputeShowDetailsRequest([StringLength(255)] string id)
        : base(HttpMethod.Get,  $"/v1/customer/disputes/{id}")
    {
    }
}