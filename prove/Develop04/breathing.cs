using System.ComponentModel;
using System.Diagnostics;

public class BreathingActivity: Activity
{
    public BreathingActivity() : base("This activity will help you relax by guiding you through breathing exercises")
    {

    }

    protected void RunActivity()
    {
        int elapsed = 0;
        while (elapsed < Duration)
        {
            Console.WriteLine("Breath in....");
            PauseAnimation(3); 
            Console.WriteLine("Breath out...");
            PauseAnimation(3); 
            elapsed += 6; 
        }
    }
   
}