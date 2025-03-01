using System;

class Program
{

     static void Display() 
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting actvity");
        Console.WriteLine("3. Start Listening activiy");
        Console.WriteLine("4. Quit");
        Console.WriteLine();

    } 
    static void Main(string[] args)
    {
         bool keepRunning = true; 

        while (keepRunning)
        {
            Display();

            Console.Write("Enter Choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {

                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Start();

            else if (choice == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Start();
            }

            else if (choice == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Start();
            }

            else if (choice == "4")
            {
                keepRunning = false;
            }

            else 
            {
                Console.WriteLine("Sorry, that is not vaild. Please try again!");
            }

        }
    }

`
    }
}