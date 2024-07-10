// Builder Pattern

// Product
// Builder
// Builder : Concrete
// Director
class WoodBuilder : IBuilder
{
    public House House { get; set; } = new House { Name = "Wood House" };

    public IBuilder BuildDoor()
    {
        House.Door = 2;
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
        House.Pool = 5;
        return this;
    }

    public IBuilder BuildRoof()
    {
        House.HasRoof = true;
        return this;
    }

    public IBuilder BuildWall()
    {
        House.Walls = 1;
        return this;
    }

    public IBuilder BuildWindow()
    {
        House.Window = 20;
        return this;
    }

    public House GetHouse()=> House;

    public IBuilder Reset()
    {
        House = new House();
        return this;
    }
}
