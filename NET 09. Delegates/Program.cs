// delegates

// delegate return_datatype delegate_name(list of parameters);

// C++ pointer to function -> int (*funcCalc)(int, int);
//public delegate int MyIntDelegate(int left, int right);

#region delegates

double numb1 = default, numb2 = default;

Console.WriteLine("Enter first number: ");
double.TryParse(Console.ReadLine(), out numb1);

Console.WriteLine("Enter second number: ");
double.TryParse(Console.ReadLine(), out numb2);

char operation = default;
Console.WriteLine("Choice operation: +, -, *, /");
char.TryParse(Console.ReadLine(), out operation);

CalculatorDelegate calculatorDelegate = null;

switch ((operators)operation)
{
	case operators.ADD:
		calculatorDelegate = Add;
		break;
	case operators.SUBTRACT:
        calculatorDelegate = Subtract;
        break;
	case operators.MULTIPLE:
		calculatorDelegate = Multiple;
		break;
	case operators.DIVIDE:
		calculatorDelegate = Divide;
		break;
	default:
		break;
}

//if (calculatorDelegate is not null)
//{
//    Console.WriteLine(calculatorDelegate(numb1, numb2));
//}

if (calculatorDelegate is not null)
{
    Console.WriteLine(calculatorDelegate.Invoke(numb1, numb2));
}

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

public delegate double CalculatorDelegate(double left, double right);

enum operators { ADD='+', SUBTRACT='-', MULTIPLE='*', DIVIDE='/'};
#endregion
