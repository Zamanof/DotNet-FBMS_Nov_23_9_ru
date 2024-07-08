//Rectangle r = new Rectangle(width: 20, height: 10);
//Console.WriteLine(Calculate.Area(r));
//r.Width = 30;
//Console.WriteLine(Calculate.Area(r));

Square s = new(side: 20);
Console.WriteLine(Calculate.Area(s));
s.Width = 30;
Console.WriteLine(Calculate.Area(s));

#region Liskov Substitution Bad Example
//class Rectangle
//{
//    public double Height { get; set; }
//    public double Width { get; set; }

//    public Rectangle(double width, double heght)
//    {
//        Width = width;
//        Height = heght;
//    }
//}

//class Square: Rectangle
//{
//    public Square(double side) : base(side, side) { }
//}

//class Calculate
//{
//    public static double Area(Rectangle rectangle) => rectangle.Width * rectangle.Height;
//}

#endregion

#region Liskov Substitution Good Example
class Rectangle
{
    public virtual double Width { get; set; }
    public virtual double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }
}

class Square : Rectangle
{
    public override double Width 
    { 
        get => base.Width; 
        set 
        {
            base.Width = value;
            base.Height = value;
        } 
    }

    public override double Height 
    {
        get => base.Height;
        set
        {
            base.Width = value;
            base.Height = value;
        }
    }
    public Square(double side): base(side, side) { }
}

class Calculate
{
    public static double Area(Rectangle rectangle) => rectangle.Width * rectangle.Height;
}
#endregion