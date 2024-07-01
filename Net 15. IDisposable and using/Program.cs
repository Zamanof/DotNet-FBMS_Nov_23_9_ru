//Foo foo = new Foo();
////foo.Bar();
//try
//{
//    foo.Bar();
//}
//finally
//{
//    foo.Dispose();
//}

// Syntax sugar
using (Foo newFoo = new Foo())
{
    newFoo.Bar();
}

class Foo : IDisposable
{
    public Foo()
    {
        Console.WriteLine("Constructor");
    }
    private bool _isDisposed = false;
    private void Cleaning(bool disposing)
    {
        if (!_isDisposed)
        {
            if (disposing)
            {
                Console.WriteLine("Managed resources are cleaned");
            }
            Console.WriteLine("Unmanaged resources are cleaned");
            _isDisposed = true;
        }
    }
    public void Dispose()
    {
        Cleaning(true);
        GC.SuppressFinalize(this);
    }
    public void Bar()
    {
        Console.WriteLine("Some operations");
        throw new NotImplementedException();
    }


}