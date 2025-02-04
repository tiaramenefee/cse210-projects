public class Entry
{
    public string _date;
    public string _promptText;
    public DateTime _text;

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Text: {_text}");
    }
}