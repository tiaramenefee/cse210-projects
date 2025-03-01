public class Activity 
{
    private string name;
    private string desciption; 
    private int duration; 

    public Activity(string name, string description)
    {
        name = name; 
        description = description; 
    }

    public void Start()
    {
        Console.WriteLine("Starting {Name}...");
        Console.WriteLine(Description);
        Console.Write("Enter Duration (seconds): ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        PauseAnimation(3);
        RunActivity();
        End();

    protected void RunActivity()
    {

    }

    protected void PauseAnimation(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(Starting in {i}......);
            Thread.Sleep(2000);
        }

        Console.WriteLine("Starting!");

    protected void End()
    {
        Console.WriteLine("Congratulation! You were able to complete the {Name} activity for {Duration} seconds");
        PauseAnimation(3);
    }
    }
    }
}