namespace Net_08._Polymorphism;

class Derived: Base
{
    public string Field1 { get; set; } = "Hacuna Matata";
    public override void Show()
    {
        Console.WriteLine("Derived class show");
    }
}
