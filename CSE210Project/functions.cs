using System;

class UserFunctions
{
    public void Run()
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(favoriteNumber);

        DisplayResult(userName, squaredNumber);
    }

    private void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    private string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string? name = Console.ReadLine(); // ✅ Use nullable type

        // ✅ Check for null or empty string
        while (string.IsNullOrWhiteSpace(name))
        {
            Console.Write("Name cannot be empty. Please enter your name: ");
            name = Console.ReadLine();
        }

        return name; // ✅ name is guaranteed to be non-null here
    }

    private int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string? input = Console.ReadLine(); // ✅ Nullable
        int number;

        // ✅ TryParse avoids crash and warning (instead of int.Parse)
        while (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out number))
        {
            Console.Write("Invalid input. Please enter a valid number: ");
            input = Console.ReadLine();
        }

        return number;
    }

    private int SquareNumber(int number)
    {
        return number * number;
    }

    private void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}
