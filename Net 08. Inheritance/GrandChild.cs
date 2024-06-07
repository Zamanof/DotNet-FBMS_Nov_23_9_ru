//Base baseObject = new();
//Console.WriteLine(baseObject.Field1); 
//baseObject.Show();
//Console.WriteLine(derived.Field1);
//Console.WriteLine(derived.SomeDerivedProperty);

//derived.Show();

class GrandChild : Derived
{
    public GrandChild()
        : base("Goodbye", 69, 45, 24)
    {
        Console.WriteLine("GrandChild class Default constructor");
    }

    public GrandChild(string someDerivedProperty, int field1, int field2, int field3) 
        : base(someDerivedProperty, field1, field2, field3)
    {
        Console.WriteLine("GrandChild class Parametrized constructor");
    }
    public void GrandChildFoo()
    {
        Foo();
    }
}