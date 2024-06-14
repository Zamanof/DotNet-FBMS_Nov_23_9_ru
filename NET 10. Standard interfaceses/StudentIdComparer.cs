using System.Collections;

namespace NET_10._Standard_interfaceses;

internal class StudentIdComparer : IComparer
{
    public int Compare(object? x, object? y)
    {
        return string.Compare((x as Student)!.StudentCard!.ToString(), (y as Student)!.StudentCard!.ToString());
    }
}
