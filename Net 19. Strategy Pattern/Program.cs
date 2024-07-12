// Strategy

// Dependency Inversion principle
#region Serialize example
//SerializeStrategy serializeStrategy = new SerializeStrategy(new NadirZamanovStyleSamiySuperSerialer());
//serializeStrategy.Serialize();
//serializeStrategy.Deserialize();



//interface ISerialize
//{
//    void Serialize();
//    void Deserialize();
//}

//class JsonSerializer : ISerialize
//{
//    public void Deserialize()
//    {
//        Console.WriteLine("Json Deserialize");
//    }

//    public void Serialize()
//    {
//        Console.WriteLine("Json Serialize");
//    }
//}

//class XmlSerializer : ISerialize
//{
//    public void Deserialize()
//    {
//        Console.WriteLine("Xml Deserialize");
//    }

//    public void Serialize()
//    {
//        Console.WriteLine("Xml Serialize");
//    }
//}

//class BinarySerializer : ISerialize
//{
//    public void Deserialize()
//    {
//        Console.WriteLine("Binary Deserialize");
//    }

//    public void Serialize()
//    {
//        Console.WriteLine("Binary Serialize");
//    }
//}

//class NadirZamanovStyleSamiySuperSerialer : ISerialize
//{
//    public void Deserialize()
//    {
//        Console.WriteLine("NZ SUPPER PUPPER MUPPER  Deserialize");
//    }

//    public void Serialize()
//    {
//        Console.WriteLine("NZ SUPPER PUPPER MUPPER  Serialize");
//    }
//}

//class SerializeStrategy
//{
//    private readonly ISerialize _serializer;

//    public SerializeStrategy(ISerialize serializer)
//    {
//        _serializer = serializer;
//    }
//    public void Serialize()
//    {
//        _serializer.Serialize();
//    }

//    public void Deserialize()
//    {
//        _serializer.Deserialize();
//    }
//}
#endregion

#region Sorting Example
//List<int> ints = [3, 76, 3, 12, -9, -13, 15, 16];
//ints.Sort();

//Sorting sorting1 = new Sorting(new InsertionSort());
//var lst = sorting1.Sort(ints);
//lst.ForEach(x => Console.WriteLine(x));

//interface ISorting<T>
//{
//    List<T> Sort(List<T> collection);
//}
//class BubbleSort: ISorting<int>
//{
//    public List<int> Sort(List<int> collection)
//    {
//        var n = collection.Count;
//        for (int i = 0; i < n - 1; i++)
//            for (int j = 0; j < n - i - 1; j++)
//                if (collection[j] > collection[j + 1])
//                {
//                    var tempVar = collection[j];
//                    collection[j] = collection[j + 1];
//                    collection[j + 1] = tempVar;
//                }
//        return collection;
//    }
//}

//class InsertionSort: ISorting<int>
//{
//    public List<int> Sort(List<int> collection)
//    {
//        for (int i = 1; i < collection.Count; i++)
//        {
//            var key = collection[i];
//            var flag = 0;
//            for (int j = i - 1; j >= 0 && flag != 1;)
//            {
//                if (key < collection[j])
//                {
//                    collection[j + 1] = collection[j];
//                    j--;
//                    collection[j + 1] = key;
//                }
//                else flag = 1;
//            }
//        }
//        return collection;
//    }
//}

//class SelectionSort: ISorting<int>
//{
//    public List<int> Sort(List<int> collection)
//    {
//        var arrayLength = collection.Count;
//        for (int i = 0; i < arrayLength - 1; i++)
//        {
//            var smallestVal = i;
//            for (int j = i + 1; j < arrayLength; j++)
//            {
//                if (collection[j] < collection[smallestVal])
//                {
//                    smallestVal = j;
//                }
//            }
//            var tempVar = collection[smallestVal];
//            collection[smallestVal] = collection[i];
//            collection[i] = tempVar;
//        }
//        return collection;
//    }
//}



//class Sorting
//{
//    private ISorting<int> _sorting;

//    public Sorting(ISorting<int> sorting)
//    {
//        _sorting = sorting;
//    }
//    public List<int> Sort(List<int> collection)
//    {
//        return _sorting.Sort(collection);
//    }
//}
#endregion



