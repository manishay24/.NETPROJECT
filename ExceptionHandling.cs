using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter 1st number");
                int x = int.Parse("Console.ReadLine()");
                Console.Write("enter 2nd number");
                int y = int.Parse("Console.ReadLine()");
                int z = x / y;
                Console.WriteLine("The Results:" + z);
            }
            catch (Divide By Zero Exception ex1);
            {
                Console.Write(ex1.message);
            }
            catch (FormatException ex2)
            {
                Console.Write("Input must be numerics");
            }
            catch (Exception ex)
            Console.Write("ex.message");
            }
            Console.WriteLine("End of the program");
        }
    }

