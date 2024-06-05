// ?. - null conditional
// ?? - null coalesing
// !  - null forgiving
// Nullable type

#region ?. - null conditional
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/member-access-operators

//string name = "SALAM";


//if (name != null)
//{
//    name = name.ToLower();
//    Console.WriteLine(name);
//}

//if (name is not null)
//{
//    name = name.ToLower();
//    Console.WriteLine(name);
//}

// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-forgiving
//name = name?.ToLower()!;
//Console.WriteLine(name);

#endregion

#region ?? - null coalesing
// https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/null-coalescing-operator
//string str = "Salam";

//if (str is null)
//{
//    str = "Empty";
//}

//Console.WriteLine(str);
// ?:

//string str1 = str == null ? "Empty" : str;
//Console.WriteLine(str1);

//string str2 = str ?? "Empty";
//Console.WriteLine(str2);
#endregion

#region Nullable type
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/nullable-value-types
//int? age = null;
//Nullable<int> id = null;

//int? databaseCodeValue = 36;
//int? code = databaseCodeValue;
//Console.WriteLine(code + 25);
#endregion
