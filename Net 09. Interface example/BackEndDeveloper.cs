namespace Net_09._Interface_example;

internal class BackEndDeveloper : Human, IBackEndDevelop
{
    public void KnowBackEndLanguage(string[] langauges)
    {
        Console.WriteLine("I know:");
        foreach (var langauge in langauges)
        {
            Console.WriteLine($"\t - {langauge}");
        }
    }
}
