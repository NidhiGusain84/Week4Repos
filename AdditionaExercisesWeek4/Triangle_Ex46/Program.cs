using System;

namespace Triangle_Ex46
{
    class Triangle
    {
        public double Side1Length;
        public double Side2Length;
        public double Side3Length;

        public Triangle()
        {
            Console.Write("Enter side1: ");
            double side1 = double.Parse(Console.ReadLine());
            Console.Write("Enter side2: ");
            double side2 = double.Parse(Console.ReadLine());
            Console.Write("Enter side3: ");
            double side3 = double.Parse(Console.ReadLine());
            Side1Length = side1;
            Side2Length = side2;
            Side3Length = side3;
        }

        public double Area()
        {
            double s = (Side1Length + Side2Length + Side3Length) / 2;
            double area = Math.Sqrt(s * (s - Side1Length) * (s - Side2Length) * (s - Side3Length));
            return area;
        }
        public double Perimeter()
        {
            return Side1Length + Side2Length + Side3Length;
        }

        public override string ToString()
        {
            return $"Side1 = {Side1Length}\nSide2 = {Side2Length}\nSide3 = {Side3Length}\nArea = {Area()}\nPerimeter = {Perimeter()}";
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            Triangle t1 = new Triangle();

            Console.WriteLine(t1);


        }
    }
}
