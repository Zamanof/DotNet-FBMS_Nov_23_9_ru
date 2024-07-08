namespace Net_16._Atributes;
[AuthorInfo("Nadir", "zamanov@itstep.org")]
public class Book
{
    public int Id { get; set; }
    public string? Name { get; set; }
    [AuthorInfo("Salam", "Salamzadeh@salam.org")]
    public string? Description { get; set; }
    public string? Author { get; set; }
}
