using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nW01 C# Programming Exercises");
            Console.WriteLine("1. Variables, Input, and Output");
            Console.WriteLine("2. Conditionals");
            Console.WriteLine("3. Loops");
            Console.WriteLine("4. Lists");
            Console.WriteLine("5. Functions");
            Console.WriteLine("0. Exit");
            Console.Write("Choose an option (0–5): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Prep1.Run();
                    break;
                case "2":
                    Prep2.Run();
                    break;
                case "3":
                    Prep3.Run();
                    break;
                case "4":
                    Prep4.Run();
                    break;
                case "5":
                    Prep5.Run();
                    break;
                case "0":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}

// Exercise 1 — Variables, Input, and Output
class Prep1
{
    public static void Run()
    {
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}

// Exercise 2 — Conditionals
class Prep2
{
    public static void Run()
    {
        Console.Write("Enter your grade percentage: ");
        int grade = int.Parse(Console.ReadLine());

        string letter;

        if (grade >= 90) letter = "A";
        else if (grade >= 80) letter = "B";
        else if (grade >= 70) letter = "C";
        else if (grade >= 60) letter = "D";
        else letter = "F";

        Console.WriteLine($"Your letter grade is: {letter}");

        if (grade >= 70)
            Console.WriteLine("You passed!");
        else
            Console.WriteLine("Keep trying, you’ll get it!");
    }
}

// Exercise 3 — Loops
class Prep3
{
    public static void Run()
    {
        int magicNumber = new Random().Next(1, 100);
        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("Guess the number (1–100): ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
                Console.WriteLine("Higher");
            else if (guess > magicNumber)
                Console.WriteLine("Lower");
            else
                Console.WriteLine("You guessed it!");
        }
    }
}

// Exercise 4 — Lists
class Prep4
{
    public static void Run()
    {
        List<int> numbers = new List<int>();
        int input;

        Console.WriteLine("Enter numbers (0 to finish):");
        do
        {
            input = int.Parse(Console.ReadLine());
            if (input != 0)
                numbers.Add(input);
        } while (input != 0);

        if (numbers.Count > 0)
        {
            int sum = numbers.Sum();
            float average = (float)sum / numbers.Count;
            int max = numbers.Max();

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average:F2}");
            Console.WriteLine($"Max: {max}");
        }
        else
        {
            Console.WriteLine("No numbers entered.");
        }
    }
}

// Exercise 5 — Functions
class Prep5
{
    public static void Run()
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        DisplayResult(name, square);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
    }
}
