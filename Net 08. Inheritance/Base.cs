//Base baseObject = new();
//Console.WriteLine(baseObject.Field1); 
//baseObject.Show();
//Console.WriteLine(derived.Field1);
//Console.WriteLine(derived.SomeDerivedProperty);

//derived.Show();

class Base
{
    public int Field1 { get; set; }
    private int Field2 { get; set; }
    protected int Field3 { get; set; }

    public Base()
    {
        Field1 = 26;
        Field2 = 336;
        Field3 = 13;
        Console.WriteLine("Base class Default constructor");
    }

    public Base(int field1, int field2, int field3)
    {
        Field1 = field1;
        Field2 = field2;
        Field3 = field3;
        Console.WriteLine("Base class Parametrized constructor");
    }

    public void Show()
    {
        Console.WriteLine($"Field1={Field1}, Field2={Field2}, Field3={Field3}");
    }
    protected void Foo()
    {
        Console.WriteLine("Base protected method Foo()");
        Bar();
    }
    private void Bar()
    {
        Console.WriteLine("Base private method Bar()");
    }
    public override string ToString()
    {
        return $"Field1={Field1}, Field2={Field2}, Field3={Field3}";
    }
}
