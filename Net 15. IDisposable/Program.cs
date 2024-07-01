//Foo foo = new Foo();
//foo.Dispose();
Foo bar = new Foo();
bar.Bar();
bar.Dispose();

class Foo : IDisposable
{
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

    ~Foo() { Cleaning(false); }
}
