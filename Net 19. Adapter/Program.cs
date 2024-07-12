List<IAudioFile> musicPlaylist = new List<IAudioFile> ();
musicPlaylist.Add(new Mp3());
musicPlaylist.Add(new Mp3());
musicPlaylist.Add(new FLAC());
musicPlaylist.Add(new Wav());
musicPlaylist.Add(new Mp3());
musicPlaylist.Add(new OggMp3Adapter());

musicPlaylist.ForEach(x => x.Play());


interface IAudioFile
{
    void Play();
}

class Mp3 : IAudioFile
{
    public void Play()
    {
        Console.WriteLine("MP3 is playing");
    }
}

class Wav : IAudioFile
{
    public void Play()
    {
        Console.WriteLine("Wav is playing");
    }
}

class FLAC : IAudioFile
{
    public void Play()
    {
        Console.WriteLine("FLAC is playing");
    }
}

// Nuget
class Ogg
{
    public void PlaySomethingInteresting(bool repeat)
    {
        Console.WriteLine("DU!!!");
        Console.WriteLine("DU HAST!!!");
    }
}

//// Object Adapter
//class OggMp3Adapter : IAudioFile
//{
//    public Ogg Ogg { get; set; } = new Ogg();
//    public void Play()
//    {
//        // Convert
//        Ogg.PlaySomethingInteresting(true);
//    }
//}

// Class Adapter
class OggMp3Adapter : Ogg, IAudioFile
{
    
    public void Play()
    {
        // Convert
        this.PlaySomethingInteresting(true);
    }
}
