using Tavstal.PayPalSDK.Constants;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Models.ProductCatalog;

namespace Tavstal.PayPalSDK.Tests.ProductCatalog;

public static class _ProductCatalogMainExample
{
    public static async Task PlayAsync(PayPalHttpClient client, string currencyCode)
    {
        bool active = true;
        while (active)
        {
            // Display menu options
            Console.WriteLine("# PRODUCT CATALOG #");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Get Product");
            Console.WriteLine("2. List Product");
            Console.WriteLine("3. Create Product");
            Console.WriteLine("4. Update Product");
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
                    // Get Product
                    Console.WriteLine("Please provide Product ID:");
                    string? productId = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(productId))
                    {
                        Console.WriteLine("Product ID cannot be empty.");
                        continue;
                    }

                    var request = new ProductGetRequest(productId);
                    var response = await client.SendAsync(request);

                    if (!response.IsSuccessStatusCode)
                    {
                        Console.WriteLine("Error: " + response.ReasonPhrase);
                        break;
                    }

                    var result = await request.GetResponseBodyAsync(response);
                    if (result == null)
                    {
                        Console.WriteLine("No product found with the provided ID.");
                        break;
                    }
                    
                    Console.WriteLine("Product Details:");
                    Console.WriteLine($"ID: {result.Id}");
                    Console.WriteLine($"Name: {result.Name}");
                    Console.WriteLine($"Description: {result.Description}");
                    Console.WriteLine($"Type: {result.Type}");
                    Console.WriteLine($"Category: {result.Category}");
                    break;
                }
                case 2:
                {
                    // List Product
                    var request = new ProductListRequest();
                    var response = await client.SendAsync(request);
                    if (!response.IsSuccessStatusCode)
                    {
                        Console.WriteLine("Error: " + response.ReasonPhrase);
                        break;
                    }
                    
                    var result = await request.GetResponseBodyAsync(response);
                    if (result == null || !result.Products.Any())
                    {
                        Console.WriteLine("No products found.");
                        break;
                    }
                    Console.WriteLine("Product List:");
                    foreach (var product in result.Products)
                    {
                        Console.WriteLine($"ID: {product.Id}, Name: {product.Name}");
                    }
                    break;
                }
                case 3:
                {
                    // Create Product
                    var request = new ProductCreateRequest(new ProductBody()
                    {
                        Name = "Test Product",
                        Type = ProductType.DIGITAL
                    });
                    var response = await client.SendAsync(request);
                    if (!response.IsSuccessStatusCode)
                    {
                        Console.WriteLine("Error: " + response.ReasonPhrase);
                        break;
                    }
                    
                    var result = await request.GetResponseBodyAsync(response);
                    if (result == null)
                    {
                        Console.WriteLine("Failed to get response body.");
                        break;
                    }
                    
                    Console.WriteLine("Product Created Successfully:");
                    Console.WriteLine($"ID: {result.Id}");
                    Console.WriteLine($"Name: {result.Name}");
                    Console.WriteLine($"Description: {result.Description}");
                    break;
                }
                case 4:
                {
                    // Update Product
                    var request = new ProductUpdateRequest("PROD-1234567890", new List<UpdateOperation>
                    {
                        new UpdateOperation()
                        {
                            From = "/name",
                            Op = "REPLACE",
                            Value = "Updated Product Name"
                        }
                    });
                    var response = await client.SendAsync(request);
                    if (!response.IsSuccessStatusCode)
                    {
                        Console.WriteLine("Error: " + response.ReasonPhrase);
                        break;
                    }
                    Console.WriteLine("Product Updated Successfully");
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