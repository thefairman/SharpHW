using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
    abstract class GeometryShape
    {
        abstract public double Area { get; }
        abstract public double Perimeter { get; }
    }

    class Traingle : GeometryShape
    {
        public override double Area => throw new NotImplementedException();

        public override double Perimeter => throw new NotImplementedException();
    }

    class Square : GeometryShape
    {
        public override double Area => throw new NotImplementedException();

        public override double Perimeter => throw new NotImplementedException();
    }

    class Rhombus : Parallelogram
    {
        public Rhombus(double BaseLength, double HeightLength) : base(BaseLength, HeightLength, Math.Asin(HeightLength / BaseLength) * (180.0 / Math.PI)) { }
    }

    class Rectangle : Parallelogram
    {
        public Rectangle(double BaseLength, double HeightLength) : base(BaseLength, HeightLength, 90.0) { }
    }

    class Parallelogram : GeometryShape, ISimpleNSquare
    {
        public double SideLength { get; }
        double _leftBottomAngle;
        public Parallelogram(double BaseLength, double HeightLength, double AcuteAngle)
        {
            if (BaseLength <= 0)
                throw new Exception("BaseLength не должная равняться нулю!");
            if (HeightLength <= 0)
                throw new Exception("HeightLength не должная равняться нулю!");
            CheckAcuteAngle(AcuteAngle);
            Base = BaseLength;
            Height = HeightLength;
            _leftBottomAngle = AcuteAngle;
            if (AcuteAngle == 90.0)
                SideLength = HeightLength;
            else
            {
                if (HeightLength >= BaseLength)
                    throw new Exception("HeightLength не должна быть больше или равна BaseLength!");
                SideLength = HeightLength / Math.Sin(AcuteAngle * Math.PI / 180);
            }
        }

        protected void CheckAcuteAngle(double AcuteAngle)
        {
            if (AcuteAngle <= 0 || AcuteAngle > 90.0)
                throw new Exception("Не корректный острый угол!");
        }

        public override double Perimeter => (Base + SideLength) * 2;

        public override double Area => Base * Height;

        public virtual double Angle => _leftBottomAngle;

        public virtual List<double> SidesLength => new List<double> { Base, SideLength, Base, SideLength };

        public double Height { get; set; }

        public double Base { get; set; }

        public int SidesCount => 4;
    }

    class Trapezoid : Parallelogram
    {
        public double SecondBase { get; }
        public double SecondAngle { get; }

        public Trapezoid(double BaseLength, double HeightLength, double AcuteAngle, double SecondBase)
        {

        }
        public override double Area => throw new NotImplementedException();

        public override double Perimeter => throw new NotImplementedException();

        public override List<double> SidesLength => new List<double> { Base, SideLength, Base, SideLength };
    }

    class Circle : GeometryShape
    {
        public override double Area => throw new NotImplementedException();

        public override double Perimeter => throw new NotImplementedException();
    }

    class Ellipse : GeometryShape
    {
        public override double Area => throw new NotImplementedException();

        public override double Perimeter => throw new NotImplementedException();
    }
}
