using NET_10._Standard_interfaceses;
using System.Collections;

internal class Auditory: IEnumerable
{
    Student[] students =
    {
        new Student{
            FirstName="Cabir", 
            LastName="Sultanov", 
            Email="Sultanov@gmail.com", 
            BirthDate=new DateTime(2005, 3, 31), 
            StudentCard = new StudentCard{ Series="CS", Id=123456} },
        new Student{
            FirstName="Ismail",
            LastName="Abbasbeyli",
            Email="Abbasbeyli@gmail.com",
            BirthDate=new DateTime(2009, 5, 4),
            StudentCard = new StudentCard{ Series="AI", Id=256414} },
        new Student{
            FirstName="Napoleon",
            LastName="Buonoparte",
            Email="napoleon@empire.fr",
            BirthDate=new DateTime(1769, 8, 15),
            StudentCard = new StudentCard{ Series="AA", Id=135487} },
        new Student{
            FirstName="Gaius Julius",
            LastName="Caesar",
            Email="AveCaesar@empire.rm",
            BirthDate=new DateTime(100, 7, 12),
            StudentCard = new StudentCard{ Series="GS", Id=444444} },
        new Student{
            FirstName="SpongeBob",
            LastName="SquarePants",
            Email="SpongeBob@SquarePants.ocean",
            BirthDate=new DateTime(1986, 7, 16),
            StudentCard = new StudentCard{ Series="SB", Id=795112} },

    };

    public IEnumerator GetEnumerator()
    {
        return students.GetEnumerator();
    }

    public void Sort()
    {
        Array.Sort(students);
    }

    public void Sort(IComparer comparer)
    {
        Array.Sort(students, comparer);
    }
}
