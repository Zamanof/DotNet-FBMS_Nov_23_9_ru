// yield return, yield break

List<int> ints = new List<int> { 14, 22, 543 };

//for (int i = 0; i < ints.Count; i++)
//{
//    Console.WriteLine(ints[i]);
//}

//foreach (int i in ints)
//{
//    Console.WriteLine(i);
//}

//Collection collection = new();
//foreach (int item in collection)
//{
//    Console.WriteLine(item);
//}

//var helloStrings = GetResult();
//while (helloStrings.MoveNext())
//{
//    Console.WriteLine(helloStrings.Current);
//}
//helloStrings.MoveNext();
//Console.WriteLine(helloStrings.Current);
//helloStrings.MoveNext();
//Console.WriteLine(helloStrings.Current);

//foreach (var i in MyRange(5))
//{
//    Console.Write($"{i} ");
//}

//foreach (int i in MyRange(ints.Count))
//{
//    Console.WriteLine(ints[i]);
//}

foreach (var i in MyRange(3, 15, 3))
{
    Console.Write($"{i} ");
}

IEnumerator<string> GetResult()
{
    yield return "Salam";
    yield return "Hi";
    yield return "Goodbye";
    yield return "Hello";
    yield return "Aloha";
}


IEnumerable<int> MyRange(int start, int? end = null, int step = 1)
{
    if (start > end && step > 0)
        yield break;
    if (end == null)
    {
        end = start;
        start = 0;
    }
    if (step > 0)
    {
        for (int i = start; i < end; i += step)
        {
            yield return i;
        }
    }
    else
    {
        for (int i = start; i > end; i += step)
        {
            yield return i;
        }
    }

}

class Collection
{
    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < 10; i++)
        {
            yield return i * 2;
        }
    }
}