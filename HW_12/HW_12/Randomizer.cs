using System;
using System.Collections.Generic;
using System.Text;

namespace HW_12
{
    class Randomizer
    {
        Random rand = new Random();
        public static int Id = 0;
        
        public int GetID()
        {
            Id++;
            return Id;
        }

        public string GetMark(int num) { 
         string model="";
            switch(num)
            {
                case 1: model = "BMV" ;break;
                case 2: model = "Ducati"; break;
                case 3: model = "Honda"; break;
                case 4: model = "Kawasaki"; break;
                case 5: model = "Yamaha"; break;
                case 6: model = "Suzuki"; break;
                case 7: model = "HarleyDavidson"; break;
                case 8: model = "Aprilia"; break;
                case 9: model = "KTM"; break;
                case 10: model = "Triumph"; break;
            }
            return model;
        }

        public string GetState(int num)
        {
            string state = "";
            switch (num)
            {
                case 1: state = "Новый";break;
                case 2: state = "Б/У";break;
                case 3: state = "Старый";break;
                case 4: state = "На запчасти";break;
                case 5: state = "Хорошее";break;
            }
            return state;
        }

        public string GetLocation(int num)
        {
            string location = "";
            switch (num)
            {
                case 1: location = "Минск";break;
                case 2: location = "Брест";break;
                case 3: location = "Витебск";break;
                case 4: location = "Гродно";break;
                case 5: location = "Гомель";break;
                case 6: location = "Могилев";break;
                case 7: location = "Логойск";break;
                case 8: location = "Лида";break;
                case 9: location = "Жлобин";break;
                case 10: location = "Жодино";break;
            }
            return location;
        }

    }
}
