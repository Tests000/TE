using System;
using System.Collections.Generic;
using System.Text;

namespace TE
{
    abstract class Figure
    {
        public abstract double area();

        public static double area(double r)
        {
            if (r < 0)
                throw new ArgumentException();
            return r * r * Math.PI;
        }

        public static double area(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || a + c <= b || b + c <= b)
                throw new ArgumentException();
            var p = (a + b + c) / 2;
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }
    }

    class Triangle : Figure
    {
        public double a { get; set; }

        public double b { get; set; }

        public double c { get; set; }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || a + c <= b || b + c <= b)
                throw new ArgumentException();
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double area()
        {
            var p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public bool rightTriangle()
        {
            if (a > b && a > c)
                return b * b + c * c == a * a;
            if (b > a && b > c)
                return a * a + c * c == b * b;
            if (c > b && c > a)
                return a * a + b * b == c * c;
            return false;
        }
    }

    class Circle : Figure
    {
        public double r { get; set; }

        public Circle(double r)
        {
            if (r < 0)
                throw new ArgumentException();
            this.r = r;
        }

        public override double area()
        {
            return r * r * Math.PI;
        }
    }
}
