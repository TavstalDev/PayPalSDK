using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Addressing;
using Tavstal.PayPalSDK.Models.Common.Payments;

namespace Tavstal.PayPalSDK.Models.Disputes.Bodies;

/// <summary>
/// Represents the request payload used to submit an offer for a dispute.
/// </summary>
public class DisputeMakeOfferRequestBody
{
    /// <summary>
    /// Gets or sets the note describing the offer details or rationale.
    /// </summary>
    [JsonPropertyName("note")]
    [StringLength(2000)]
    public required string Note { get; set; }
    
    /// <summary>
    /// Gets or sets the merchant invoice identifier associated with the disputed transaction.
    /// </summary>
    [JsonPropertyName("invoice_id")]
    [StringLength(127)]
    public string? InvoiceId { get; set; }
    
    /// <summary>
    /// Gets or sets the monetary amount being offered to resolve the dispute.
    /// </summary>
    [JsonPropertyName("offer_amount")]
    public Money? OfferAmount { get; set; }
    
    /// <summary>
    /// Gets or sets the return shipping address for returning disputed items, when applicable.
    /// </summary>
    [JsonPropertyName("return_shipping_address")]
    public Address? ReturnShippingAddress { get; set; }
    
    /// <summary>
    /// Gets or sets additional return shipping information, such as carrier or tracking details.
    /// </summary>
    [JsonPropertyName("return_shipping_address_info")]
    public ReturnShippingInfo? ReturnShippingAddressInfo { get; set; }
    
    /// <summary>
    /// Gets or sets the offer type identifier defined by the disputes API.
    /// </summary>
    [JsonPropertyName("offer_type")]
    [StringLength(255)]
    [RegularExpression("^[0-9A-Z_]+$")]
    public required string OfferType { get; set; }
}