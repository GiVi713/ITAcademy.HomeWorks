using System;
using System.Collections.Generic;
using NLog;

namespace HW_12
{
    class Program 
    {
        public static List<Moto> motorcycles = new List<Moto> { };
        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            logger.Trace("trace message");
            Crud.AutoCreate();
            Crud.AutoCreate();
            //Crud.AutoCreate();                    Создать мотоцикл со случайно сгенерироваными параметрами
            //Crud.HandCreate();                    Создать мотоцикл со своими параметрами
            //Crud.Update();                        Изменить объявление на выбор
            //Crud.Display();                       Покаывает выбранное объявление  PS. Тут можно было сделать возможность удаления и редактирования после выбора но я хочу кушать
            //Crud.DisplayAll(motorcycles);         Вывести все имеющиеся мотоциклы
            //Crud.Delete();                        Удалить объявление
        }













        
    }
}
