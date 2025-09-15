using System;

// This program fulfills all the core requirements for the W02 Journal project.
// It EXCEEDS requirements by:
// 1. Saving entries in CSV format with proper escaping for quotes and commas.
// 2. Displaying informative messages and validations.
// 3. Using a clean UI layout.
// 4. Handling potential errors gracefully.
//
// Created by: Harriet Kitiibwa
// Date: September 15, 2025

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string input = "";

        while (input != "5")
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save journal to a file");
            Console.WriteLine("4. Load journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option (1-5): ");
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    journal.WriteEntry();
                    break;
                case "2":
                    journal.DisplayJournal();
                    break;
                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;
                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;
                case "5":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please choose 1-5.");
                    break;
            }
        }
    }
}
