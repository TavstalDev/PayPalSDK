using System.Text;

namespace Tavstal.PayPalSDK.Http;

/// <summary>
/// Represents the user agent information for the Tavstal PayPal SDK.
/// </summary>
public static class UserAgent
{
    /// <summary>
    /// Gets the bitness of the operating system (32 or 64-bit).
    /// </summary>
    private static int OperatingSystemBitness => Environment.Is64BitOperatingSystem ? 64 : 32;

    /// <summary>
    /// Gets the name and version of the operating system.
    /// </summary>
    private static string OperatingSystemName => Environment.OSVersion.ToString();

    /// <summary>
    /// Gets the version of the .NET CLR.
    /// </summary>
    private static string DotNetClrVersion => Environment.Version.ToString().Trim();

    /// <summary>
    /// Gets the version of the .NET runtime.
    /// </summary>
    private static string DotNetVersion => Environment.Version.ToString();

    /// <summary>
    /// Generates the user agent header string for the SDK.
    /// </summary>
    /// <param name="applicationName">An optional application name to include in the user agent string. Defaults to "Tavstal/PayPalSDK".</param>
    /// <returns>A formatted string containing user agent information.</returns>
    public static string GetUserAgentHeader(string applicationName = "Tavstal/PayPalSDK")
    {
        StringBuilder strngBuilder = new StringBuilder(applicationName);
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