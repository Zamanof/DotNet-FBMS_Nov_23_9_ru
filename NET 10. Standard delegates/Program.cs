// Action<T>, Func<T>, Predicate<T>, Comparison<T>

List<int> numbers = new List<int> { 25, -36, 55, 84, 13, 159, 2, 33, -121 };

#region Action
//int[] arr = new int[25];
//Random rnd = new Random();
//for (int i = 0; i < arr.Length; i++)
//{
//    arr[i] = rnd.Next(10, 99);
//}

//foreach (int i in arr)
//{
//    Console.Write($"{i} ");
//}
//Console.WriteLine();
//Operations(arr, ShowSquare);
//Console.WriteLine();
//Operations(arr, ShowNegative);
//Console.WriteLine();
//Action<int, double> action = Foo;
//action.Invoke(5, 36.2);
//void Operations(int[] ints, Action<int> action)
//{
//    foreach (int i in ints)
//    { 
//        action(i); 
//    }
//    Console.WriteLine();
//}

//void ShowSquare(int number)
//{
//    Console.Write($"{number * number} ");
//}

//void ShowNegative(int number)
//{
//    Console.Write($"{-number} ");
//}

//void Foo(int a, double b)
//{
//    Console.WriteLine(a*b);
//}
#endregion

#region Func
//Func<int, int, int> func = Add;
//Console.WriteLine(func(25, 4));

//Func<int, float, double> func1 = SomeMethod;
//Console.WriteLine(func1(25, 66.63f));
//int Add(int a, int b)
//{
//    return a + b;
//}

//double SomeMethod(int a, float b)
//{
//    return a*b;
//}
#endregion

#region Predicate

//Predicate<int> predicate = IsPositive;

//ShowPrimeNumbers(numbers, IsPrime);
//ShowPrimeNumbers(numbers, IsPositive);


//void ShowPrimeNumbers(List<int> ints, Predicate<int> predicate)
//{
//    foreach (int i in ints)
//    {
//        if (predicate(i))
//        {
//            Console.Write($"{i} ");
//        }
//    }
//    Console.WriteLine();
//}

//bool IsPositive(int a)
//{
//    return a > 0 ? true : false;
//}

//bool IsPrime(int a)
//{
//    for (int i = 2; i < a/2; i++)
//    {
//        if (a % i == 0) return false;
//    }
//    return true;
//}
#endregion

#region Comparison

List<Human> humans = new List<Human> 
{ 
    new Human{Name="Cabir", Age=19},
    new Human{Name="Ismail A.", Age=15},
    new Human{Name="Sevda", Age=18},
    new Human{Name="Kerim", Age=18},
    new Human{Name="Ismail Q.", Age=18},
    new Human{Name="Eteri", Age=19},
    new Human{Name="Yusif", Age=19},
    new Human{Name="Hamida", Age=18},
    new Human{Name="Ramzi", Age=19},
    new Human{Name="Nadir", Age=44}


};


humans.Sort(CompareAge);

//humans.Sort(CompareName);

foreach (Human human in humans)
{
    Console.WriteLine(human.ToString());
}


int CompareAge(Human left, Human right)
{
   if (left.Age < right.Age) return -1;
   else if (left.Age > right.Age) return 1;
   else return 0;
}
int CompareName(Human left, Human right)
{
     return string.Compare(left.Name, right.Name);
}

class Human
{
    public string Name { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return $"{Name} -  {Age}";
    }
}

#endregion

