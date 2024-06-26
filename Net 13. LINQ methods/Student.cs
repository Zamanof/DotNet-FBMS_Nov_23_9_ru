
class Student
{
    public uint Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public byte Age { get; set; }
    public uint GroupId { get; set; }
    static uint count = 1;
    public Student() { Id = count++; }

    public override string ToString()
    {
        return $"{Id}. {FirstName} {LastName} - {Age} - {GroupId}";
    }

}
