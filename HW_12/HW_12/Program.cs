using System;
using System.Collections.Generic;
using HW_12;
using log4net;
using log4net.Config;


namespace HW_12
{
    class Program 
    {
        
        public static List<Moto> allMoto = new List<Moto> { };
        

        static void Main(string[] args)
        {
            Logger.InitLogger();
            Logger.Log.Info("Start program");
            Crud.AutoCreate();
            Crud.HandCreate();
            Crud.Update();
            Crud.Display();
            Crud.DisplayAll(allMoto);
            Crud.Delete();


            //Crud.AutoCreate();                    Создать мотоцикл со случайно сгенерироваными параметрами
            //Crud.HandCreate();                    Создать мотоцикл со своими параметрами
            //Crud.Update();                        Изменить объявление на выбор
            //Crud.Display();                       Покаывает выбранное объявление  PS. Тут можно было сделать возможность удаления и редактирования после выбора но я хочу кушать
            //Crud.DisplayAll(allMoto);             Вывести все имеющиеся мотоциклы
            //Crud.Delete();                        Удалить объявление

            Logger.Log.Info("Program is successfully finished");
        }
    }
}
