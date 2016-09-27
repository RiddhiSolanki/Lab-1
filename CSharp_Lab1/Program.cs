using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Lab1
{
    class Program

    {
        static String b;
        static void Main(string[] args)
        {


            do
            {

                Console.WriteLine("Please enter a Length");
                string Length = Console.ReadLine();
                double LengthNum = double.Parse(Length);

                Console.WriteLine("Please enter a Width");
                String Width = Console.ReadLine();
                double WidthNum = double.Parse(Width);

                double Perimeter = (LengthNum + WidthNum);
                double Area = (Perimeter * 2);

                Console.WriteLine("the perimeter is " + Perimeter);
                Console.WriteLine("The Area is" + Area);

                Console.WriteLine("Do you want to continue? (y/n)");

               b = Console.ReadLine();
            }
            while ( b == "y");

            Console.WriteLine("Thank you");
            Console.ReadKey();

        }



    
        

        
    }
}
