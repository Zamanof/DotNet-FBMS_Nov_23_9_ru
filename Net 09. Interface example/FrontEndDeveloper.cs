namespace Net_09._Interface_example;

internal class FrontEndDeveloper : Human, IFrontEndDevelop
{
    public void KnowCSS()
    {
        Console.WriteLine("I Know CSS");
    }

    public void KnowHTML()
    {
        Console.WriteLine("I Know HTML");
    }

    public void KnowJS()
    {
        Console.WriteLine("I Know JavaScript");
    }
}
