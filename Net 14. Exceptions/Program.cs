// Exceptions
using Net_14._Exceptions;

int numb1 = 3;
int numb2 = 0;
int result = default;
// Vse isklyucheniya nasleduyutsya ot bazovoq klassa Exception
// Ot Exception nasleduyutsya 2 klassa : SystemException, ApplicationException

try
{
    //result = numb1 / numb2;
    Foo(3, 0);

}
catch (DivideByZeroException ex)
{
    //Console.WriteLine(ex.Message);
    //Console.WriteLine(ex.StackTrace);
    Console.WriteLine("Deleniya na nol eto ujasno! fooo!");
}
catch(MyException ex)
{
    Console.WriteLine("Own exception handled");
}

// exception filters
catch(Exception ex) when(ex.InnerException != null)
{

}

finally
{
    Console.WriteLine("Block Finally");
}

Console.WriteLine("End of code");

int Foo(int a, int b)
{
    int result = default;
    int[] arr = new int[3] { 25, 78, 9};

    try
	{
		result = a / b;
        //Console.WriteLine(arr[5]);
    }
	catch (DivideByZeroException ex)
	{
        Console.WriteLine("Catch in method Foo");
        //throw new Exception("Hakuna matata");
        throw new MyException("This is Spartaaaaaaaaaaaaaaa!");

	}
    return result;
}