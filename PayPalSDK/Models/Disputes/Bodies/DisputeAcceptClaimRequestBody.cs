using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Addressing;
using Tavstal.PayPalSDK.Models.Common.Disputes;
using Tavstal.PayPalSDK.Models.Common.Payments;
using M31.FluentApi.Attributes;
using Tavstal.PayPalSDK.Models.Enums.Disputes;

namespace Tavstal.PayPalSDK.Models.Disputes.Bodies;

/// <summary>
/// Represents the request payload used to accept a claim in a dispute.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class DisputeAcceptClaimRequestBody
{
    /// <summary>
    /// Gets or sets the note describing the acceptance decision.
    /// </summary>
    [FluentMember(0)]
    [JsonPropertyName("note")]
    [StringLength(2000)]
    [Required]
    public string? Note { get; set; }
    
    /// <summary>
    /// Gets or sets the reason code for accepting the claim.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("accept_claim_reason")]
    public EDisputeAcceptClaimReason? AcceptClaimReason { get; set; }
    
    /// <summary>
    /// Gets or sets the merchant invoice identifier associated with the disputed transaction.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("invoice_id")]
    [StringLength(127)]
    public string? InvoiceId { get; set; }
    
    /// <summary>
    /// Gets or sets shipment details for returned items, when applicable.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("return_shipment_info")]
    public List<ShipmentInfo>? ReturnShipmentInfo { get; set; }
    
    /// <summary>
    /// Gets or sets the return shipping address for the disputed item.
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("return_shipping_address")]
    public Address? ReturnShippingAddress { get; set; }
    
    /// <summary>
    /// Gets or sets additional return shipping information, such as tracking or carrier details.
    /// </summary>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("return_shipping_address_info")]
    public ReturnShippingInfo? ReturnShippingAddressInfo { get; set; }
    
    /// <summary>
    /// Gets or sets the refund amount offered when accepting the claim.
    /// </summary>
    [FluentMember(6)]
    [FluentSkippable]
    [JsonPropertyName("refund_amount")]
    public Money? RefundAmount { get; set; }
    
    /// <summary>
    /// Gets or sets the claim acceptance type defined by the disputes API.
    /// </summary>
    [FluentMember(7)]
    [FluentSkippable]
    [JsonPropertyName("accept_claim_type")]
    [StringLength(255)]
    [RegularExpression("^[0-9A-Z_]+$")]
    public string? AcceptClaimType { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(8, "Build")]
    public void Build() { }
}