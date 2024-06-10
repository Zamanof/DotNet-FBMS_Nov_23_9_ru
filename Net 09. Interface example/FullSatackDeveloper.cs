namespace Net_09._Interface_example;

internal class FullSatackDeveloper : Human, IFullStackDevelop
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
    public void KnowBackEndLanguage(string[] langauges)
    {
        Console.WriteLine("I know:");
        foreach (var langauge in langauges)
        {
            Console.WriteLine($"\t - {langauge}");
        }
    }
}
