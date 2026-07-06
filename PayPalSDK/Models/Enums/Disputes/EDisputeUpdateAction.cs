using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Disputes;

/// <summary>
/// The action type for updating a dispute.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EDisputeUpdateAction>))]
public enum EDisputeUpdateAction
{
    /// <summary>Evidence submitted by the buyer.</summary>
    BUYER_EVIDENCE = 0,
    /// <summary>Evidence submitted by the seller.</summary>
    SELLER_EVIDENCE = 1
}
