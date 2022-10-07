using System;

namespace grunderna_oop
{   // Alva Westrin Haglund .NET22
    class Program
    {
        static void Main(string[] args)
        {   // // creating 2 instances of circle class with a radius of 5 and 6
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(6);
            // Prints out the calculated Area
            Console.WriteLine("Radie 5: " + circle1.getArea());
            Console.WriteLine("Radie 6: " + circle2.getArea());
        }
    }
    class Circle
    {
        public float pi = 3.141f;
        private int Radius;
        // method to get the radius of the circle
        public Circle(int aRadius)
        {
            Radius = aRadius;
        }
        // method to determine the area of the circle
        public float getArea()
        {
            return Radius * Radius * pi;
        }
    }
}
