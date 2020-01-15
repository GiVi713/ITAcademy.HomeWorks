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
                                         "регистрацию через интернет или желаете пройти её здесь.\n");

            NewPassenger newClient = new NewPassenger();
            newClient.Client();

            PersonLuggage luggage = new PersonLuggage();
            luggage.Luggage();

            ControlPerson lastStep = new ControlPerson();
            lastStep.CheckLuggage();
        }
        public void Finish()
        {
            Console.WriteLine("Вы успешно прошли контроль и сели на свой самолет. Полет выдался " +
                "отличный. Через 7 часов вы приземлились в солнечном Карибском заливе, а через " +
                    "8 уже на спали на пляже.");
        }
    }
}
