# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]
<details>
<summary>In development changes</summary>

</details>

## [1.0.0] - 2026-07-07

<details>
<summary>Initial public release</summary>

### Added

#### API Coverage
- **Orders (v2):** Full support | create, confirm, authorize, capture, show, update, and track orders (9/9 endpoints)
- **Payments (v2):** Full support | authorized payments, captures, refunds, and eligible methods (8/8 endpoints)
- **Payment Method Tokens (v3):** Full support | create, list, get, delete tokens (6/6 endpoints)
- **Subscriptions (v1):** Full support | create, activate, suspend, cancel, capture, update shipping, list transactions, and plan management (17/17 endpoints)
- **Disputes (v1):** Full support | list, show, update, accept, appeal, provide evidence, and settle (15/15 endpoints)
- **Catalog Products (v1):** Full support | create, list, get, update products (4/4 endpoints)
- **Currency Conversion (v2):** Full support | quote-exchange-rates (1/1 endpoint)
- **Shipment Tracking (v1):** Partial support | Add, update, and track shipments (4/5 endpoints)
- **Invoices (v2):** Partial support | Create, send, remind, cancel, search, and generate QR codes; manage templates (15/27 endpoints)
- **Webhooks (v1):** Partial support | Create, list, get, update, delete, and verify webhook signatures (6/16 endpoints)
- **Transaction Search (v1):** Partial support | List transactions (2/4 endpoints)
- **Payment Resources (v1):** Full support | Authorized payments, captures, and refunds lookup (5/5 endpoints)

#### Core Architecture
- Typed domain clients with `IPayPalHttpClient` interface for testing and DI
- Low-level `SendAsync` and high-level `Result<T, E>` patterns for error handling
- Full async/await support with `CancellationToken` propagation
- Fluent API builders via `M31.FluentApi` for better developer experience
- Source-generated JSON serialization context (`PayPalSDKJsonContext`) for AOT/trim support
- Thread-safe access token management with semaphore and 60-second refresh buffer
- Configurable `PayPalClientOptions` for HTTP client settings

#### Testing Infrastructure
- xUnit test suite with FluentAssertions (~83+ test files)
- `MockHttpMessageHandler` and `FakePayPalHttpClient` for HTTP testing without real servers
- JSON resource files with test data for all API areas
- Test base class with helpers to load resources

#### Documentation
- `README.md` with badges, feature list, NuGet install snippet, and documentation index
- `docs/GETTING_STARTED.md` — full setup guide with DI registration examples
- `docs/API_STATUS.md` — shows which endpoints are done
- `docs/EXAMPLES.md` — code examples for every API area
- `CONTRIBUTING.md` — coding rules, PR guidelines, and docs requirements
- `SECURITY.md` — how to keep credentials safe
- XML documentation on all public members

#### Packaging & Build
- Multi-target: `net8.0`, `net9.0`, `net10.0`
- NuGet package with symbols (snupkg), embedded sources, and README included
- AOT/trim ready (`IsTrimmable=true`, `IsAotCompatible=true`)
- `GenerateDocumentationFile=true` for IDE intellisense
- MIT license

### Changed
- Replaced strings with enums where possible for type safety
- Moved from `DataContract` attributes to `System.Text.Json` attributes
- Added `IPayPalHttpClient` interface to make HTTP client easier to swap
- Made all client classes sealed

### Fixed
- Thread-safety issue when getting access tokens at the same time
- Property naming issues across models (e.g., `Note` → `Notes`)
- Typos in method names across clients and documentation
- Error response handling in capture payment tests

### Removed
- Old `System.Runtime.Serialization` using statements
- Unused ReSharper suppression comments
- Duplicate `Amount` model

### Known Limitations
- Invoices: 55% endpoint coverage (15/27)
- Webhooks: 37% endpoint coverage (6/16)
- Transaction Search: 50% endpoint coverage (2/4)
- Identity (SCIM), Partner Referrals, Payment Experience, Payouts - not yet available

</details>

[unreleased]: https://github.com/TavstalDev/PayPalSDK/compare/v1.0.0...HEAD
[1.0.0]: https://github.com/TavstalDev/PayPalSDK/releases/tag/v1.0.0
