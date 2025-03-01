class ListingActivity : Activity
{
    private string[] Prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : ("This activity helps you reflect on the good things in your life.")
    {
    }

    protected void RunActivity()
    {
        Random rand = new Random();
        Console.WriteLine(Prompts[rand.Next(Prompts.Length)]);
        PauseAnimation(3);

        Console.WriteLine("Start listing items (press Enter after each one, type 'done' when finished):");

        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now < endTime)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "done") break;
            count++;
        }

        Console.WriteLine($"You listed {count} items!");
    }