using Net_18._Factory_method.Abstract;

namespace Net_18._Factory_method.Concrete;

internal class Ship : ITransport
{
    public void Deliver(string productName)
    {
        Console.WriteLine($"Deliver {productName} by sea in a big containers");
    }
}
