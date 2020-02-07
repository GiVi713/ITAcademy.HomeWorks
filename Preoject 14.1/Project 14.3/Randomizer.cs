using System;
using System.Collections.Generic;
using System.Text;

namespace Project_14._3
{
    class Randomizer
    {
        Random rand = new Random();

        public int PhoneNumber(int flat)
        {
            int phoneNumber = 0;
            if (flat >= 1 || flat <= 10)
            {
                switch (flat)
                {
                    case 1: phoneNumber = 29_433_37_86; break;
                    case 2: phoneNumber = 29_703_48_20; break;
                    case 3: phoneNumber = 29_183_19_35; break;
                    case 4: phoneNumber = 29_929_94_49; break;
                    case 5: phoneNumber = 29_832_51_80; break;
                    case 6: phoneNumber = 29_833_65_49; break;
                    case 7: phoneNumber = 29_339_27_42; break;
                    case 8: phoneNumber = 29_726_17_60; break;
                    case 9: phoneNumber = 29_921_11_10; break;
                    case 10: phoneNumber = 29_546_18_68; break;
                }
                return phoneNumber;
            }
            else
            {
                Console.WriteLine("Такой квартиры нет, попробуйте другую.");
                return phoneNumber;
            }
        }

        public string GetName(int num)
        {
            string FullName = "";
            switch (num)
            {
                case 1: FullName = "Петя"; break;
                case 2: FullName = "Василий"; break;
                case 3: FullName = "Любитель русского репа"; break;
                case 4: FullName = "Домашний строитель"; break;
                case 5: FullName = "Многодетная мать"; break;
                case 6: FullName = "Капитан дальнего заливания"; break;
                case 7: FullName = "Актеры 50 оттенков серого"; break;
                case 8: FullName = "Ценители дешевого алкоголя"; break;
                case 9: FullName = "Зинка"; break;
                case 10: FullName = "Крикуны"; break;
            }
            return FullName;
        }
        static int flat = 0;
        int floor = 1;
        
        public int GetFlat()
        {
            flat++;
            GetFloor();
            return flat;
        }
        public int GetFloor()
        {
            if(flat <= 3)
            {
                return floor;
            }
            else if (flat <= 6 || flat < 3)
            {
                return floor++;
            }
            else
            {
                return floor + 2;
            }
        }
    }
}
