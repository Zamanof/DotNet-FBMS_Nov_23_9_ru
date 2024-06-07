// Operator overloading
using System.Collections.Specialized;

Point point1 = new(5, 3);
Point point2 = new(5, 3);
//point1 = -point1;
//Console.WriteLine(point1);
//Console.WriteLine(point1 + point2);
//Console.WriteLine(point1 * -1);
//Console.WriteLine(-1 * point1);

Console.WriteLine(point1.Equals(point2));
Foo foo = new Foo();
foo.
class Foo
{

}
class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
    public Point()
    {
        X = default;
        Y = default;
    }
    public override string ToString()
    {
        return $"X: {X}, Y: {Y}";
    }

    // Unary operators overloading
    // Unray minus
    public static Point operator -(Point point)
    {
        return new(-point.X, -point.Y);
    }

    // Increment
    public static Point operator++(Point point)
    {
        point.X++;
        point.Y++;
        return point;
    }
    // Decrement
    public static Point operator--(Point point)
    {
        point.X--;
        point.Y--;
        return point;
    }

    // Binary operator overloading

    // Binary +
    public static Point operator+(Point left, Point right)
    {
        return new Point
        {
            X = left.X + right.X,
            Y = left.Y + right.Y
        };
    }

    public static Point operator-(Point left, Point right)
    {
        return new Point
        {
            X = left.X - right.X,
            Y = left.Y - right.Y
        };
    }

    public static Point operator*(Point point, int value)
    {
        return new Point
        {
            X = point.X * value,
            Y = point.Y * value
        };
    }
    public static Point operator *(int value, Point point)
    {
        return new Point
        {
            X = point.X * value,
            Y = point.Y * value
        };
    } 
}
