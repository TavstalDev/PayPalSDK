using System.Runtime.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Orders;

/// <summary>
/// Represents supplementary data in the PayPal SDK.
/// </summary>
[DataContract]
public class SupplementaryData
{
    /// <summary>
    /// Gets or sets the card information associated with the supplementary data.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents details about the card used in the transaction.
    /// </remarks>
    [DataMember(Name = "card", EmitDefaultValue = false)]
    public SupplementaryCard SupplementaryCard { get; set; }

    /// <summary>
    /// Gets or sets the risk information associated with the supplementary data.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents risk assessment details for the transaction.
    /// </remarks>
    [DataMember(Name = "risk", EmitDefaultValue = false)]
    public Risk Risk { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="SupplementaryData"/> class.
    /// </summary>
    /// <param name="supplementaryCard">The card information associated with the supplementary data.</param>
    /// <param name="risk">The risk information associated with the supplementary data.</param>
    public SupplementaryData(SupplementaryCard supplementaryCard, Risk risk)
    {
        SupplementaryCard = supplementaryCard;
        Risk = risk;
    }
}