## Client Setup

Before you can use the SDK, you need to create a client. You will need your **Client ID** and **Client Secret** from the [PayPal Developer Dashboard](https://developer.paypal.com/dashboard/).

There are two environments to choose from:

- **Sandbox** — for testing. No real money is used.
- **Live** — for production. Use this when your app is ready for real users.

### Sandbox (Testing)

```csharp
var client = new PayPalHttpClient(
    new SandboxEnvironment("your-client-id-here", "your-client-secret-here")
);
```

### Live (Production)

```csharp
var client = new PayPalHttpClient(
    new LiveEnvironment("your-client-id-here", "your-client-secret-here")
);
```

> **Note:** Never put your Client ID or Client Secret directly in your source code.  
> Use environment variables or a secrets manager instead.

```csharp
var client = new PayPalHttpClient(
    new LiveEnvironment(
        Environment.GetEnvironmentVariable("PAYPAL_CLIENT_ID"),
        Environment.GetEnvironmentVariable("PAYPAL_CLIENT_SECRET")
    )
);
```