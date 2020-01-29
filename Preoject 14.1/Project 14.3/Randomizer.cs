using System;
using System.Collections.Generic;
using System.Text;

namespace Project_14._3
{
    class Randomizer
    {
        Random rand = new Random();
        static int Id = 0;

        public int GetID()
        {
            
            Id++;
            return Id;
        }

        public string GetName(int num)
        {
            
            string FullName = "";
            switch (num)
            {
                case 1: FullName = "BMV"; break;
                case 2: FullName = "Ducati"; break;
                case 3: FullName = "Honda"; break;
                case 4: FullName = "Kawasaki"; break;
                case 5: FullName = "Yamaha"; break;
                case 6: FullName = "Suzuki"; break;
                case 7: FullName = "HarleyDavidson"; break;
                case 8: FullName = "Aprilia"; break;
                case 9: FullName = "KTM"; break;
                case 10: FullName = "Triumph"; break;
            }
            return FullName;
        }

        public string GetState(int num)
        {
           
            string state = "";
            switch (num)
            {
                case 1: state = "Новый"; break;
                case 2: state = "Б/У"; break;
                case 3: state = "Старый"; break;
                case 4: state = "На запчасти"; break;
                case 5: state = "Хорошее"; break;
            }
            return state;
        }

        public string GetLocation(int num)
        {
            string location = "";
            switch (num)
            {
                case 1: location = "Минск"; break;
                case 2: location = "Брест"; break;
                case 3: location = "Витебск"; break;
                case 4: location = "Гродно"; break;
                case 5: location = "Гомель"; break;
                case 6: location = "Могилев"; break;
                case 7: location = "Логойск"; break;
                case 8: location = "Лида"; break;
                case 9: location = "Жлобин"; break;
                case 10: location = "Жодино"; break;
            }
            return location;
        }

    }
}
