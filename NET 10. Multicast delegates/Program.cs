// Multicast delegate

double numb1 = 15, numb2 = 22;

CalculatorDelegate calculators = Add;

calculators += Subtract;
calculators += Divide;
calculators += Multiple;

//foreach (CalculatorDelegate calculator in calculators.GetInvocationList())
//{
//    Console.WriteLine(calculator(numb1, numb2));
//}

GenericCalcDelegate<double> genericCalcDelegate = Add;
GenericCalcDelegate<int> genericCalcDelegate1 = Foo;

//Console.WriteLine(genericCalcDelegate1(25, 2)); 

//Console.WriteLine(genericCalcDelegate(numb1, numb2)); 

//SomeMethod(2, 63.9, Add);
//SomeMethod(2, 63.9, Subtract);

var delegates = calculators.GetInvocationList();
Console.WriteLine(delegates[0].Method);
Console.WriteLine(delegates[0].DynamicInvoke(2, 35));
double Divide(double left, double right)
{
    if (right != 0) return left / right;
    throw new DivideByZeroException();
}

double Multiple(double left, double right)
{
    return left * right;
}

double Subtract(double left, double right)
{
    return left - right;
}

double Add(double left, double right)
{
    return left + right;
}

int Foo(int numb1, int numb2)
{
    return numb1 % numb2;
}

void SomeMethod(double left, double right, CalculatorDelegate calculatorDelegate) 
{
    Console.WriteLine(calculatorDelegate(left, right));
}

public delegate double CalculatorDelegate(double left, double right);
public delegate T GenericCalcDelegate<T> (T left, T right);