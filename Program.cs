using System.Security.Cryptography;
using System;
namespace number34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во элементов: ");
            int countElements = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int [countElements];
            uint count = 0;

            Random rand = new Random();
            Console.WriteLine("Заполнение массива случайными числами: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(100,999);
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();
            
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] % 2 == 0)
                {
                    count += 1;
                }
            }
            Console.WriteLine("Кол-во четных элементов массива: " + count);
        }
    }
}
