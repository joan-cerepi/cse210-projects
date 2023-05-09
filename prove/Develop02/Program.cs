using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        // Instantiate a PromptGenerator object and store it in promptGenerator.
        PromptGenerator promptGenerator = GeneratePrompt();

        // Instantiate a new Journal object.
        Journal myJournal = new Journal();

        // Initialize a flag boolean variable for when you want
        // to break out of the while loop.
        bool isActive = true;

        // Keep running until the user hits quit.
        while (isActive)
        {
            // Option menu.
            Menu();
            Console.Write("What would you like to do? ");

            // Store user selected integer in userChoice.
            int userChoice = int.Parse(Console.ReadLine());

            // Execute code based on the selected answer.
            switch (userChoice)
            {
                case 1:
                    // Instantiate an Entry object.
                    Entry entry = new Entry();
                    // Call the entry object's WriteEntry method.
                    // Make sure WriteEntry takes in a promptGenerator object.
                    entry.WriteEntry(promptGenerator);
                    // Add entry object to the Journal object.
                    myJournal.AddEntry(entry);
                    break;
                case 2:
                    // Display each entry inside of myJournal.
                    myJournal.DisplayEntries();
                    break;
                case 3:
                    // Overwrite myJournal with a new Journal object.
                    myJournal = new Journal();
                    // Read file data into the myJournal Journal object.
                    myJournal.LoadFromFile();
                    break;
                case 4:
                    // Write all the data inside myJournal into a file of your choosing.
                    myJournal.SaveToFile();
                    break;
                case 5:
                    // Switch flag variable to false and prevent
                    // future iterations.
                    isActive = false;
                    break;
            }
            Console.WriteLine();
        }
    }

    /// <summary>
    /// Print out option menu.
    /// </summary>
    static void Menu()
    {
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
    }

    static PromptGenerator GeneratePrompt() 
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        promptGenerator.AddPrompts(
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What are three things you are grateful for today and why?",
            "What is one accomplishment you are proud of from today and why?",
            "Describe a moment from today that brought you joy or made you smile.",
            "What are some things you are looking forward to in the upcoming days or weeks?",
            "Write about a goal you have for yourself and the steps you can take to achieve it.",
            "Describe your current mood and what may have contributed to it."
        );
        return promptGenerator;
    }
}