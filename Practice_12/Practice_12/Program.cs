using System;

namespace Practice_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Figures[] mas = new Figures[5];

            mas[0] = new Circle("Circle", rand.Next(1, 10));
            mas[1] = new Square("Square", rand.Next(1, 10));
            mas[2] = new Triangle("Triangle", rand.Next(1, 10));
            mas[3] = new Circle("Circle", rand.Next(1, 10));
            mas[4] = new Square("Square", rand.Next(1, 10));

            Result(mas);
        }

        public static void Result ( Figures[] mas)
        {
            foreach ( var item in mas)
            {
                Console.WriteLine($"This is {item.Name}. CLR Type is {item}. Square is {item.figureArea()}");
            }
        }
    }
}
