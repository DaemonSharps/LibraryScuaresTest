using System;

namespace LibraryAreas
{
    class Program
    {
        static void Main(string[] args)
        {
            void Display(double area)
            {
                Console.WriteLine("Area is:" + area);
            }

            double R = Double.Parse(Console.ReadLine());
            Shape Circle = new Shape(R);
            Shape Triangle = new Shape(3, 4, 5);
            Shape Square = new Shape(5, 5);

            Circle.RegDelegate(Display);
            Triangle.RegDelegate(Display);
            Square.RegDelegate(Display);

            Circle.ShowArea();
            Triangle.ShowArea();

            if (Triangle.isRightTriangle())
            {
                Console.WriteLine("Right Triangle");
            }

            Square.ShowArea();

            Console.Read();
        }
    }
}
