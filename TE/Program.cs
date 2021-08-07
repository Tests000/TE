using System;

namespace TE
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure1 = new Circle(2);
            Figure figure2 = new Triangle(4, 3, 5);


            Console.WriteLine(figure2.area());
            Console.WriteLine(((Triangle)figure2).rightTriangle());
            Console.WriteLine(figure1.area());
            Console.WriteLine(Figure.area(3));
            Console.WriteLine(Figure.area(6, 8 ,10));
        }
    }
}
