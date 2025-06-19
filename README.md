# PayPalSDK

A C# SDK for interacting with the PayPal API, designed to simplify integration and provide a clear, type-safe interface for common PayPal operations.

## Features

- Create, complete, retrieve, and refund PayPal orders
- Strongly-typed models for PayPal API requests and responses
- Async/await support for all operations
- Sandbox and live environment support
- Extensible and testable architecture

## Getting Started

### Prerequisites

- .NET 9.0 or later
- A PayPal developer account ([Sign up here](https://developer.paypal.com/))
- PayPal REST API credentials (Client ID and Secret)
- Knowledge about PayPal REST API

### Installation

Clone the repository:

```bash
git clone https://github.com/TavstalDev/PayPalSDK.git
cd PayPalSDK
```

### Configuration

To run the test suite in `PayPalSDK.Tests`, rename the `empty_secrets.json` file to `secrets.json`, then populate it with your PayPal API credentials:

```json
{
  "Currency": "EUR",
  "ClientId": "your-client-id-here",
  "ClientSecret": "your-client-secret-here"
}
```

Make sure the credentials are valid for the PayPal environment you're testing against (Sandbox or Live).

---

### Examples

This SDK includes an interactive console application for testing PayPal functionality:

- Located in: `PayPalSDK.Examples/Program.cs`
- Run with:  
  ```bash
  dotnet run --project PayPalSDK.Examples
  ```

You can choose from the following examples in the menu:

| Example                 | Description                                |
|-------------------------|--------------------------------------------|
| `CreateOrderExample`    | Demonstrates creating a new PayPal order.  |
| `CompleteOrderExample`  | Captures and completes an existing order.  |
| `GetOrderExample`       | Fetches the details of a specific order.   |
| `RefundOrderExample`    | Demonstrates refunding a captured order.   |

> 🧭 The example runner does not require any HTTP listener or web server — it works purely via console interaction using PayPal's REST APIs.

To explore more, check out the code in the [`PayPalSDK.Examples`](./PayPalSDK.Examples) directory.


## Resources

- [PayPal Orders API Reference](https://developer.paypal.com/docs/api/orders/v2/)
- [PayPal Developer Dashboard](https://developer.paypal.com/developer/applications)


## Roadmap

The following roadmap outlines prioritized features to implement in the PayPalSDK, based on commonly used PayPal APIs.

### Completed
- [x] Authentication (Access Token Retrieval)
- [x] Orders API (Create, Capture, Get, Authorize)

#### Payments
- [x] Support for Capturing Authorized Payments
- [x] Refunds (Full/Partial)
- [x] Get Payment Details

#### Subscriptions
- [x] Create and Manage Product Plans
- [x] Create and Manage Subscriptions
- [x] Subscription Cancellation / Suspension
- [x] Get Subscription Details

#### Invoicing
- [x] Create & Send Invoices
- [x] Get Invoice Status
- [x] Cancel / Remind Invoices

#### Webhooks
- [x] Register Webhooks
- [x] Handle Common Webhook Events (Order Completed, Subscription Renewed, Payment Refunded)

---

### In Progress / Next Up

### Testing
- [ ] Expand Test Coverage to Subscriptions and Payments
- [ ] Add Mock Server / Sandbox Utilities
- [ ] Add CI pipeline (e.g., GitHub Actions)

---

## Disclaimer

This SDK is not affiliated with or endorsed by PayPal, Inc. Use at your own risk.
