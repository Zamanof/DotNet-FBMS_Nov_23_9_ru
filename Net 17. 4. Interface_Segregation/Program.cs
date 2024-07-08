#region Interface Segragation bad example
//abstract class Animal
//{
//    public abstract void Feed();
//    public abstract void Groom();
//}

//class Dog : Animal
//{
//    public override void Feed()
//    {
//        Console.WriteLine("Dog feed");
//    }

//    public override void Groom()
//    {
//        Console.WriteLine("Dog groom");
//    }
//}

//class Tiger : Animal
//{
//    public override void Feed()
//    {
//        Console.WriteLine("Tiger feed");
//    }

//    public override void Groom()
//    {
//        Console.WriteLine("Tiger grrom");
//    }
//}

#endregion

#region Interface Segragation Good example
abstract class Animal
{
    public abstract void Feed();
}

interface IGroom
{
    void Groom();
}

class Dog : Animal, IGroom
{
    public override void Feed()
    {
        Console.WriteLine("Dog feed");
    }

    public  void Groom()
    {
        Console.WriteLine("Dog groom");
    }
}

class Tiger : Animal, IGroom
{
    public override void Feed()
    {
        Console.WriteLine("Tiger feed");
    }

    public void Groom()
    {
        Console.WriteLine("Tiger grrom");
    }
}

#endregion