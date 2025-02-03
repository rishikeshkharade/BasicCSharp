using System;
/*class FirstProgram
{
    static void Main() {
       Console.WriteLine("Hello");

        //signed integer types
        sbyte sb = -120;
        short s = 30000;
        int i = 2000000000;
        long l = 10000000000000;
        Console.WriteLine(sb);
        Console.WriteLine(i);
        Console.WriteLine(l);
        Console.WriteLine(s);

        //unsigned Integer types
        byte b = 122;
        ushort us = 60123;
        uint ui = 4000000000;
        ulong ul = 100000000000000;
        Console.WriteLine(b);
        Console.WriteLine(us);
        Console.WriteLine(ui);
        Console.WriteLine(ul);

        //floating point type
        float f = 12.7f;
            double d = 23.67;
        decimal dm = 99.12520m;
        Console.WriteLine(f);
        Console.WriteLine(d);
        Console.WriteLine(dm);

        //other variable types
        char c = 'a';
        bool flag = false;
        string str = "Welcome to BridgeLabz";

        Console.WriteLine(str);
        Console.WriteLine(flag);
        Console.WriteLine(c);
            }
}*/

namespace AreaApplication
{
    class Rectangle
    {
        //variables
        public double length;
        public double width;

        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("\nLength: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }
    //Area of Square
    class Square
    {
        public double Any_Side;

        public double GetArea()
        {
            return Any_Side * Any_Side;
        }
        public void Display()
        {
            Console.WriteLine("\nSide of a Square {0}", Any_Side);
            Console.WriteLine("Area of a Square {0}", GetArea());
        }
    }

    //Area of Circle
    class Circle
    {
        public double radius;
  
    public double GetArea()
        {
            return 3.14 * radius * radius;
        }

        public void Display()
        {
            Console.WriteLine("\nRadius of a Circle {0}", radius);
            Console.WriteLine("Area of a Circle {0}", GetArea());
        }
    }

    //Area of Triangle
    class Triangle
    {
        public double breadth;
        public double height;

        public double GetArea()
        {
            return (breadth*height)/2;
        }

        public void Display()
        {
            Console.WriteLine("\nBreadth of triangle {0}", breadth);
            Console.WriteLine("Height of triangle {0}", height);
            Console.WriteLine("Area of triangle {0}", GetArea());
        }
    }
    class ExecuteArea
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.length = 10.20;
            rectangle.width = 4.20;
            rectangle.Display();
            Square square = new Square();
            square.Any_Side = 20;
            square.GetArea();
            square.Display();
            Circle circle = new Circle();
            circle.radius = 30.2;
            circle.GetArea();
            circle.Display();
            Triangle triangle = new Triangle();
            triangle.breadth = 10;
            triangle.height = 20.15;
            triangle.GetArea();
            triangle.Display();
        }
    }
}