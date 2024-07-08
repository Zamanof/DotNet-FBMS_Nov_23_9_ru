// Attributes

using Net_16._Atributes;

//foreach (var attr in typeof(Book).GetCustomAttributes(true))
//{
//    Console.WriteLine(attr);
//}

foreach (var item in typeof(Book).GetMembers())
{
	foreach (var attr in item.GetCustomAttributes(true))
	{
        Console.WriteLine(attr);
    }
}