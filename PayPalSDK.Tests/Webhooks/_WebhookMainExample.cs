using Tavstal.PayPalSDK.Http;

namespace Tavstal.PayPalSDK.Tests.Webhooks;

public class _WebhookMainExample
{
    public static async Task PlayAsync(PayPalHttpClient client, string currencyCode)
    {
        bool active = true;
        while (active)
        {
            // Display menu options
            Console.WriteLine("# WEBHOOKS #");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1.");
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
                    
                    break;
                }
                case 2:
                {
                   
                    break;
                }
                case 3:
                {
                   
                    break;
                }
                case 4:
                {
                    
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