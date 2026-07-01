using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Plans;

/// <summary>
/// Represents the response containing a list of transactions for a subscription from the PayPal Billing API.
/// </summary>
public class SubscriptionListTransactionResponse
{
    /// <summary>
    /// Gets or sets the list of subscription transaction objects returned in this response.
    /// </summary>
    [JsonPropertyName("transactions")]
    public List<Transaction>? Transactions { get; set; }
    
    /// <summary>
    /// Gets or sets the hypermedia links associated with this subscription transaction list response.
    /// </summary>
    [JsonPropertyName("links")]
    public List<Link>? Links { get; set; }
}