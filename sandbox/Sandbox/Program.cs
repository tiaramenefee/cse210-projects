using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
       string adjective = GetAdjective();
       string noun = GetNoun();
       
       int number = Multiply(3, 4);
       
        Console.WriteLine($"I looked out the window and saw a {number} {adjective} {noun}s ");
    }

    static int Multiply (int number1, int nnumber2)
    {
        int product = number1 * nnumber2;
        
        return product;
    }

    static string GetAdjective ()
    {
        string adjective = "yellow";

        return adjective; 
    }

    static string GetNoun ()
    {
        string word = "bird"; 

        return word;
    }
}