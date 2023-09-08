using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0709Activity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 numbers with spaces" ); //Ask user to input 5 numbers,(after me testing added the word with spaces)

            string input = Console.ReadLine(); //read the input to strings

            string[] number = input.Split(' ');

            double[] numbers = new double[5]; //COnverting the number into new arrays 

            for (int i = 0; i < 5; i++) 
            {
                numbers[i] = Convert.ToDouble(number[i]);
            }
            Console.WriteLine("Numbers in reverse order:");//show the reverse order of the numbers below

            Array.Reverse(numbers); // Reverse the array

            foreach (double num in numbers)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();

        }
    }
}