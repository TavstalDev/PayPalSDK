using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Transactions;

/// <summary>
/// Represents a full transaction detail payload, composed of multiple
/// domain sections such as transaction core data, payer, shipping,
/// cart, store, auction, and incentive information.
/// </summary>
public class TransactionDetail
{
    /// <summary>
    /// Gets or sets the core transaction information
    /// (amounts, status, identifiers, timestamps, and related metadata).
    /// </summary>
    [JsonPropertyName("transaction_info")]
    public TransactionInfo? TransactionInfo { get; set; }

    /// <summary>
    /// Gets or sets information about the payer associated with the transaction.
    /// </summary>
    [JsonPropertyName("payer_info")]
    public TransactionPayerInfo? PayerInfo { get; set; }

    /// <summary>
    /// Gets or sets shipping-related details for the transaction, when applicable.
    /// </summary>
    [JsonPropertyName("shipping_info")]
    public TransactionShippingInfo? ShippingInfo { get; set; }

    /// <summary>
    /// Gets or sets cart-level details such as line items, tax mode,
    /// and invoice references.
    /// </summary>
    [JsonPropertyName("cart_info")]
    public TransactionCartInfo? CartInfo { get; set; }

    /// <summary>
    /// Gets or sets merchant store details associated with the transaction.
    /// </summary>
    [JsonPropertyName("store_info")]
    public TransactionStoreInfo? StoreInfo { get; set; }
    
    /// <summary>
    /// Gets or sets auction-specific metadata when the transaction originates
    /// from or is linked to an auction flow.
    /// </summary>
    [JsonPropertyName("auction_info")]
    public TransactionAuctionInfo? AuctionInfo { get; set; }
    
    /// <summary>
    /// Gets or sets incentive-related information (for example promotions,
    /// discounts, or reward program data) applied to the transaction.
    /// </summary>
    [JsonPropertyName("incentive_info")]
    public TransactionIncentiveInfo? IncentiveInfo { get; set; }
}