using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common;

namespace Tavstal.PayPalSDK.Models.PaymentResources.Bodies;

/// <summary>
/// Represents a paginated response containing payment resources.
/// </summary>
public class PaymentResourceListResponseBody
{
   /// <summary>
   /// Gets or sets the collection of payment resources returned by the API.
   /// </summary>
   [JsonPropertyName("resources")]
   public List<PaymentResourceBody>? Resources { get; set;  }
   
   /// <summary>
   /// Gets or sets the total number of available payment resources.
   /// </summary>
   [JsonPropertyName("total_items")]
   public int TotalItems { get; set; }
   
   /// <summary>
   /// Gets or sets the total number of result pages.
   /// </summary>
   [JsonPropertyName("total_pages")]
   public int TotalPages { get; set; }
   
   /// <summary>
   /// Gets or sets the HATEOAS links related to the paginated resource list.
   /// </summary>
   [JsonPropertyName("links")]
   public List<Link>? Links { get; set; }
}