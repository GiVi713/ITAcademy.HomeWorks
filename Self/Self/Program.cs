using System;

namespace Self
{
    class Program
    {
        public double storona= 0;
        static void Main(string[] args)
        {
            Random rand = new Random();

            Circle krug = new Circle();
            krug.CircleArea(rand.Next(1,10));

            Square kvadrat = new Square();
            kvadrat.squareArea(rand.Next(1, 10));
           
        }
    }
}
