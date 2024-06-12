namespace NET_10._Standard_interfaceses;

public class Student: IComparable<Student>
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public DateTime BirthDate { get; set; }
    public StudentCard? StudentCard { get; set; }

    public int CompareTo(Student? other)
    {
        return FirstName!.CompareTo(other!.FirstName);
    }

    public override string ToString()
    {
        // @ - verbatim
        return $@"
Name:           {FirstName}
Surname:        {LastName}
BirthDate:      {BirthDate.ToShortDateString()}
StudentCard:    {StudentCard}";
    }
}
