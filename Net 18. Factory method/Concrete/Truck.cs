using Net_18._Factory_method.Abstract;
namespace Net_18._Factory_method.Concrete;

internal class Truck : ITransport
{
    public void Deliver(string productName)
    {
        Console.WriteLine($"Deliver {productName} by land in box");
    }
}
