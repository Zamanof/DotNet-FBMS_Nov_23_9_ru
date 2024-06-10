using Net_09._Interface_example;

FrontEndDeveloper frontEndDeveloper = new FrontEndDeveloper
{
    FirstName = "Maksim",
    LastName = "Medvedev"
};

BackEndDeveloper backEndDeveloper = new BackEndDeveloper
{
    FirstName = "Rashad",
    LastName = "Sadiqov"
};

FullSatackDeveloper fullSatackDeveloper = new FullSatackDeveloper
{
    FirstName = "Gurban",
    LastName = "Gurbanov"
};

FrontEndDeveloperAnnouncement(frontEndDeveloper);
Console.WriteLine();
BackEndDeveloperAnnouncement(backEndDeveloper, new string[] {"C#", "Python", "PHP"});
Console.WriteLine();
FullStackDeveloperAnnouncement(fullSatackDeveloper, new string[] { "C#", "Python", "PHP", "C++", "NodeJs" });
Console.WriteLine();
BackEndDeveloperAnnouncement(fullSatackDeveloper, new string[] { "C#", "Python", "PHP" });
Console.WriteLine();
FrontEndDeveloperAnnouncement(fullSatackDeveloper);

void BackEndDeveloperAnnouncement(IBackEndDevelop developer, string[] languages)
{
    Console.WriteLine($"I am {(developer as Human)!.FirstName} " +
        $"{(developer as Human)!.LastName}");
    developer.KnowBackEndLanguage(languages);
}


void FrontEndDeveloperAnnouncement(IFrontEndDevelop developer)
{
    Console.WriteLine($"I am {(developer as Human)!.FirstName} " +
        $"{(developer as Human)!.LastName}");
    developer.KnowHTML();
    developer.KnowCSS();
    developer.KnowJS();

}

void FullStackDeveloperAnnouncement(IFullStackDevelop developer, string[] langauges)
{
    Console.WriteLine($"I am {(developer as Human)!.FirstName} " +
        $"{(developer as Human)!.LastName}");
    developer.KnowHTML();
    developer.KnowCSS();
    developer.KnowJS();
    developer.KnowBackEndLanguage(langauges);
}
