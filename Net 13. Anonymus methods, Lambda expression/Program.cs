// Anonimniye metodi i lambda expression

List<int> ints = new() { 1, 32, -45, 44, 78, 45, 111, 112, 53, -5, -3, 31, -31, 684, -25 };
// Anonimniye methodi - delegate(parametrs){ return value; }
var anonymusMethod = delegate (int n) { return n % 2 == 0; };
// lambda expression - (parametrs) => return value
var lambda = (int n) => n % 2 == 0;

//var evens = from i in ints
//            where lambda(i)
//            select i;

//foreach (var item in evens)
//{
//    Console.Write($"{item} ");
//}
//Console.WriteLine();

var result = Filter(ints, (n) =>
{
    if (n < 0) return false;
    for (int i = 2; i < n / 2; i++)
    {
        if (n % i == 0) return false;
    }
    return true;
}
);

foreach (var i in result)
{
    Console.Write($"{i} ");
}
Console.WriteLine();

IEnumerable<int> Filter(List<int> ints, Predicate<int> predicate)
{
    var tmp = new List<int>();
    foreach (var item in ints)
    {
        if (predicate(item)) tmp.Add(item);
    }
    return tmp;
}

//bool IsEven(int n) => n % 2 == 0;
//bool IsOdd(int n) => n % 2 != 0;
//bool IsNegative(int n) => n < 0;

