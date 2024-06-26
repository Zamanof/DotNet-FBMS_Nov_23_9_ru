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
new Student { FirstName ="Marijn",LastName="Dowson",Age=21,GroupId=3},
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


var result = from g in groups
             join s in students on g.Id equals s.GroupId
             orderby s.FirstName
             select new
             {
                 Firstname = s.FirstName,
                 Lastname = s.LastName,
                 Age = s.Age,
                 GroupName = g.Name
             };

//foreach (var stud in result)
//{
//    Console.WriteLine($"{stud.Firstname} {stud.Lastname} {stud.Age} - {stud.GroupName}");
//}

//Console.WriteLine();

var resultByGroup = from r in result
                    group r by r.GroupName;

foreach (var group in resultByGroup)
{
    Console.WriteLine(group.Key);
    foreach (var stud in group)
    {
        Console.WriteLine($"    {stud.Firstname} {stud.Lastname} {stud.Age} - {stud.GroupName}");
    }
}
class Group
{
    public uint Id { get; set; }
    public string? Name { get; set; }
    public string? Faculty { get; set; }

    public override string ToString()
    {
        return $"{Id}. {Name} - {Faculty}";
    }
}

class Student
{
    public uint Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public byte Age { get; set; }
    public uint GroupId { get; set; }
    static uint count = 1;
    public Student() { Id = count++; }

    public override string ToString()
    {
        return $"{Id}. {FirstName} {LastName} - {Age} - {GroupId}";
    }

}
