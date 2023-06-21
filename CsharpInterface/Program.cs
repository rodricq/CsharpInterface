using System;

namespace CsharpInterface
{
    interface IPolygon
    {
        //method without body
        void calculateArea(int l, int b);
    }

    interface IDecagon
    {
        //method without body
        void calculatePerimete(int s, int h);
    }

    class Ruler : IDecagon
    {
        //implimentation of methods inside interface
        public void calculatePerimete(int s, int h)
        {
            int perimeter = s + h;
            Console.WriteLine("Perimeter of ruler: " + perimeter);
        }

    }
        class Rectangle : IPolygon
    {
        //implimentation of methods inside interface
        public void calculateArea(int l, int b)
        {
            int area = l * b;
            Console.WriteLine("Area of Rectangle: " + area);
        }

        class Square : Rectangle
        {
            //implimentation of methods inside interface
            public void CalculateArea(int a, int c)
            {
                int area = a * c;
                Console.WriteLine("Area of Square: " + area);
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Rectangle r1 = new Rectangle();
                r1.calculateArea(100, 200);

                Square s1 = new Square();
                s1.CalculateArea(20, 20);

                    Ruler p1 = new Ruler();
                    p1.calculatePerimete(45, 70);

                Console.ReadKey();
            }
        }
    }
}
