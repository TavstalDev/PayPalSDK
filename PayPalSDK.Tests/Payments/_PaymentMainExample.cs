using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Payments;

namespace Tavstal.PayPalSDK.Tests.Payments;

public static class _PaymentMainExample
{
    public static async Task PlayAsync(PayPalHttpClient client, string currencyCode)
    {
        bool active = true;
        while (active)
        {
            // Display menu options
            Console.WriteLine("# PAYMENTS #");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Show Authorized Payment Details");
            Console.WriteLine("2. Show Captured Payment Details");
            Console.WriteLine("3. Show Refund Details");
            Console.WriteLine("4. Capture Authorized Payment");
            Console.WriteLine("5. Reauthorize Authorized Payment");
            Console.WriteLine("6. Void Authorized Payment");
            Console.WriteLine("7. Refund Captured Payment");
            Console.WriteLine("0. Go back.");
            string? input = Console.ReadLine();

            // Validate user input
            if (!int.TryParse(input, out int inputInt))
            {
                Console.WriteLine("Please provide valid integer number.");
                continue;
            }

            // Handle menu selection
            switch (inputInt)
            {
                case 0:
                {
                    // Exit to main menu
                    active = false;
                    continue;
                }
                case 1:
                {
                    // Get details of an authorized payment
                    Console.WriteLine("Please enter the Authorization ID:");
                    string? authorizationId = Console.ReadLine();
                    if (string.IsNullOrEmpty(authorizationId))
                    {
                        Console.WriteLine("Authorization ID cannot be empty.");
                        break;
                    }
                    
                    var request = new PaymentGetAuthorizedDetailsRequest(authorizationId);
                    var response = await client.SendAsync(request);
                    
                    if (response.StatusCode != System.Net.HttpStatusCode.OK)
                    {
                        Console.WriteLine("Failed to retrieve authorized payment details.");
                        break;
                    }
                    var paymentDetails = await request.GetResponseBodyAsync(response);
                    if (paymentDetails == null)
                    {
                        Console.WriteLine("Failed to get payment details body.");
                        break;
                    }
                    
                    Console.WriteLine($"Payment ID: {paymentDetails.Id}");
                    Console.WriteLine($"Status: {paymentDetails.Status}");
                    Console.WriteLine($"Amount: {paymentDetails.Amount.Value} {paymentDetails.Amount.CurrencyCode}");
                    break;
                }
                case 2:
                {
                    // Get details of a captured payment
                    Console.WriteLine("Please enter the Capture ID:");
                    string? captureId = Console.ReadLine();
                    if (string.IsNullOrEmpty(captureId))
                    {
                        Console.WriteLine("Capture ID cannot be empty.");
                        break;
                    }
                    
                    var request = new PaymentGetCapturedDetailsRequest(captureId);
                    var response = await client.SendAsync(request);
                    if (response.StatusCode != System.Net.HttpStatusCode.OK)
                    {
                        Console.WriteLine("Failed to retrieve captured payment details.");
                        break;
                    }
                    
                    var paymentDetails = await request.GetResponseBodyAsync(response);
                    if (paymentDetails == null)
                    {
                        Console.WriteLine("Failed to get payment details body.");
                        break;
                    }
                    
                    Console.WriteLine($"Payment ID: {paymentDetails.Id}");
                    Console.WriteLine($"Status: {paymentDetails.Status}");
                    Console.WriteLine($"Amount: {paymentDetails.Amount.Value} {paymentDetails.Amount.CurrencyCode}");
                    break;
                }
                case 3:
                {
                    // Get details of a refund
                    Console.WriteLine("Please enter the Refund ID:");
                    string? refundId = Console.ReadLine();
                    if (string.IsNullOrEmpty(refundId))
                    {
                        Console.WriteLine("Refund ID cannot be empty.");
                        break;
                    }
                    
                    var request = new PaymentGetRefundDetailsRequest(refundId);
                    var response = await client.SendAsync(request);
                    
                    if (response.StatusCode != System.Net.HttpStatusCode.OK)
                    {
                        Console.WriteLine("Failed to retrieve refund details.");
                        break;
                    }
                    
                    var refundDetails = await request.GetResponseBodyAsync(response);
                    if (refundDetails == null)
                    {
                        Console.WriteLine("Failed to get refund details body.");
                        break;
                    }
                    
                    Console.WriteLine($"Refund ID: {refundDetails.Id}");
                    Console.WriteLine($"Status: {refundDetails.Status}");
                    Console.WriteLine($"Amount: {refundDetails.Amount.Value} {refundDetails.Amount.CurrencyCode}");
                    break;
                }
                case 4:
                {
                    // Capture an authorized payment
                    Console.WriteLine("Please enter the Authorization ID:");
                    string? authorizationId = Console.ReadLine();
                    if (string.IsNullOrEmpty(authorizationId))
                    {
                        Console.WriteLine("Authorization ID cannot be empty.");
                        break;
                    }
                    
                    var request = new PaymentCaptureRequest(authorizationId, new PaymentCaptureRequestBody());
                    var response = await client.SendAsync(request);
                    
                    if (!(response.StatusCode == System.Net.HttpStatusCode.OK || response.StatusCode == System.Net.HttpStatusCode.Created))
                    {
                        Console.WriteLine("Failed to capture authorized payment.");
                        break;
                    }
                    
                    var captureDetails = await request.GetResponseBodyAsync(response);
                    if (captureDetails == null)
                    {
                        Console.WriteLine("Failed to get capture details body.");
                        break;
                    }
                    
                    Console.WriteLine($"Capture ID: {captureDetails.Id}");
                    Console.WriteLine($"Status: {captureDetails.Status}");
                    Console.WriteLine($"Amount: {captureDetails.Amount.Value} {captureDetails.Amount.CurrencyCode}");
                    break;
                }
                case 5:
                {
                    // Reauthorize an authorized payment
                    Console.WriteLine("Please enter the Authorization ID:");
                    string? authorizationId = Console.ReadLine();
                    if (string.IsNullOrEmpty(authorizationId))
                    {
                        Console.WriteLine("Authorization ID cannot be empty.");
                        break;
                    }
                    
                    var request = new PaymentReauthorizeRequest(authorizationId);
                    var response = await client.SendAsync(request);
                    
                    if (!(response.StatusCode == System.Net.HttpStatusCode.OK || response.StatusCode == System.Net.HttpStatusCode.Created))
                    {
                        Console.WriteLine("Failed to reauthorize authorized payment.");
                        break;
                    }
                    
                    var reauthorizationDetails = await request.GetResponseBodyAsync(response);
                    if (reauthorizationDetails == null)
                    {
                        Console.WriteLine("Failed to get reauthorization details body.");
                        break;
                    }
                    
                    Console.WriteLine($"Reauthorization ID: {reauthorizationDetails.Id}");
                    Console.WriteLine($"Status: {reauthorizationDetails.Status}");
                    Console.WriteLine($"Amount: {reauthorizationDetails.Amount.Value} {reauthorizationDetails.Amount.CurrencyCode}");
                    break;
                }
                case 6:
                {
                    // Void an authorized payment
                    Console.WriteLine("Please enter the Authorization ID:");
                    string? authorizationId = Console.ReadLine();
                    if (string.IsNullOrEmpty(authorizationId))
                    {
                        Console.WriteLine("Authorization ID cannot be empty.");
                        break;
                    }
                    
                    var request = new PaymentVoidRequest(authorizationId);
                    var response = await client.SendAsync(request);
                    if (response.StatusCode != System.Net.HttpStatusCode.NoContent)
                    {
                        Console.WriteLine("Failed to void authorized payment.");
                        break;
                    }
                    Console.WriteLine("Authorized payment voided successfully.");
                    break;
                }
                case 7:
                {
                    // Refund a captured payment
                    Console.WriteLine("Please enter the Capture ID:");
                    string? captureId = Console.ReadLine();
                    if (string.IsNullOrEmpty(captureId))
                    {
                        Console.WriteLine("Capture ID cannot be empty.");
                        break;
                    }
                    
                    var request = new PaymentRefundRequest(captureId, new PaymentRefundRequestBody());
                    var response = await client.SendAsync(request);
                    
                    if (!(response.StatusCode == System.Net.HttpStatusCode.OK || response.StatusCode == System.Net.HttpStatusCode.Created))
                    {
                        Console.WriteLine("Failed to refund captured payment.");
                        break;
                    }
                    
                    var refundDetails = await request.GetResponseBodyAsync(response);
                    if (refundDetails == null)
                    {
                        Console.WriteLine("Failed to get refund details body.");
                        break;
                    }
                    
                    Console.WriteLine($"Refund ID: {refundDetails.Id}");
                    Console.WriteLine($"Status: {refundDetails.Status}");
                    Console.WriteLine($"Amount: {refundDetails.Amount.Value} {refundDetails.Amount.CurrencyCode}");
                    break;
                }
            }

            // Wait for user input before continuing
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}