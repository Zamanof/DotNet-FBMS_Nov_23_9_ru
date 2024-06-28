// extension methods

//string word = "Lorem Ipsum Dolor Sit Amet";
//Console.WriteLine(word.CountWords()); 
//Console.WriteLine(word.CountSpaces()); 
//Console.WriteLine(word.CountVowels()); 


Console.WriteLine("1265".StringToInt() + 25);
Console.WriteLine(Console.ReadLine()!.StringToInt() + 13);
static class StringExtension 
{
    public static int CountWords(this string str)
    {
        if(string.IsNullOrEmpty(str)) return 0;
        return str.Split(' ').Length;
    }

    public static int CountSpaces(this string str)
    {
        if (string.IsNullOrEmpty(str)) return 0;
        return str.Count(s => s == ' ');
    }

    public static int CountVowels(this string str)
    {
        if (string.IsNullOrEmpty(str)) return 0;
        return str.ToLower().Count(s => s == 'a' || s=='i'|| s =='u' || s=='e' || s=='o');
    }

    public static int StringToInt(this string str)
    {
        int number = default;
        if (string.IsNullOrEmpty(str))
        {
            throw new Exception("String empty");
        }
        else if(!str.All(s=> s>='0' && s <= '9'))
        {
            throw new Exception("Not all symbols are numeric");
        }
        else
        {
            number = int.Parse(str);
        }
        return number;
    }
}
