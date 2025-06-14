namespace Tavstal.PayPalSDK.Constants.Experience;

/// <summary>
/// Provides constants for shipping preferences in the PayPal SDK.
/// </summary>
public class ShippingPreference
{
    /// <summary>
    /// Represents a preference to retrieve the shipping address from the file.
    /// </summary>
    public const string GET_FROM_FILE = "GET_FROM_FILE";

    /// <summary>
    /// Represents a preference where no shipping is required.
    /// </summary>
    public const string NO_SHIPPING = "NO_SHIPPING";

    /// <summary>
    /// Represents a preference to use the provided shipping address.
    /// </summary>
    public const string SET_PROVIDED_ADDRESS = "SET_PROVIDED_ADDRESS";
}