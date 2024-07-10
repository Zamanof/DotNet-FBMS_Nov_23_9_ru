using Net_18._Factory_method.Abstract;

namespace Net_18._Factory_method.Concrete;

internal class AirLogistics : Logistics
{
    public override ITransport CreateTransport() => new Airplane();
   
}
