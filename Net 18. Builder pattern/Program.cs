// Builder Pattern

// Product
// Builder
// Builder : Concrete
// Director

//IBuilder builder = new WoodBuilder();
//var stoneHouse = builder
//                        .BuildWall()
//                        .BuildWindow()
//                        .BuildPool()
//                        .BuildRoof()
//                        .BuildGarden()
//                        .BuildDoor()
//                        .BuildGarage()
//                        .GetHouse();
//Console.WriteLine(stoneHouse);

IBuilder builder = new StoneBuilder();

Master master = new(builder);
House house = master.Make("B");
Console.WriteLine(house);
master.ChangeBuilder(new WoodBuilder());
house = master.Make("B");
Console.WriteLine(house);

