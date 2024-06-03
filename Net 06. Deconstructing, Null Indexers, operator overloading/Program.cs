// Deconstructing, tuple
Car car = new Car(Model: "Ferrari", Year: 2024);
//int year = car.Year;
//string model = car.Model;

var (mod, yr) = car;
Console.WriteLine($"model: {mod} - year: {yr}");

//int numb = default;
//bool check = default;
//string name = default;

//(numb, check, name) = Foo();

//Console.WriteLine($"numb = {numb}; check = {check}; name = {name};");

//(int number, _, string some) = Foo();
//Console.WriteLine(some);
var returnValues = Foo();
Console.WriteLine(returnValues.Item1); // 697
Console.WriteLine(returnValues.Item2); // true
Console.WriteLine(returnValues.Item3); // Salam



(int, bool, string) Foo()
{
    return (697, true, "Salam");
}

class Car
{
    public string Model { get; set; }
    public int Year { get; set; }
    public Car(string Model, int Year)
    {
        this.Model = Model;
        this.Year = Year;
    }

    public void Deconstruct(out string model, out int year)
    {
        model = Model;
        year = Year;
    }
}