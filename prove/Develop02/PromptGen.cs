public class PromptGen
{
    public string _name;

    public static List<string> _prompts = new List<string>
    {
        "What was your favorite moment of the day?",
        "How did you feel when you woke up this morning?",
        "What three things are you grateful for today?",
        "If you could be doing anything right noww, what would that be?",
        "What are your current goals for the year?",
        "Who is your role model and why?",
        "What makes you happy?"
        "What was the best part of your day?",
    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

}