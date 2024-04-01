using Microsoft.VisualBasic;
using System;

namespace Third_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>> Time Converter <<<");
            string choice;
            do
            {
                Console.WriteLine("\nChoose Option of conversion:");
                Console.WriteLine("[1] Second/s to Minute/s");
                Console.WriteLine("[2] Minute/s to Hour/s");
                Console.WriteLine("[3] Hour/s to Day/s");
                Console.WriteLine("[4] Day/s to Month/s");

                Console.Write("\nEnter Choice(1-4): ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("\n >Second/s to Minutes/s<");
                        Console.Write("Enter second/s to convert: ");
                        double seconds = Convert.ToDouble(Console.ReadLine());
                        double convertminutes = seconds / 60;
                        Console.WriteLine("{0} / 60 = {1} minute/s" , seconds, convertminutes);
                        break; 
                    case 2:
                        Console.WriteLine("\n  >Minutes/s to Hour/s<");
                        Console.Write("Enter minutes/s to convert: ");
                        double minutes = Convert.ToDouble(Console.ReadLine());
                        double converthours = minutes / 60;
                        Console.WriteLine("{0} / 60 = {1} hour/s", minutes, converthours);
                        break;
                    case 3:
                        Console.WriteLine("\n   >Hour/s to Day/s<");
                        Console.Write("Enter hour/s to convert: ");
                        double hours = Convert.ToDouble(Console.ReadLine());
                        double convertdays = hours / 24;
                        Console.WriteLine("{0} / 24 = {1} day/s", hours, convertdays);
                        break;
                    case 4:
                        Console.WriteLine("\n  >Day/s to Month/s<");
                        Console.Write("Enter day/s to convert: ");
                        double days = Convert.ToDouble(Console.ReadLine());
                        double convertmonths = days / 30.42;
                        Console.WriteLine("{0} / 30.42 = {1} month/s", days, convertmonths);
                        break;
                    default:
                        Console.WriteLine("Please choose from 1-4 only!");
                        break;
                }
                Console.WriteLine("Do you want to try again? (yes / no)");
                choice = Console.ReadLine();
            } 
            while (choice == "Yes" || choice == "yes" || choice == "Y" || choice == "y");
            Console.WriteLine("Thanks for using >>> Time Converter <<<, have a good day!");
        }
    }
}
