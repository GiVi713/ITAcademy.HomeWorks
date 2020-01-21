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
            Console.WriteLine(circleArea);
            return circleArea;
        }
    }
}
