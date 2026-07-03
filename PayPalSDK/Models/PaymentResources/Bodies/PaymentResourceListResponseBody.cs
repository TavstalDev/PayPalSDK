using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.PaymentResources.Bodies;

/// <summary>
/// Represents a paginated response containing payment resources.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class PaymentResourceListResponseBody
{
   /// <summary>
   /// Gets or sets the collection of payment resources returned by the API.
   /// </summary>
   [FluentMember(0)]
   [FluentSkippable]
   [JsonPropertyName("resources")]
   public List<PaymentResourceBody>? Resources { get; set;  }
   
   /// <summary>
   /// Gets or sets the total number of available payment resources.
   /// </summary>
   [FluentMember(1)]
   [FluentSkippable]
   [JsonPropertyName("total_items")]
   public int TotalItems { get; set; }
   
   /// <summary>
   /// Gets or sets the total number of result pages.
   /// </summary>
   [FluentMember(2)]
   [FluentSkippable]
   [JsonPropertyName("total_pages")]
   public int TotalPages { get; set; }
   
   /// <summary>
   /// Gets or sets the HATEOAS links related to the paginated resource list.
   /// </summary>
   [FluentMember(3)]
   [FluentSkippable]
   [JsonPropertyName("links")]
   public List<Link>? Links { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(4, "Build")]
    public void Build() { }
}