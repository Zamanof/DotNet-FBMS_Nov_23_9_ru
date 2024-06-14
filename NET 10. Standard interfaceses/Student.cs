namespace NET_10._Standard_interfaceses;

public class Student: IComparable<Student>, ICloneable
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public DateTime BirthDate { get; set; }
    public StudentCard? StudentCard { get; set; }

    public object Clone()
    {
        Student tmp = (Student)this.MemberwiseClone();
        tmp.StudentCard = new StudentCard
        {
            Series = this.StudentCard!.Series,
            Id = this.StudentCard!.Id
        };
        return tmp;
    }

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
