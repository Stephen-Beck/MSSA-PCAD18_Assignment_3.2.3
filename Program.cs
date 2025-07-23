// Create a console application to overload “+” and “-“ operator for adding
// the areas of 2 circles and getting their area difference respectively.

namespace Assignment_3._2._3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will calculate the sum and difference of the area of two circles.");
            Console.Write("Enter the radius of Circle 1: ");
            Circle circle1 = new Circle(CalculateCircleArea());
            Console.Write("Enter the radius of Circle 2: ");
            Circle circle2 = new Circle(CalculateCircleArea());

            Console.WriteLine();
            Console.WriteLine("Area of Circle 1: " + circle1.Area);
            Console.WriteLine("Area of Circle 2: " + circle2.Area);
            Console.WriteLine(" Sum: ".PadLeft(18)+(circle1 + circle2));
            Console.Write("Abs. Difference: ".PadLeft(18)+Math.Abs(circle1 - circle2));
            
            // Tell the user whether Circle 1 or Circle 2 is bigger
            switch(circle1 - circle2)
            {
                case < 0:
                    Console.WriteLine(" (Circle 2 is bigger than Circle 1)");
                    break;
                case > 0:
                    Console.WriteLine(" (Circle 1 is bigger than Circle 2)");
                    break;
                default:
                    Console.WriteLine(" (Both circles are the same size)");
                    break;
            }
        }

        static double GetUserInput()
        {
            double userInput = 0;
            while (true)
            {
                if (double.TryParse(Console.ReadLine().Trim(), out userInput))
                {
                    if (userInput > 0)
                        return userInput;
                }

                Console.Write("Enter a valid positive number: ");
            }
        }

        static double CalculateCircleArea()
        {
            double radius = GetUserInput();
            return (Convert.ToDouble(Math.PI) * radius * radius);
        }
    }

    public class Circle
    {
        public double Area { get; set; }
        public Circle(double area)
        {
            Area = area;
        }

        public static double operator +(Circle circle1, Circle circle2) => (circle1.Area + circle2.Area);
        public static double operator -(Circle circle1, Circle circle2) => (circle1.Area - circle2.Area);
    }
}
