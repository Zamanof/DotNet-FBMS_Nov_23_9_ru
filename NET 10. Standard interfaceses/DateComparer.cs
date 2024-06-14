using System.Collections;

namespace NET_10._Standard_interfaceses;

internal class DateTimeComparer : IComparer
{
    public int Compare(object? x, object? y)
    {
        return DateTime.Compare((x as Student)!.BirthDate, (y as Student)!.BirthDate);
    }
}
