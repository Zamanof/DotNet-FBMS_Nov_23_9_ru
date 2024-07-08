#region Open/Closed Bad Example
//object[] shapes = new object[]
//{
//    new Rectangle(){Height = 15, Width = 23},
//    new Circle(){Radius=21.3},
//    new Triangle(){Height = 48.3}
//};

//Calculate calculate = new Calculate();
//Console.WriteLine(calculate.Areas(shapes));
//class Rectangle
//{
//    public double Width { get; set; }
//    public double Height { get; set; }
//}

//class Circle
//{
//    public double Radius { get; set; }
//}

//class Triangle
//{
//    // some fields
//    public double Height { get; set; }
//}

//class Calculate
//{
//    public double Areas(object[] Shapes)
//    {
//        double areas = 0;
//        foreach (object item in Shapes)
//        {
//            if (item is Rectangle rectangle)
//            {
//                areas += rectangle.Width * rectangle.Height;
//            }
//            else if (item is Circle circle)
//            {
//                areas += Math.Pow(circle.Radius, 2) * Math.PI;
//            }
//            else if (item is Triangle triangle)
//            {
//                areas += triangle.Height * 15 / 25 - 3;
//            }
//        }
//        return areas;
//    }
//}
#endregion

#region Open/Closed Good Example

//Shape[] shapes = new Shape[]
//{
//    new Rectangle(){Height = 15, Width = 23},
//    new Circle(){Radius=21.3},
//    new Triangle(){Height = 48.3},
//    new SomeBody(){Vetchina = 23.5, Otcheno=78, Prichina=5}
//};

//Calculate calculate = new Calculate();
//Console.WriteLine(calculate.Areas(shapes)); 
//abstract class Shape
//{
//    public abstract double Area();
//}
//class Rectangle: Shape
//{
//    public double Width { get; set; }
//    public double Height { get; set; }

//    public override double Area() => Width*Height;
//}

//class Circle: Shape
//{
//    public double Radius { get; set; }

//    public override double Area() => Math.Pow(Radius, 2) * Math.PI;
//}

//class Triangle: Shape
//{
//    // some fields
//    public double Height { get; set; }

//    public override double Area() => Height * 15 / 25 - 3;
//}

//class SomeBody: Shape
//{
//    // some fields
//    public double Vetchina { get; set; }
//    public double Otcheno { get; set; }
//    public double Prichina { get; set; }

//    public override double Area()=> Vetchina * Otcheno - Prichina;
//}

//class Calculate
//{
//    public double Areas(Shape[] shapes) => shapes.Sum(x => x.Area());
//    //{
//        //double areas = 0;
//        //foreach (Shape shape in shapes)
//        //{
//        //    areas += shape.Area();
//        //}
//        //return areas;

//    //}
//}

#endregion
