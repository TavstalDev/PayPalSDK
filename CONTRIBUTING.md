# Contributing to PayPalSDK

Thank you for wanting to help out! PayPalSDK is a simple, lightweight C# library for the PayPal REST v2 APIs. Whether you are fixing a bug, adding a new feature, or updating the documentation, your help is highly appreciated.

---

## Table of Contents

- [Code of Conduct](#code-of-conduct)
- [How to Contribute](#how-to-contribute)
- [Reporting Bugs](#reporting-bugs)
- [Suggesting Features](#suggesting-features)
- [Submitting a Pull Request](#submitting-a-pull-request)
- [Coding Standards](#coding-standards)

---

## Code of Conduct

By joining this project, you agree to treat everyone with respect and kindness. Please:

- Use welcoming and friendly language.
- Respect different opinions and experiences.
- Accept feedback and criticism calmly.
- Focus on what is best for the community and the project.

Bad behavior like harassment, trolling, or personal attacks is not allowed. Anyone who does this may be removed from the project.

---

## How to Contribute

1. **Fork** the repository and create a new branch from `main`.
2. Make your changes and follow our [Coding Standards](#coding-standards).
3. Make sure your changes do not break existing tests (and add new tests if you can).
4. **Open a Pull Request (PR)** to the `main` branch.

You do not need to open an issue before every PR. However, for big changes or new features, please talk to us first by opening an issue. This saves you time and prevents double work.

---

## Reporting Bugs

If you find a bug, please [open an issue](https://github.com/TavstalDev/PayPalSDK/issues) and include:

- A clear, simple title.
- Steps to reproduce the problem.
- What you expected to happen vs. what actually happened.
- Your .NET version and framework.
- Any error messages or stack traces.

---

## Suggesting Features

We love new ideas! Open an issue and describe:

- The problem you want to solve.
- Your idea for the solution or how the code should look.
- Any other alternatives you thought about.

---

## Submitting a Pull Request

You can send a PR anytime, but please use the **PR template** if there is one. It helps us review your code faster and understand your changes better.

When you open a PR:

1. Give it a clear title (for example, use `Add webhook signature verification` instead of `Fix stuff`).
2. Fill out the PR template as much as possible.
3. Link any related issues in the description (for example, `Closes #42`).
4. Keep it small—it is best to fix only one thing per PR.
5. The project maintainer will review all PRs. Be ready for some feedback and discussion.

---

## Coding Standards

### General

- Look at the **existing code style** and write your code the same way.
- Keep your code simple and easy to read. Clean and clear code is better than "smart" code.

### XML Documentation (`PayPalSDK` project)

All public classes, interfaces, enums, methods, properties, and constructors in the main `PayPalSDK` project **must** have XML comments.

```csharp
/// <summary>
/// Creates a new PayPal order using the Orders v2 API.
/// </summary>
/// <param name="request">The order creation request payload.</param>
/// <returns>The created <see cref="Order"/> object.</returns>
public async Task<Order> CreateOrderAsync(CreateOrderRequest request)
{
    // ...
}
```

### Comments in PayPalSDK.Tests

You do not need XML comments in the test project. However, if a test is long or complicated, please add a short comment to explain what it does and why.
```csharp
// Arrange a sandbox order with a minimal item list to verify
// that capture returns a COMPLETED status on success.
var order = await _client.CreateOrderAsync(...);
```

## Questions?

If you are unsure about anything, just open an issue and ask. Every contribution helps, no matter how small. Thank you for making PayPalSDK better!