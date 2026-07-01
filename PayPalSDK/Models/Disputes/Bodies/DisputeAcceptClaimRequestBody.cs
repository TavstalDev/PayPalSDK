using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Addressing;
using Tavstal.PayPalSDK.Models.Common.Disputes;
using Tavstal.PayPalSDK.Models.Common.Payments;

namespace Tavstal.PayPalSDK.Models.Disputes.Bodies;

/// <summary>
/// Represents the request payload used to accept a claim in a dispute.
/// </summary>
public class DisputeAcceptClaimRequestBody
{
    /// <summary>
    /// Gets or sets the note describing the acceptance decision.
    /// </summary>
    [JsonPropertyName("note")]
    [StringLength(2000)]
    public required string Note { get; set; }
    
    /// <summary>
    /// Gets or sets the reason code for accepting the claim.
    /// </summary>
    [JsonPropertyName("accept_claim_reason")]
    [StringLength(255)]
    [RegularExpression("^[0-9A-Z_]+$")]
    public string? AcceptClaimReason { get; set; }
    
    /// <summary>
    /// Gets or sets the merchant invoice identifier associated with the disputed transaction.
    /// </summary>
    [JsonPropertyName("invoice_id")]
    [StringLength(127)]
    public string? InvoiceId { get; set; }
    
    /// <summary>
    /// Gets or sets shipment details for returned items, when applicable.
    /// </summary>
    [JsonPropertyName("return_shipment_info")]
    public List<ShipmentInfo>? ReturnShipmentInfo { get; set; }
    
    /// <summary>
    /// Gets or sets the return shipping address for the disputed item.
    /// </summary>
    [JsonPropertyName("return_shipping_address")]
    public Address? ReturnShippingAddress { get; set; }
    
    /// <summary>
    /// Gets or sets additional return shipping information, such as tracking or carrier details.
    /// </summary>
    [JsonPropertyName("return_shipping_address_info")]
    public ReturnShippingInfo? ReturnShippingAddressInfo { get; set; }
    
    /// <summary>
    /// Gets or sets the refund amount offered when accepting the claim.
    /// </summary>
    [JsonPropertyName("refund_amount")]
    public Money? RefundAmount { get; set; }
    
    /// <summary>
    /// Gets or sets the claim acceptance type defined by the disputes API.
    /// </summary>
    [JsonPropertyName("accept_claim_type")]
    [StringLength(255)]
    [RegularExpression("^[0-9A-Z_]+$")]
    public string? AcceptClaimType { get; set; }
}