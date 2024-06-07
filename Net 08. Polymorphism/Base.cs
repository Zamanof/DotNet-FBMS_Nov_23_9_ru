class Base
{
    public string Field1 { get; set; } = "Aloha";
    public virtual void Show()
    {
        Console.WriteLine("Base class show");
    }
}
