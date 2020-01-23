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
        private double _Storona { get; set; }
        public Square(string name, double _storona) : base(name)
        {
            _Storona = _storona;
        }

        public override double figiureArea()
        {
            return Math.Pow(_Storona,2);
        }
    }
    class Triangle : Figures
    {
        private double _Sides { get; set; }
        private double _TriangleBase { get; set; }

        public Triangle(string name, double _sides, double _triangleBase) : base(name) 
        {
            _Sides = _sides;
            _TriangleBase = _triangleBase;
        }

        public override double figiureArea()
        {
            double high = 0.5 * Math.Sqrt(4 * Math.Pow(_Sides, 2) - Math.Pow(_TriangleBase, 2));
            return Math.Round (0.5 * _TriangleBase * high);
        }
    }
    class Circle : Figures
    {
        private double _Radius { get; set; }

        public Circle(string name, double _radius) : base (name)
        {
            _Radius = _radius;
        }

        public override double figiureArea()
        {
            return Math.Round(Math.Pow(_Radius,2) * Math.PI);
        }
    } 
}
