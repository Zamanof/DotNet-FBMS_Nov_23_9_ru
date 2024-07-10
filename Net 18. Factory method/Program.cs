using Net_18._Factory_method.Abstract;
using Net_18._Factory_method.Concrete;

// https://refactoring.guru/ru/design-patterns/factory-method

Logistics logistics = new RoadLogistics();

DeliverProducts(new RoadLogistics(), "Coca Cola");
DeliverProducts(new AirLogistics(), "Coca Cola");
DeliverProducts(new SeaLogistics(), "Coca Cola");


void DeliverProducts(Logistics logistics, string productName)
{
    ITransport transport = logistics.CreateTransport();
    transport.Deliver(productName);
}