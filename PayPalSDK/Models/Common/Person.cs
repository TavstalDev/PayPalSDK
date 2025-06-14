using System.Runtime.Serialization;

namespace Tavstal.PayPalSDK.Models.Common;

/// <summary>
/// Represents a person with a full name.
/// </summary>
[DataContract]
public class Person
{
    /// <summary>
    /// Gets or sets the full name of the person.
    /// </summary>
    /// <remarks>
    /// This field is optional and will not be emitted if its value is null or default.
    /// </remarks>
    [DataMember(Name = "full_name", EmitDefaultValue = false)]
    public string FullName { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Person"/> class.
    /// </summary>
    /// <param name="fullName">The full name of the person.</param>
    public Person(string fullName)
    {
        FullName = fullName;
    }
}