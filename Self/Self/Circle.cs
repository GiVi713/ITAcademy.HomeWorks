using System;
using System.Collections.Generic;
using System.Text;

namespace Self
{
    public class Circle
    {
        public double CircleArea(int storona)
        {
            double circleArea = 2 * storona * 3.14;
            Console.WriteLine($"This is Circle. CLR Type is .Square is {circleArea}");
            return circleArea;  
        }
    }
}
