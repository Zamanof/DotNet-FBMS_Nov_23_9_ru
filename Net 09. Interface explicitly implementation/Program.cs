// Interface explicitly implementation
SomeClass someClass = new SomeClass();

//someClass.SomeMethod(23, 56);

Foo(someClass);

void Foo(ISomeInterface some)
{
    (some as SomeClass)!.SomeMethod(56, 89);
}
interface ISomeInterface
{
    void SomeMethod();
}

class SomeClass : ISomeInterface
{
    public void SomeMethod(int a, int b)
    {
        Console.WriteLine(a +b);
    }

    void ISomeInterface.SomeMethod()
    {
        throw new NotImplementedException();
    }
}
