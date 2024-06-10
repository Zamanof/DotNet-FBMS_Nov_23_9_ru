using NET_09._Interfaces.Abstract_classes;
using NET_09._Interfaces.Interfaces;

namespace NET_09._Interfaces.Concrete_classes;

internal class Cat : Animal, IWalk, IThink, ISound
{
    public void Sound()
    {
        Console.WriteLine("Meow, Meow");
    }

    public void Think()
    {
        Console.WriteLine("I think about ball of woll");
    }

    public void Walk()
    {
        Console.WriteLine("I have four legs. And I walk.");
    }
}
