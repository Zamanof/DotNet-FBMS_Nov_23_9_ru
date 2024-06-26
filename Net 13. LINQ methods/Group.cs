
class Group
{
    public uint Id { get; set; }
    public string? Name { get; set; }
    public string? Faculty { get; set; }

    public override string ToString()
    {
        return $"{Id}. {Name} - {Faculty}";
    }
}
