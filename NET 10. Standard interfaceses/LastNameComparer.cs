using System.Collections;

namespace NET_10._Standard_interfaceses;

internal class LastNameComparer : IComparer
{
    public int Compare(object? x, object? y)
    {
        return string.Compare((x as Student)!.LastName, (y as Student)!.LastName);
    }
}
