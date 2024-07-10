using Net_18._Factory_method.Abstract;

namespace Net_18._Factory_method.Concrete;

internal class RoadLogistics : Logistics
{
    public override ITransport CreateTransport()
    {
        return new Truck();
    }
}
