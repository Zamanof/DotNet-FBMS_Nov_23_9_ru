// LINQ - Language Integrated Query

// LINQ To Objects
// LINQ To Dataset
// LINQ To SQL
// LINQ To XML
// LINQ To Entities
// PLINQ - Paralel LINQ

int[] arr = { 1, 32, -45, 44, 78, 45, 111, 112, 53, -5, -3, 31, -31, 684, -25 };

// LINQ zapros schitayetsya otlojennim zaprosom
IEnumerable<int> query = null;
#region from select
query = from i in arr select i;
//ShowArray(query);


//arr[5] = 1;

//ShowArray(query);
#endregion

#region where
//query = from i in arr
//        where i < 0
//        select i;

#endregion

#region orderby ascending descending
//query = from i in arr
//        where i % 2 != 0
//        orderby i descending
//        select i;
#endregion

#region group by
//var group = from i in arr
//            where i > 0
//            group i by i % 10;

//foreach (var item in group)
//{
//    Console.WriteLine(item.Key);
//    foreach (var value in item)
//    {
//        Console.WriteLine($"    {value}");
//    }
//}
#endregion

#region into
//var query_into = from i in arr
//                 where i > 0
//                 group i by i % 2 into result
//                 from j in result
//                 where j % 3 == 0
//                 group j by j % 10;
//foreach (var item in query_into)
//{
//    Console.WriteLine(item.Key);
//    foreach (var value in item)
//    {
//        Console.WriteLine($"    {value}");
//    }
//}
#endregion

ShowArray(query);
Console.WriteLine();
void ShowArray(IEnumerable<int> ints)
{
    foreach (int item in ints)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}