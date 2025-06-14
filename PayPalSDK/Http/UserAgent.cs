using System.Text;

namespace Tavstal.PayPalSDK.Http;

/// <summary>
/// Represents the user agent information for the Tavstal PayPal SDK.
/// </summary>
public abstract class UserAgent
{
    /// <summary>
    /// Gets the bitness of the operating system (32 or 64-bit).
    /// </summary>
    private static int OperatingSystemBitness => System.Environment.Is64BitOperatingSystem ? 64 : 32;

    /// <summary>
    /// Gets the name and version of the operating system.
    /// </summary>
    private static string OperatingSystemName => System.Environment.OSVersion.ToString();

    /// <summary>
    /// Gets the version of the .NET CLR.
    /// </summary>
    private static string DotNetClrVersion => System.Environment.Version.ToString().Trim();

    /// <summary>
    /// Gets the version of the .NET runtime.
    /// </summary>
    private static string DotNetVersion => System.Environment.Version.ToString();

    /// <summary>
    /// Generates the user agent header string for the SDK.
    /// </summary>
    /// <returns>A formatted string containing user agent information.</returns>
    public static string GetUserAgentHeader()
    {
        StringBuilder strngBuilder = new StringBuilder("Tavstal/PayPalSDK");
        strngBuilder.Append(" (");
        strngBuilder.Append("lang=DOTNET;");
        strngBuilder.Append("v=" + DotNetVersion + ";");
        strngBuilder.Append("clr=" + DotNetClrVersion + ";");
        strngBuilder.Append("bit=" + OperatingSystemBitness + ";");
        strngBuilder.Append("os=" + OperatingSystemName + ";");
        strngBuilder.Append(')');
        return strngBuilder.ToString();
    }
}