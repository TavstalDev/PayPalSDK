# Security Policy

## Scope

PayPalSDK is a simple wrapper around the [PayPal REST v2 API](https://developer.paypal.com/docs/api/overview/). 
The SDK itself does not save, send, or process your payment details directly. 
Instead, it just creates and sends requests to PayPal's servers using your credentials.

Because of this, the safety of your actual payment operations depends on PayPal, not this SDK. 
If you think you found a security flaw in the PayPal API or PayPal's servers, please report it through [PayPal's official Bug Bounty program](https://www.paypal.com/us/webapps/mpp/security-tools/reporting-security-issues).

---

## Keeping Your Credentials Safe

The biggest security risk when using this SDK is accidentally sharing your PayPal API credentials. Please follow these rules:

- **Never** write your `ClientId` or `ClientSecret` directly into your source code.
- **Never** commit `secrets.json` or any other file with passwords to version control (like GitHub).
- Use environment variables, a secrets manager, or `dotnet user-secrets` while developing.
- Change your credentials immediately if you think someone else saw them.
- Always use Sandbox credentials for development and testing—**never** use Live credentials in a testing environment.

---

## Reporting a Security Issue in This SDK

If you find something in the SDK's own code that looks like a security risk (for example, if the library logs your passwords or handles API answers incorrectly), 
please report it using the [GitHub private vulnerability reporting](https://github.com/TavstalDev/PayPalSDK/security/advisories/new) feature instead of opening a public issue.

We will look at every report and reply as fast as we can.

---

## Disclaimer

This SDK is not connected to, approved by, or supported by PayPal, Inc. Use it at your own risk. 
Please read the `LICENSE` file to see the full terms.