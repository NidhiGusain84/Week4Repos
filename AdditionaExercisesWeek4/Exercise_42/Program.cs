using System;

namespace Exercise_44   
{
    class Point
    {
        public double X;
        public double Y;

        public Point()
        {
            Console.Write("\nEnter an X coordinate: ");
            double x = double.Parse(Console.ReadLine());
            X = x;

            Console.Write("Enter a Y coordinate: ");
            double y = double.Parse(Console.ReadLine());
            Y = y;
        }
        public double CalculateDistance()
        {
            double distance = Math.Sqrt((Math.Pow(X - 0, 2) + Math.Pow(Y - 0, 2)));
            return distance;
        }
        
        public void Print()
        {
            Console.WriteLine($"You have created a point object ({X}, {Y}).");
            Console.WriteLine($"Distance: {CalculateDistance()}");
                           
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {


            Point p1 = new Point();
            p1.Print();
           

        }
    }
}
