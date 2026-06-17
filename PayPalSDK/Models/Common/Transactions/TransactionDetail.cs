using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Transactions;

[DataContract]
public class TransactionDetail
{
    [JsonPropertyName("transaction_info")]
    public TransactionInfo? TransactionInfo { get; set; }

    [JsonPropertyName("payer_info")]
    public TransactionPayerInfo? PayerInfo { get; set; }

    [JsonPropertyName("shipping_info")]
    public TransactionShippingInfo? ShippingInfo { get; set; }

    [JsonPropertyName("cart_info")]
    public TransactionCartInfo? CartInfo { get; set; }

    [JsonPropertyName("store_info")]
    public TransactionStoreInfo? StoreInfo { get; set; }
    
    [JsonPropertyName("auction_info")]
    public TransactionAuctionInfo? AuctionInfo { get; set; }
    
    [JsonPropertyName("incentive_info")]
    public TransactionIncentiveInfo? IncentiveInfo { get; set; }
}