using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__CanBan
{
    internal class Array
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Nhap so thu " + (i + 1) + ": ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Cac so chan trong mang la :");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }
    }
}
