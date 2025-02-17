using System;

class Program
{
    static void Main(string[] args)
    {
        Reference refScripture = new Reference("Ephesians" 4, 2, 3);
        Scripture scripture = new Scripture(scriptureRef, 
            "Be completely humble and gentle; be patient, bearing with one another in love. " +
            "Make every effort to keep the unity of the Spirit through the bond of peace");

        while (true)
        {
            scripture.Display();
            Console.WriteLine("Press enter to hide words or type quit to exit");
            string input = Console.ReadLine();

            if (input == "quit") break;

            scripture.HideWords(2); 

            if (scripture.AllWordsHidden())
            {
                scripture.Display();
                Console.WriteLine("Words have been hidden. Program is ending!");
                break;
            }
        }
    }
}