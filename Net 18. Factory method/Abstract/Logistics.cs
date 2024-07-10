namespace Net_18._Factory_method.Abstract;

abstract class Logistics
{
    public void Delivery()
    {
        Console.WriteLine("Logistic Delivery");
    }
    public abstract ITransport CreateTransport();
}
