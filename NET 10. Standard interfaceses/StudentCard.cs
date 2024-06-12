namespace NET_10._Standard_interfaceses;

public class StudentCard
{
    public int Id { get; set; }
    public string? Series { get; set; }

    public override string ToString()
    {
        return $"{Series} {Id}";
    }
}