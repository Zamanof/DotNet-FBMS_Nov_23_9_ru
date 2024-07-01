// StreamWriter, StreamReader

using System.Text;

string text = "Lorem ipsum sit dolor amet";

//using (FileStream file = new FileStream("file.txt", FileMode.Create))
//{
//	using (StreamWriter streamWriter = new StreamWriter(file, Encoding.Unicode))
//	{
//		foreach (char symbol in text)
//		{
//			streamWriter.Write($"{symbol} ");
//		}
//	}
//}


//using (FileStream file = new FileStream("file.txt", FileMode.Open))
//{
//	using (StreamReader streamReader = new(file, Encoding.Unicode))
//	{
//		string line = streamReader.ReadToEnd();
//        Console.WriteLine(line);
//    }
//}