using System;

namespace FinalProject
{
    class Program
    {
        static void Main()
        {
            CreateUser create = new CreateUser();
            create.NewUser();
            Console.WriteLine(create.UserName + create.UserLocation);
        }
    }
}
