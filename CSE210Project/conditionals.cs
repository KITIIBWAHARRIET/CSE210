using System;

class GradeCalculator
{
    public void CalculateGrade()
    {
        // Ask the user for their grade percentage
        Console.Write("What is your grade percentage? ");
        string? userInput = Console.ReadLine();

        if (string.IsNullOrEmpty(userInput) || !int.TryParse(userInput, out int percentage))
        {
            Console.WriteLine("Invalid input. Please enter a valid number for the grade percentage.");
            return; // exit the method or you can loop to ask again if you prefer
        }

        string letter = "";
        string sign = "";

        // Determine letter grade
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine + or - sign (Stretch Challenge)
        int lastDigit = percentage % 10;

        if (letter != "A" && letter != "F") // A+ and F+/F- are not used
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (letter == "A" && percentage < 93)
        {
            // A- is valid only for 90-92
            sign = "-";
        }

        // Print the final grade
        Console.WriteLine($"Your letter grade is: {letter}{sign}");

        // Print pass/fail message
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Don't give up! You'll do better next time.");
        }
    }
}
