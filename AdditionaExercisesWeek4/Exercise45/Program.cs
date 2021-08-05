using System;

namespace Exercise45
{
    class Square
    {
        public double SideLength;

        public Square()
        {
            Console.Write("Enter a side length: ");
            double _SideLength = double.Parse(Console.ReadLine());
            SideLength = _SideLength;
        }

        public double CalculatePerimeter()
        {
            return SideLength * 4;
        }
        public double CalculateArea()
        {
            return SideLength * 2;
        }
        //public void Print()
        //{
        //    Console.WriteLine($"Side: {SideLength}\nArea: {CalculateArea()}\nPerimeter: {CalculatePerimeter()}");
        //}

        public override string ToString()
        {
            return $"Side: {SideLength}\nArea: {CalculateArea()}\nPerimeter: {CalculatePerimeter()}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Square s1 = new Square();
            Console.WriteLine(s1);
         

            
           

        }
    }
}
