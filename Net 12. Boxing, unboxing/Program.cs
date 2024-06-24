// Value type vs Reference type
// 1. Value type -> struct; Reference type -> class;
// 2. Memory: Value type -> stack; Reference type -> heap;
// 3. Sravnivaniye: Value type -> value; Reference type -> reference;
// 4. Copy: Value type -> value; Reference type -> reference;
// 5. Delete: Value type -> znacheniye prosto iz steka ochishayetsay; Reference type -> srabativayet sborshik musora;


// boxing unboxing

object obj = 2; // boxing
Console.WriteLine($"Boxing - {obj}");

int number = (int)obj; // unboxing
Console.WriteLine($"Unboxing - {number}");
// proses boxing/unboxing yavlyayetsya doroqim prosesom
SomeMethod(obj);
SomeMethod(5);
SomeMethod("Salam");
SomeMethod(2.653);
SomeMethod(1.2f);

void SomeMethod(object value)
{
    Console.WriteLine(value);
}





