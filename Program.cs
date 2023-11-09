using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Printing the first 10 numbers in the Fibonacci sequence
            Console.WriteLine("First 10 numbers in the Fibonacci sequence:");
            int[] fibonacci = new int[10];
            fibonacci[0] = 0;
            fibonacci[1] = 1;

            for (int i = 2; i < 10; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }

            foreach (int number in fibonacci)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine(); 

            //Creating an array of Integers and finding sum and average
            int[] numbers = new int[] { 5, 8, 12, 3, 6 };

            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }

            double average = (double)sum / numbers.Length;

            Console.WriteLine("\nSum of elements in the array: " + sum);
            Console.WriteLine("Average of elements in the array: " + average);
            Console.ReadKey();
        }
    }
}
