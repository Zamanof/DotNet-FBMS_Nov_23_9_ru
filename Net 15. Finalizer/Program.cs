Foo foo = new();
SomeMethod(foo);

void SomeMethod(Foo foo)
{
    Console.WriteLine("Method some method");
}
class Foo
{
    public Foo()
    {
        Console.WriteLine("Constructor is working");
    }
    // Finalizer
    ~Foo() {
        Console.WriteLine("Finalizer is working");
    }

}