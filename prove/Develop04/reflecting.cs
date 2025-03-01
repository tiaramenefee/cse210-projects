using System.Diagnostics;

class ReflectingActivity: Activity 
{
      private string[] Prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] Questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What did you learn about yourself through this experience?"
    };

    public ReflectingActivity() : base("This activity helps you reflect on moments when you showed strength and resilience.")
    {
    }

    protected override void RunActivity()
    {
        Random rand = new Random();
        Console.WriteLine(Prompts[rand.Next(Prompts.Length)]);
        PauseAnimation(3);

        int elapsed = 0;
        while (elapsed < Duration)
        {
            Console.WriteLine(Questions[rand.Next(Questions.Length)]);
            PauseAnimation(3);
            elapsed += 3;
        }
    } 
}