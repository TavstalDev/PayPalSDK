using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Invoices;

/// <summary>
/// Represents display and visibility settings for invoice sections,
/// grouped by item, additional information, policy/agreement, and details.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class InvoiceSettings
{
    /// <summary>
    /// Gets or sets field settings that control how invoice item fields are displayed.
    /// </summary>
    /// <remarks>
    /// Serialized as <c>invoice_item_settings</c> in the PayPal invoice payload.
    /// </remarks>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("invoice_item_settings")]
    public List<InvoiceFieldSetting>? InvoiceItemSettings { get; set; }

    /// <summary>
    /// Gets or sets field settings for additional invoice information sections.
    /// </summary>
    /// <remarks>
    /// Serialized as <c>invoice_additional_settings</c> in the PayPal invoice payload.
    /// </remarks>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("invoice_additional_settings")]
    public List<InvoiceFieldSetting>? InvoiceAdditionalSettings { get; set; }

    /// <summary>
    /// Gets or sets field settings for policy and agreement-related invoice sections.
    /// </summary>
    /// <remarks>
    /// Serialized as <c>invoice_policy_and_agreement_settings</c> in the PayPal invoice payload.
    /// </remarks>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("invoice_policy_and_agreement_settings")]
    public List<InvoiceFieldSetting>? InvoicePolicyAndAgreementSettings { get; set; }

    /// <summary>
    /// Gets or sets field settings for core invoice detail sections.
    /// </summary>
    /// <remarks>
    /// Serialized as <c>invoice_details_settings</c> in the PayPal invoice payload.
    /// </remarks>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("invoice_details_settings")]
    public List<InvoiceFieldSetting>? InvoiceDetailsSettings { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(4, "Build")]
    public void Build() { }
}