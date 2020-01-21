using System;

namespace HW_11.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Figures[] mas = new Figures[3];

            mas[0] = new Square("Square", rand.Next(1, 10));
            mas[1] = new Triangle("Square", rand.Next(1, 10),rand.Next(1,10));
            mas[2] = new Circle("Circle", rand.Next(1, 10));
        }
        public void Result(Figures[] mas)
        {
            foreach (var item in mas)
            {
                Console.WriteLine($"This is {item.Name}.CLR Type is {item}.Square is {item.figiureArea()}");
            }
        }
    }
}
