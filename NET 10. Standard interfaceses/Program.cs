// Standard interfaces

using NET_10._Standard_interfaceses;

//Auditory auditory = new();

//foreach (Student student in auditory)
//{
//    Console.WriteLine(student);
//}

//Console.WriteLine("After FirstName sorting:");
//auditory.Sort();

//foreach (Student student in auditory)
//{
//    Console.WriteLine(student);
//}

//Console.WriteLine();
//Console.WriteLine("After LastName sorting:");
//auditory.Sort(new LastNameComparer());



//foreach (Student student in auditory)
//{
//    Console.WriteLine(student);
//}

//Console.WriteLine();
//Console.WriteLine("After BirthDay sorting:");
//auditory.Sort(new DateTimeComparer());



//foreach (Student student in auditory)
//{
//    Console.WriteLine(student);
//}

//Console.WriteLine();
//Console.WriteLine("After Student Id sorting:");
//auditory.Sort(new StudentIdComparer());



//foreach (Student student in auditory)
//{
//    Console.WriteLine(student);
//}

Student student = new Student{
            FirstName="Cabir",
            LastName = "Sultanov",
            Email = "Sultanov@gmail.com",
            BirthDate = new DateTime(2005, 3, 31),
            StudentCard = new StudentCard { Series = "CS", Id = 123456 } };

Student student1 = student.Clone() as Student;
//Console.WriteLine(student);
//Console.WriteLine();
//Console.WriteLine(student1);
student1.FirstName = "Sabir";
student.StudentCard.Series = "SS";

Console.WriteLine();
Console.WriteLine(student);
Console.WriteLine();
Console.WriteLine(student1);

