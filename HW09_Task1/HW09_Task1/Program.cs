using System;
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
            if (regStatus == "Да")
            {
                WebRegistration webReg = new WebRegistration();
                webReg.WebReg();
            }
            else if( regStatus == "Здесь")
            {
                NewPassenger newPerson = new NewPassenger();
                newPerson.RegisterPassenger();
            }
            PersonLuggage luggage = new PersonLuggage();
            luggage.LuggageCalc();
        }
    }
}
