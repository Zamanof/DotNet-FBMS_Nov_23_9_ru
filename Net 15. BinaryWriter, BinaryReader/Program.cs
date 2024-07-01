// BinaryWriter, BinaryReader

using System.Text;

string path = "file.dat";

string text = "Lorem Ipsum dolor sit amet";
int number = 26431;
double temperature = 36.6;

//using (FileStream file = new(path, FileMode.Create))
//{
//    using(BinaryWriter binaryWriter = new(file, Encoding.Unicode))
//    {
//        binaryWriter.Write(text);
//        binaryWriter.Write(number);
//        binaryWriter.Write(temperature);
//    }
//}

using(FileStream file = new(path, FileMode.Open))
{
	using (BinaryReader binaryReader = new(file, Encoding.Unicode))
	{
        Console.WriteLine(binaryReader.ReadString());
        Console.WriteLine(binaryReader.ReadInt32());
        Console.WriteLine(binaryReader.ReadDouble());
    }
}


