using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Plans;

/// <summary>
/// Represents the response containing a list of transactions for a subscription from the PayPal Billing API.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class SubscriptionListTransactionResponse
{
    /// <summary>
    /// Gets or sets the list of subscription transaction objects returned in this response.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("transactions")]
    public List<Transaction>? Transactions { get; set; }
    
    /// <summary>
    /// Gets or sets the hypermedia links associated with this subscription transaction list response.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("links")]
    public List<Link>? Links { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}