using System.Text;

string path = "file.bin";
//string text = Console.ReadLine();
//WriteToFile(path, text);
//Console.WriteLine(ReadFromFile(path));
void WriteToFile(string path, string text)
{
    using(FileStream file = new FileStream(path, FileMode.Create))
    {
        byte[] bytes = Encoding.Default.GetBytes(text);
        file.Write(bytes, 0, bytes.Length);
    }
}

string ReadFromFile(string path)
{
    using (FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
    {
        byte[] bytes = new byte[(int)file.Length];
        file.Read(bytes, 0, bytes.Length);
        return Encoding.Default.GetString(bytes);
    }
}