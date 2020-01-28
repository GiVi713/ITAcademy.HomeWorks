using System;
using System.Collections.Generic;
using System.Text;


namespace HW_12
{
    class Crud : Randomizer
    {
        static private List<Moto> _fill = Program.allMoto;

        static public void AutoCreate()
        {
            Logger.Log.Info("Auto create new motorcycle");
           
            Moto newMoto = new Moto();
            _fill.Add(newMoto);
        }

        static public void HandCreate()
        {
            Logger.Log.Debug("Create new motorcycle with your parameters");

            Moto newMoto = new Moto();
            Console.WriteLine("Марка мотоцикла:");
            newMoto.manufacturer = Console.ReadLine();
            Console.WriteLine("Состояние мотоцикла:");
            newMoto.state = Console.ReadLine();
            Console.WriteLine("Его местонахождение:");
            newMoto.location = Console.ReadLine();
            Console.WriteLine("Объём двигателся:");
            newMoto.engineCapacity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите цену:");
            newMoto.price = Convert.ToInt32(Console.ReadLine());
            _fill.Add(newMoto);
        }

        public static void Display()
        {
            Logger.Log.Info("Show the selected motorcycle");

            Console.WriteLine("Выберите номер");
            int ID = Convert.ToInt32(Console.ReadLine());
            ID--;
            Moto newMoto = _fill[ID];
            Crud.DisplayHelper(newMoto);
        }

        protected static void DisplayHelper(Moto moto)
        {
            Logger.Log.Info("Small helper");

            Console.WriteLine($"Ваш запрос: \nПродам мотоцикл марки {moto.manufacturer}. Состояние: {moto.state}. Находится в городе {moto.location}." +
                                    $"Объём двигатея: {moto.engineCapacity}. Продам за {moto.price} долларов.");
        }

        static public void DisplayAll(List<Moto> motorCycles)
        {
           Logger.Log.Info("Show all motorcycles");

            Console.WriteLine("Список всех объявлений:");
            foreach (var moto in motorCycles)
            {
                Console.WriteLine($"Номер объявления:{moto.ID}. Продам мотоцикл марки {moto.manufacturer}. Состояние: {moto.state}. Находится в городе {moto.location}." +
                                    $"Объём двигатея: {moto.engineCapacity}. Продам за {moto.price} долларов.");
                Console.WriteLine();
            }
        }

        public static void Update()
        {
            Logger.Log.Debug("Update the selected motorcycle");

            Console.WriteLine("Выберите номер объявления которое хотите изменить:\n");
            Crud.DisplayAll(Program.allMoto);
            int i = Convert.ToInt32(Console.ReadLine());
            i--;
            Moto updateMoto = _fill[i];
            Console.WriteLine("Марка мотоцикла:");
            updateMoto.manufacturer = Console.ReadLine();
            Console.WriteLine("Состояние мотоцикла:");
            updateMoto.state = Console.ReadLine();
            Console.WriteLine("Его местонахождение:");
            updateMoto.location = Console.ReadLine();
            Console.WriteLine("Объём двигателся:");
            updateMoto.engineCapacity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите цену:");
            updateMoto.price = Convert.ToInt32(Console.ReadLine());
        }

        public static void Delete()
        {
            Logger.Log.Info("Delete the seletcted motorcycle");

            Console.WriteLine("Выберите номер объявления которое хотите удалить:\n");
            Crud.DisplayAll(_fill);
            int i = Convert.ToInt32(Console.ReadLine());
            i--;
            _fill.RemoveAt(i);
        }
    }
}