using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Disputes;

/// <summary>
/// The source of supporting information in a dispute.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EDisputeSupportingSource>))]
public enum EDisputeSupportingSource
{
    /// <summary>Evidence submitted by the buyer.</summary>
    SUBMITTED_BY_BUYER = 0,
    /// <summary>Evidence submitted by the seller.</summary>
    SUBMITTED_BY_SELLER = 1,
    /// <summary>Evidence submitted by the partner.</summary>
    SUBMITTED_BY_PARTNER = 2
}
