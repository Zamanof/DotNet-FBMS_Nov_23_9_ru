namespace Net_11._EventArgs;

internal class Student
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Age { get; set; }

    public void Exam(object sender, ExamEventArgs args)
    {
        Console.WriteLine($"{(sender as Teacher)?.FirstName} send task");
        if (Age < 18)
        {
            Console.WriteLine($"{FirstName} {LastName} not solved {args.Task}");
        }
        else
        {
            Console.WriteLine($"{FirstName} {LastName} solved {args.Task}");
        }
    }
}
