using System;
using HW09_Task1.Control;
using HW09_Task1.Luggage;

namespace HW09_Task1
{
    class Program 
    {
        static void Main()
        {
            Console.WriteLine("Мы рады приветсвовать вас в Psina Airlines! Cкажите вы уже прошли " +
                                         "регистрацию через интернет или желаете пройти её здесь.");

            string regStatus = Console.ReadLine();
            if (regStatus == "Прошел")
            {
                WebRegistration webReg = new WebRegistration();
                webReg.WebReg();
            }
            else if( regStatus == "Здесь")
            {
                NewPassenger newPerson = new NewPassenger();
                Console.WriteLine("Скажите пожалуйста ваше Имя и Фамилию");
                newPerson.Name = Console.ReadLine();
                string tryHere = newPerson.Name;
                Console.WriteLine(tryHere);
            }
            else
            {
                Console.WriteLine("Простите я вас не поняла, давайте начнем сначала");
            }

            PersonLuggage luggage = new PersonLuggage();
            luggage.Luggage();

            ControlPerson lastStep = new ControlPerson();
            lastStep.CheckLuggage();
        }
    }
}
