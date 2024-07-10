// Builder Pattern

// Product
// Builder
// Builder : Concrete
// Director
class Master // Director
{ 
    private IBuilder _builder;

    public Master(IBuilder builder)
    {
        _builder = builder;
    }

    public void ChangeBuilder(IBuilder builder)
    {
        _builder = builder;
    }

    public House Make(string type)
    {
        _builder.Reset();
        switch (type)
        {
            case "A":
                _builder.House.Name = "A Category House";
                return _builder
                    .BuildRoof()
                    .BuildGarden()
                    .BuildDoor()
                    .BuildGarage()
                    .GetHouse();
            case "B":
                _builder.House.Name = "B Category House";
                return _builder
                    .BuildRoof()
                    .BuildWall()
                    .BuildWindow()
                    .BuildGarage()
                    .GetHouse();
            case "C":
                _builder.House.Name = "C Category House";
                return _builder
                    .BuildRoof()
                    .BuildWall()
                    .BuildDoor()
                    .BuildWindow()
                    .BuildGarage()
                    .BuildPool()
                    .BuildGarden()
                    .GetHouse();
        default: throw new Exception("Wrong Type");
        }
    }
}