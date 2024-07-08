using Net_15._Serialization;
using System.Xml.Serialization;

Book book = new Book()
{
    Author = new Author("Joseph", "Albahari"),
    Title = "C# 12 in Nutshell",
    Description = "Full guide for C# language",
    Price = 37.99
};

List<Book> books = new List<Book>() {
    book,
    new Book() {
    Author = new Author("Jeffrey", "Richter"),
    Title = "C# via CLR",
    Description = "Best of best of the best book about .NET, CLR, C#",
    Price = 41.13
}
};


#region XML Serialization
XmlSerializer serializer = new XmlSerializer(typeof(Book));
//using (FileStream fileStream = new("book.xml", FileMode.OpenOrCreate))
//{
//    serializer.Serialize(fileStream, book);
//}

//using (FileStream fileStream = new("book.xml", FileMode.Open))
//{
//    var result = serializer.Deserialize(fileStream) as Book;
//    Console.WriteLine(result);
//    Console.WriteLine(result.Description);
//}


serializer = new XmlSerializer(typeof(List<Book>));
//using (FileStream fileStream = new("books.xml", FileMode.OpenOrCreate))
//{
//    serializer.Serialize(fileStream, books);
//}

//using (FileStream fileStream = new("books.xml", FileMode.Open))
//{
//    var result = serializer.Deserialize(fileStream) as List<Book>;
//    foreach (var b in result!)
//    {
//        Console.WriteLine(b);
//        Console.WriteLine();
//    }
//}

#endregion

#region JSON Serialization


#endregion
