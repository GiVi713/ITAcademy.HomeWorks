using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int size = 5;
            int[] nums = new int[size];
            for (int i = 0; i < size - 1; i++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Введите последнее значение и его порядковый номер \nЧисло:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nПозиция:\n");
            int pos = Convert.ToInt32(Console.ReadLine());
            for (int i = size - 2; i >= pos - 1; i--)  
                nums[i + 1] = nums[i];
                nums[pos - 1] = num;
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
