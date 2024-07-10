// Builder Pattern

// Product
// Builder
// Builder : Concrete
// Director
class StoneBuilder : IBuilder
{
    public House House { get; set; } = new House { Name = "Stone House" };

    public IBuilder BuildDoor()
    {
        House.Door = 1;
        return this;
    }

    public IBuilder BuildGarage()
    {
        House.Garage = 1;
        return this;
    }

    public IBuilder BuildGarden()
    {
        House.Garden = 1;
        return this;
    }

    public IBuilder BuildPool()
    {
        House.Pool = 1;
        return this;
    }

    public IBuilder BuildRoof()
    {
        House.HasRoof = false;
        return this;
    }

    public IBuilder BuildWall()
    {
        House.Walls = 4;
        return this;
    }

    public IBuilder BuildWindow()
    {
        House.Window = 4;
        return this;
    }

    public House GetHouse() => House;

    public IBuilder Reset()
    {
        House = new House();
        return this;
    }
}