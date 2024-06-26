List<Group> groups = new()
{
    new Group(){ Id=1, Name="FBMS_Nov_23_9_ru", Faculty="Programming"},
    new Group(){ Id=2, Name="FBAS_1_23_3_ru", Faculty="Programming"},
    new Group(){ Id=3, Name="FBEN_1226_az", Faculty="Cybersecurity"},
    new Group(){ Id=4, Name="FBEN_3211_ru", Faculty="Cybersecurity"},
    new Group(){ Id=5, Name="FBEN_1112_ru", Faculty="Design"},
    new Group(){ Id=6, Name="FBAS_1_23_5_az", Faculty="Programming"},
    new Group(){ Id=7, Name="FBEN_1211_ru", Faculty="Design"},
    new Group(){ Id=8, Name="FBES_1227_az", Faculty="Programming"},
    new Group(){ Id=9, Name="FBAS_3_22_2_ru", Faculty="Programming"}
};

List<Student> students = new()
{
new Student { FirstName ="Nikkie",LastName="Gloves",Age=78,GroupId=4},
new Student { FirstName ="Cybill",LastName="Wasmer",Age=75,GroupId=1},
new Student { FirstName ="Gabi",LastName="Peidro",Age=48,GroupId=6},
new Student { FirstName ="Jeffie",LastName="Orthmann",Age=97,GroupId=6},
new Student { FirstName ="Dorree",LastName="Charleston",Age=84,GroupId=2},
new Student { FirstName ="Ludwig",LastName="Fortnam",Age=30,GroupId=5},
new Student { FirstName ="Marijn",LastName="Dowson",Age=31,GroupId=3},
new Student { FirstName ="Peggy",LastName="Kesten",Age=88,GroupId=9},
new Student { FirstName ="Rivkah",LastName="Sterndale",Age=98,GroupId=7},
new Student { FirstName ="Wylma",LastName="Dealey",Age=19,GroupId=5},
new Student { FirstName ="Merrill",LastName="Leipold",Age=59,GroupId=5},
new Student { FirstName ="Malinde",LastName="Dudson",Age=31,GroupId=4},
new Student { FirstName ="Terri",LastName="Sagg",Age=78,GroupId=6},
new Student { FirstName ="Nataniel",LastName="Spoure",Age=83,GroupId=2},
new Student { FirstName ="Mikey",LastName="Haire",Age=53,GroupId=3},
new Student { FirstName ="Serene",LastName="McKillop",Age=100,GroupId=2},
new Student { FirstName ="Creigh",LastName="Kiltie",Age=93,GroupId=9},
new Student { FirstName ="Gaelan",LastName="Petchell",Age=98,GroupId=2},
new Student { FirstName ="Brenna",LastName="Stitfall",Age=43,GroupId=4},
new Student { FirstName ="Sydney",LastName="Runham",Age=34,GroupId=5},
new Student { FirstName ="Garrard",LastName="Burnand",Age=80,GroupId=3},
new Student { FirstName ="Lorraine",LastName="Kitching",Age=22,GroupId=5},
new Student { FirstName ="Sheena",LastName="Newitt",Age=77,GroupId=2},
new Student { FirstName ="Gretal",LastName="Schiementz",Age=74,GroupId=9},
new Student { FirstName ="Ahmed",LastName="Kohrsen",Age=96,GroupId=8},
new Student { FirstName ="Margarita",LastName="Bury",Age=52,GroupId=1},
new Student { FirstName ="Madel",LastName="Schapiro",Age=28,GroupId=5},
new Student { FirstName ="Aprilette",LastName="Shernock",Age=23,GroupId=9},
new Student { FirstName ="Ginger",LastName="Quaife",Age=100,GroupId=7},
new Student { FirstName ="Tallou",LastName="Creese",Age=20,GroupId=7}
};

// LINQ methods

#region First, FirstOrDefault
//var stud = students.First(s => s.Id == 50);

//Console.WriteLine(stud);

//var stud = students.FirstOrDefault(s => s.Id == 3);
//if (stud is not null) Console.WriteLine(stud);
//else Console.WriteLine("Student is not found");

#endregion

#region Single, SingleOrDefault
//var stud = students.Single(s => s.Age == 102);
//Console.WriteLine(stud);

//var stud = students.SingleOrDefault(s => s.Age == 102);
//Console.WriteLine(stud);
#endregion

#region Contains
// Contains
//var student = new Student
//{
//    FirstName = "Nadir",
//    LastName = "Zamanov",
//    Age = 44,
//    GroupId = 1
//};

//students.Add(student);

//var value = students.Contains(student);
//Console.WriteLine(value);
#endregion

#region Where
//var studs = students.Where(s => s.Age > 80);

//foreach (Student s in studs)
//{
//    Console.WriteLine(s);
//}

//var student = new Student
//{
//    FirstName = "Nadir",
//    LastName = "Zamanov",
//    Age = 108,
//    GroupId = 1
//};

//students.Add(student);
//Console.WriteLine();
//foreach (Student s in studs)
//{
//    Console.WriteLine(s);
//}

#endregion

#region Max, Min, Average, Sum

//Console.WriteLine(students.Max(s=> s.Age));
//Console.WriteLine(students.Min(s=> s.Age));
//Console.WriteLine(students.Average(s=> s.Age));
//Console.WriteLine(students.Sum(s=> s.Age));

#endregion

#region OrderBy, OrderByDescending, ThenBy, ThenByDescending
//var stuts = students.OrderBy(s => s.Age).ThenBy(s=>s.FirstName);
//foreach (Student student in stuts)
//{
//    Console.WriteLine(student);
//}
#endregion

#region Take, Skip, TakeLast, SkipLast, SkipWhile, TakeWhile 

#endregion

#region All, Any

#endregion

#region Join, GroupJoin

#endregion

