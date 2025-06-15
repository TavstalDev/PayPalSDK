using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.User;

/// <summary>
/// Represents a name object in the PayPal SDK.
/// </summary>
[DataContract]
public class Name
{
    /// <summary>
    /// Gets or sets the given name.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 140 characters.
    /// </remarks>
    [DataMember(Name = "given_name", EmitDefaultValue = false)]
    [StringLength(140)]
    public string GivenName { get; set; }

    /// <summary>
    /// Gets or sets the surname.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 140 characters.
    /// </remarks>
    [DataMember(Name = "surname", EmitDefaultValue = false)]
    [StringLength(140)]
    public string Surname { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Name"/> class.
    /// </summary>
    /// <param name="givenName">The given name.</param>
    /// <param name="surname">The surname.</param>
    public Name(string givenName, string surname)
    {
        GivenName = givenName;
        Surname = surname;
    }
}