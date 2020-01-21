using System;
using System.Collections.Generic;
using System.Text;

namespace HW_11.Task1
{
    abstract class Figures
    {
        public string Name { get; set; }
        public Figures(string name)
        {
            Name = name;
        }
        public abstract double figiureArea();
    }

    internal sealed class Square : Figures
    {
        private double storona { get; set; }
        public Square(string name, int storona) : base(name)
        {

        }

        public Square(string name) : base(name)
        {
        }

        public override double figiureArea() => Math.Pow(2, 2);
    }
}
