//Base baseObject = new();
//Console.WriteLine(baseObject.Field1); 
//baseObject.Show();
//Console.WriteLine(derived.Field1);
//Console.WriteLine(derived.SomeDerivedProperty);

//derived.Show();

class Derived : Base
{
    public string SomeDerivedProperty { get; set; }
    public Derived()
    {
        SomeDerivedProperty = "Salam";
        Console.WriteLine("Derived class default constructor");
    }

    public Derived(string someDerivedProperty, int field1, int field2, int field3)
        :base(field1, field2, field3)
    {
        SomeDerivedProperty = someDerivedProperty;
        Console.WriteLine("Derived class Parametrized constructor");
    }

    public void DerivedFoo()
    {
        Foo();
    }
    public void DerivedShow()
    {
        Show();
    }
    public override string ToString()
    {
        return $"SomeDerivedProperty={SomeDerivedProperty}, {base.ToString()}";
    }
}
