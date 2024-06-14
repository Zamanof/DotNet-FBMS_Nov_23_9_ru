namespace NET_11._Events_Add_and_Remove;

internal class Student
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Age { get; set; }

    public void Exam(string task)
    {
        if (Age < 18)
        {
            Console.WriteLine($"{FirstName} {LastName} not solved {task}");
        }
        else
        {
            Console.WriteLine($"{FirstName} {LastName} solved {task}");
        }
    }
}
