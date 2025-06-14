using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Payments.Sources.Card;


/// <summary>
/// Represents a verification object in the PayPal SDK.
/// </summary>
[DataContract]
public class Verification
{
    /// <summary>
    /// Gets or sets the card verification method.
    /// </summary>
    /// <remarks>
    /// This field is optional, has a maximum length of 255 characters, and should correspond to one of the constants defined in <see cref="Tavstal.PayPalSDK.Constants.CardVerificationMethods"/>.
    /// </remarks>
    [DataMember(Name = "amount", EmitDefaultValue = false)]
    [StringLength(255)]
    public string Method { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Verification"/> class.
    /// </summary>
    /// <param name="method">The card verification method.</param>
    public Verification(string method)
    {
        Method = method;
    }
}