using System;
namespace Application
{

    public class Program
    {
        static void Main(string[] args)
        {
            // var number = int.Parse("abc");           //Prase Method throws exception
            int number;
            var result = int.TryParse("abc",out number); //try parse does not throw exception
            if(result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Oopss!  Conversion Failed.");
        }
        static void ParseAdd()
        {
            var calculator = new Calculator();
            Console.WriteLine("Sum = "+calculator.Add(1,2));
            Console.WriteLine("Sum = "+calculator.Add(1,2,3));
            Console.WriteLine("Sum = "+calculator.Add(1,2,3,4));

        }
        static void Point()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(40, 60));
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            }
            catch (Exception)
            {

                Console.WriteLine("unexpected error occured.");
            }

        }
    }
}