using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Disputes.Details.Extensions;
using Tavstal.PayPalSDK.Utils;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details;

/// <summary>
/// Represents supplemental dispute metadata, including contact history
/// and extension-specific dispute properties.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class DisputeExtensions
{
    /// <summary>
    /// Gets or sets a value indicating whether the merchant was contacted by the buyer.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("merchant_contacted")]
    public bool MerchantContacted { get; set; }
    
    /// <summary>
    /// Gets or sets the channel used by the buyer to contact the merchant.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("buyer_contacted_channel")]
    [StringLength(255)]
    public string? BuyerContactedChannel { get; set; }
    
    /// <summary>
    /// Gets or sets the outcome of the buyer contacting the merchant.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("merchant_contacted_outcome")]
    [StringLength(255)]
    [RegularExpression("^[0-9A-Z_]+$")]
    public string? MerchantContactedOutcome { get; set; }
    
    /// <summary>
    /// Gets or sets the timestamp when the merchant was contacted, in ISO 8601 / RFC 3339 format.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("merchant_contacted_time")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? MerchantContactedTime { get; set; }
    
    /// <summary>
    /// Gets or sets the contact mode used to reach the merchant.
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("merchant_contacted_mode")]
    [StringLength(255)]
    [RegularExpression("^[0-9A-Z_]+$")]
    public string? MerchantContactedMode { get; set; }
    
    /// <summary>
    /// Gets or sets the timestamp when the buyer initiated contact, in ISO 8601 / RFC 3339 format.
    /// </summary>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("buyer_contacted_time")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? BuyerContactedTime { get; set; }
    
    /// <summary>
    /// Gets or sets billing-specific extension details for the dispute.
    /// </summary>
    [FluentMember(6)]
    [FluentSkippable]
    [JsonPropertyName("billing_dispute_properties")]
    public BillingDisputeProperties? BillingDisputeProperties { get; set; }
    
    /// <summary>
    /// Gets or sets merchandise-specific extension details for the dispute.
    /// </summary>
    [FluentMember(7)]
    [FluentSkippable]
    [JsonPropertyName("merchandize_dispute_properties")]
    public MerchandizeDisputeProperties? MerchandizeDisputeProperties { get; set; }
    
    /// <summary>
    /// Gets or sets the source from which the dispute was reported.
    /// </summary>
    [FluentMember(8)]
    [FluentSkippable]
    [JsonPropertyName("reported_source")]
    [StringLength(255)]
    [RegularExpression("^[A-Z0-9_]+$")]
    public string? ReportedSource { get; set; }
    
    /// <summary>
    /// Gets the <see cref="MerchantContactedTime"/> value parsed as a <see cref="DateTime"/>, if valid.
    /// </summary>
    public DateTime? MerchantContactedTimeAsDateTime => DateTimeHelper.FromISO8601(MerchantContactedTime);
    
    /// <summary>
    /// Gets the <see cref="BuyerContactedTime"/> value parsed as a <see cref="DateTime"/>, if valid.
    /// </summary>
    public DateTime? BuyerContactedTimeAsDateTime => DateTimeHelper.FromISO8601(BuyerContactedTime);

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(9, "Build")]
    public void Build() { }
}