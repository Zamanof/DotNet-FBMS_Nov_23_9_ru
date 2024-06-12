// Standard interfaces

using NET_10._Standard_interfaceses;

Auditory auditory = new();

foreach (Student student in auditory)
{
    Console.WriteLine(student);
}

Console.WriteLine("After FirstName sorting:");
auditory.Sort();

foreach (Student student in auditory)
{
    Console.WriteLine(student);
}

Console.WriteLine("After LastName sorting:");
auditory.Sort(new LastNameComparer());

foreach (Student student in auditory)
{
    Console.WriteLine(student);
}
