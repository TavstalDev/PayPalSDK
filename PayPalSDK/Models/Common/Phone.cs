using System.Runtime.Serialization;
using Tavstal.PayPalSDK.Models.Common.Addressing;

namespace Tavstal.PayPalSDK.Models.Common;

/// <summary>
/// Represents a phone object in the PayPal SDK.
/// </summary>
[DataContract]
public class Phone
{
    /// <summary>
    /// Gets or sets the type of the phone.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the type of phone (e.g., mobile, home, work).
    /// </remarks>
    [DataMember(Name = "phone_type", EmitDefaultValue = false)]
    public string PhoneType { get; set; }

    /// <summary>
    /// Gets or sets the phone number details.
    /// </summary>
    /// <remarks>
    /// This field is required and represents the phone number associated with the phone object.
    /// </remarks>
    [DataMember(Name = "phone_number", EmitDefaultValue = false)]
    public required PhoneNumber PhoneNumber { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Phone"/> class.
    /// </summary>
    /// <param name="phoneType">The type of the phone.</param>
    /// <param name="phoneNumber">The phone number details.</param>
    public Phone(string phoneType, PhoneNumber phoneNumber)
    {
        PhoneType = phoneType;
        PhoneNumber = phoneNumber;
    }
}