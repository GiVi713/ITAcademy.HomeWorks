using System;
using System.Collections.Generic;
using System.Text;

namespace Project_14._3
{
    class RandomNeighbor : Randomizer
    {
        static private List <CreateNeighbor> _fill = Program.floorNeighbors;
        

        public static void AutoCreate()
        {
            int count = 0;
            while (count < 10)
            {
                CreateNeighbor newSosed = new CreateNeighbor();
                _fill.Add(newSosed);
                count++;
            }
        }

        public static void insertFlat()
        {
            Console.WriteLine("Kвартирa которая вас интересует");
            int flat = Convert.ToInt32(Console.ReadLine());
            if (flat >= 1 & flat <= 10)
            {
                flat--;
                CreateNeighbor sosedFlat = _fill[flat];
                RandomNeighbor.Display(sosedFlat);
            }
            else
            {  
                Console.WriteLine("Такой квартиры нет, попробуйте другую.");
                insertFlat();
            }
        }

        public static void Display(CreateNeighbor neighbor)
        {
            Console.WriteLine($"Это {neighbor.FullName}. Живет на {neighbor.flatNumber} этаже в {neighbor.floor} " +
                                $"квартире. Разведка предоставила номер телефона - {neighbor.PhoneNumber}");
        }
    }
}
