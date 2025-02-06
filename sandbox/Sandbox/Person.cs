public class Person 
{
    private string _name;
    private int _age;

    public Person()
    {
        _name = "Unknown";
        _age = 0;
    }

    public void Display()
    {
        Console.WriteLine($"{_name} - {_age}");
    }

    public string GetName()
    {
        return _name;
    }

    public int GetAge()
    {
        return _age;
    }

    public void SetName(String name)
    {
        _name = name;
    }

    public void SetAge(int age)
    {
        if (age >= 0)
        {
            _age = age;
        }
        
        else
        {
            _age = 0;
        }
        
    }

}