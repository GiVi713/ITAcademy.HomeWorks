using System;
using System.Collections.Generic;
using System.Text;

namespace Self
{
    public class Square
    {
        public int squareArea(int storona)
        {
            int squareArea = storona*storona;
            Console.WriteLine(squareArea);
            Console.WriteLine($"This is Square. CLR Type is .Square is {squareArea}"); 
            return squareArea;
        }
    }
}
