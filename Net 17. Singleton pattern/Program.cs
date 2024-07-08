President president;
president = President.getInstance("Fransua", "Macrone", 45);
Console.WriteLine(president);
//president = null;
President president2 = null;
president2 = President.getInstance("Vladimir", "Putin", 75);
Console.WriteLine(president == president2);
Console.WriteLine(president2);
class President
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }

    private static President _instance = null;

    public  President(string name, string surname, int age)
    {
        Name = name;
        Surname = surname;
        Age = age;
    }

    public static President getInstance(string name, string surname, int age)
    {
        if (_instance is null)
        {
            _instance = new President(name, surname, age);
        }
        return _instance;
    }
    public override string ToString()
    {
        return $"{Name} {Surname}";
    }
}

