using System;
using System.Collections.Generic;
using log4net;
using log4net.Config;

namespace HW_12
{
    class Program 
    {
        public static List<Moto> motorcycles = new List<Moto> { };
        
        static void Main(string[] args)
        {
            Logger.InitLogger();
            Crud.AutoCreate();
            Crud.AutoCreate();
            Crud.DisplayAll(motorcycles);
            //Crud.AutoCreate();                    Создать мотоцикл со случайно сгенерироваными параметрами
            //Crud.HandCreate();                    Создать мотоцикл со своими параметрами
            //Crud.Update();                        Изменить объявление на выбор
            Crud.Display();
            //Crud.DisplayAll(motorcycles);         Вывести все имеющиеся мотоциклы
            //Crud.Delete();                        Удалить объявление
        }













        
    }
}
