// Indexer
// datatype this[argument_type] {get; set;}

//Garage garage = new(4);
//garage[0] = new Car { Model = "Mercedes", Price = 250000 };
//garage[1] = new Car { Model = "Ferrari", Price = 2000000 };
//garage[2] = new Car { Model = "Prius", Price = 90000000 };
////Console.WriteLine(garage.Count);
////for (int i = 0; i < garage.Count; i++)
////{
////    Console.WriteLine(garage[i]);
////}
//Console.WriteLine(garage["Ferrari"]);
//garage["Nissan"] = new Car { Model = "Nissan", Price = 123456789 };
//Console.WriteLine(garage["Nissan"]);

Random random = new Random();
MultiArray multiArray = new MultiArray(3, 3);
for (int i = 0;i < multiArray.Rows; i++)
{
    for (int j = 0;j < multiArray.Columns; j++)
    {
        multiArray[i, j] = random.Next(10, 99);
    }
}

for (int i = 0; i < multiArray.Rows; i++)
{
    for (int j = 0; j < multiArray.Columns; j++)
    {
        Console.Write($"{multiArray[i, j]} "); 
    }
    Console.WriteLine();
}

class Car
{
    public string Model { get; set; }
    public double Price { get; set; }
    public override string ToString()
    {
        return $"{Model} - {Price}$";
    }
}

class Garage
{
    Car[] cars;
    public Garage(int count)
    {
        cars = new Car[count];
    }
    public int Count { get { return cars.Length; } }

    // indexer
    public Car this[int index]
    {
        get
        {
            if (index >= 0 && index < cars.Length)
            {
                return cars[index];
            }
            throw new IndexOutOfRangeException();
        }
        set
        {
            cars[index] = value;
        }
    }
    public Car this[string model]
    {
        get
        {
            if (Enum.IsDefined(typeof(Models), model))
            {
                return cars[(int)Enum.Parse(typeof(Models), model)];
            }
            return new Car();
        }
        set
        {
            cars[(int)Enum.Parse(typeof(Models), model)] = value;
        }
    }
}

class MultiArray
{
    private int[,] array;
    public int Rows { get; set; }
    public int Columns { get; set; }

    public MultiArray(int rows, int columns)
    {
        Rows = rows;
        Columns = columns;
        array = new int[rows, columns];
    }

    // Multi Dimensional indexer
    public int this[int row, int column]
    {
        get => array[row, column];
        set => array[row, column] = value;
    }
}

enum Models { Mercedes, Ferrari, Prius, Nissan, Audi, NAZ, Lamborghini }