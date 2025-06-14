using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Payments.Sources.Card;

/// <summary>
/// Represents a vault configuration in the PayPal SDK.
/// </summary>
[DataContract]
public class Vault
{
    /// <summary>
    /// Gets or sets the value indicating whether to store the payment source in the vault.
    /// </summary>
    /// <remarks>
    /// This field is optional, has a maximum length of 255 characters, and must match the regular expression ^[0-9A-Z_]+$.
    /// </remarks>
    [DataMember(Name = "store_in_vault", EmitDefaultValue = false)]
    [StringLength(255)]
    [RegularExpression("^[0-9A-Z_]+$")]
    public string StoreInVault { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Vault"/> class.
    /// </summary>
    /// <param name="storeInVault">The value indicating whether to store the payment source in the vault.</param>
    public Vault(string storeInVault)
    {
        StoreInVault = storeInVault;
    }
}