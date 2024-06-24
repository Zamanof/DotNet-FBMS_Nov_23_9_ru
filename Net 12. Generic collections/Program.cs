// Generic collection


// non Generic                          Generic

// ArrayList                            List<T>
// HashTable                            Dictionary<TKey, TValue>
// SortedList                           SortedList<TKey, TValue>
// Stack                                Stack<T>
// Queue                                Queue<T>
//  -                                   LinkedList<T>

// problemi non generic collections ->
//                                    boxing/unboxing (doroqo),
//                                    narushayetsya bezopasnost tipov (typecast na vsyo chto uqodno)

using System.Collections;

Random random = new Random();
//ArrayList arrayList = new ArrayList();
//arrayList.Add(25);
////Console.WriteLine((int)arrayList[0]! + 5);
//Console.WriteLine(arrayList[0].GetType());

List<int> list = new List<int>();
for (int i = 0;i < 15; i++)
{
    list.Add(random.Next(10, 90));
}

Console.WriteLine();
for (int i = 0; i < list.Count; i++)
{
    Console.Write($"{list[i] * 10} ");
}

