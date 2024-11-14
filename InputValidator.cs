using System;

namespace SebsFabrik;

public static class InputValidator
{
    public static string GetValidString(string prompt)
    {
        string value;
        do
        {
            System.Console.WriteLine(prompt);
            value = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(value))
            {
                PrintErrorMessage("Input cannot be empty. Try again.");
            } else if (int.TryParse(value, out _))
            {
                PrintErrorMessage("Input must be a text-string, not a number. Try again.");
            }
        } while (string.IsNullOrWhiteSpace(value) || int.TryParse(value, out _));
            return value;
    }

    public static int GetValidInt(string prompt)
    {
        int value;
        do {
            System.Console.WriteLine(prompt);
            if (!int.TryParse(Console.ReadLine(), out value) || value <=0)
            {
                PrintErrorMessage("Must be a positive number. Try again.");
            }
        } while (value <=0);
            return value;
    }

    public static double GetValidDouble(string prompt)
    {
        double value;
        do
        {
            System.Console.WriteLine(prompt);
            if (!double.TryParse(Console.ReadLine(), out value) || value <=0)
            {
                PrintErrorMessage("Must be a positive number. Try again.");
            }
        } while (value <=0);
        return value;
    }

    public static string GetvalidCarLicense()
        {
            string carLicense = string.Empty;
            bool isValid = false;

            while (!isValid)
            {
                System.Console.WriteLine("Enter your license plate. (3 letters followed by 3 numbers)");
                carLicense = Console.ReadLine().ToUpper();

                if (carLicense.Length == 6 &&
                    carLicense.Substring(0, 3).All(char.IsLetter) &&
                    carLicense.Substring(3, 3).All(char.IsDigit))
                    {
                        isValid = true;
                    } else {
                       PrintErrorMessage("Invalid license plate! Please enter the correct format.");
                    }
            }
            return carLicense;
        }

        private static void PrintErrorMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
}
