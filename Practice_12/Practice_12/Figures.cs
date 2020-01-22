using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_12
{
    abstract class Figures
    {
        public string Name { get; set; }

        public Figures ( string name)
        {
            Name = name;
        }
        public abstract double figureArea();
    }

    class Circle : Figures
    {
        private double _Radius { get; set; }

        public Circle(string name, double _radius) : base(name)
        {
            _Radius = _radius;
        }

        public override double figureArea()
        {
            return Math.Round (2 * Math.PI * Math.Pow(_Radius, 2));
        }
    }

    class Square : Figures
    {
        private double _SquareSide { get; set; }
        
        public Square (string name, double _squareSide) : base(name)
        {
            _SquareSide = _squareSide;
        }

        public override double figureArea()
        {
            return Math.Round (Math.Pow(_SquareSide, 2));
        }
    }

    class Triangle : Figures
    {
        private double _TriangleSide { get; set; }

        public Triangle(string name, double _triangleSide) : base(name)
        {
            _TriangleSide = _triangleSide;
        }

        public override double figureArea()
        {
            return Math.Round (0.5 * _TriangleSide * Math.Sqrt(Math.Pow(_TriangleSide, 2) - (Math.Pow(_TriangleSide, 2) / 4)));
        }
    }

}
