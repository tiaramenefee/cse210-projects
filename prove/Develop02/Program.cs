using System;

class Program
{
    static void DisplayMenu()
    {
        Console.WriteLine("Please choose one of the following options:");
        Console.WriteLine(" 1. Write");
        Console.WriteLine(" 2. Display"); 
        Console.WriteLine(" 3. Load");
        Console.WriteLine(" 4. Save");
        Console.WriteLine(" 5. Quit");
        Console.Write("Enter in your choice:");
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGen promptGen = new PromptGen();
        bool keepRunning = true;

        while (keepRunning) 
        
        {
            DisplayMenu();
            string choice = Console.ReadLine();

            if (choice == "1") 
            {
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine("Prompt: {promptText}");
                Console.WriteLine("Entry: {entryText} "); 
                string entry = Console.ReadLine();

                                
                Entry newEntry = new Entry(DateTime.Now.ToShortDateString(), prompt, Entry);
                myJournal.AddEntry(newEntry);
            }
            else if (choice == "2")
            {
                
                myJournal.Display();
            }
            else if (choice == "3")
            {
                
                Console.Write("Enter filename to save: ");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
            }
            else if (choice == "4")
            {
                
                Console.Write("Enter filename to load: ");
                string filename = Console.ReadLine();
                myJournal.LoadFromFile(filename);
            }
            else if (choice == "5")
            {
            
                keepRunning = false;
            }
            else
            {
                Console.WriteLine("Sorry, that is not vaild. Can you please try again?!.");
            }

        } 

        
    }
}
