namespace Net_16._Atributes;
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
public class AuthorInfoAttribute: Attribute
{
    public string? Name { get; set; }
    public string? Email { get; set; }
    public AuthorInfoAttribute(){}

    public AuthorInfoAttribute(string? name, string? email)
    {
        Name = name;
        Email = email;
    }

    public override string ToString()
    {
        return $"Author this code: {Name} -> {Email}";
    }
}
