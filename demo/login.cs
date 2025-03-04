using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the User Login System!");

        // Predefined credentials (for simulation)
        string correctUsername = "admin";
        string correctPassword = "password123";

        // User input
        Console.Write("Enter username: ");
        string username = Console.ReadLine();

        Console.Write("Enter password: ");
        string password = ReadPassword(); // Hide password input

        // Authentication check
        if (username == correctUsername && password == correctPassword)
        {
            Console.WriteLine("\nLogin successful! Access granted.");
        }
        else
        {
            Console.WriteLine("\nInvalid username or password. Access denied.");
        }
    }

    // Function to hide password input
    static string ReadPassword()
    {
        string password = "";
        ConsoleKeyInfo key;

        do
        {
            key = Console.ReadKey(true);

            if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
            {
                password += key.KeyChar;
                Console.Write("*"); // Display * instead of actual password
            }
            else if (key.Key == ConsoleKey.Backspace && password.Length > 0)
            {
                password = password.Substring(0, password.Length - 1);
                Console.Write("\b \b"); // Remove last * from display
            }
        }
        while (key.Key != ConsoleKey.Enter);

        return password;
    }
}
