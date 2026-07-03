using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Subscriptions.Bodies;

/// <summary>
/// Represents the request body for listing subscription transactions.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class SubscriptionListTransactionRequestBody
{
    /// <summary>
    /// Gets or sets the list of transactions associated with the subscription.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("transactions")]
    public List<Transaction>? Transactions { get; set; }

    /// <summary>
    /// Gets or sets the total number of items in the transaction list.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("total_items")]
    public int TotalItems { get; set; }

    /// <summary>
    /// Gets or sets the total number of pages in the transaction list.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("total_pages")]
    public int TotalPages { get; set; }

    /// <summary>
    /// Gets or sets the list of links related to the subscription transactions.
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