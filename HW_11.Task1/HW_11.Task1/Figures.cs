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

    class Square : Figures
    {
        private double Storona { get; set; }
        public Square(string name, double storona) : base(name)
        {
            Storona = storona;
        }

        public override double figiureArea()
        {
            return Math.Pow(Storona,2);
        }
    }
    class Triangle : Figures
    {
        private double Sides { get; set; }
        private double TriangleBase { get; set; }

        public Triangle(string name, double sides, double triangleBase) : base(name) 
        {
            Sides = sides;
            TriangleBase = triangleBase;
        }

        public override double figiureArea()
        {
            double high = 0.5 * Math.Sqrt(4 * Math.Pow(Sides, 2) - Math.Pow(TriangleBase, 2));
            return Math.Round (0.5 * TriangleBase * high);
        }
    }
    class Circle : Figures
    {
        private double Radius { get; set; }

        public Circle(string name, double radius) : base (name)
        {
            Radius = radius;
        }

        public override double figiureArea()
        {
            return Math.Round(Math.Pow(Radius,2) * Math.PI);
        }
    } 
}
