using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigureTester
{
    interface IShape
    {

        double Area
        {
            get;
        }
        double GetArea();
        double GetPerimiter();



    }
}
//    class Parallelogram : GeometricFigure
//    {
//        private double a;
//        private double b;
//        private double angle1;

//        public Parallelogram(double a, double b, double angle1)
//        {
//            this.a = a;
//            this.b = b;
//            this.angle1 = angle1;

//        }
//        public virtual double Height()
//        {
//            return b * (int)(angle1); 
//        }

//        public double Angle2
//        {
//            get { return 180 - angle1; }
//        }
//        public override double Area()
//        {
//            return a * Height();
//        }

//        public override double Perimeter()
//        {
//            return 2 * (a + b);
//        }
//    }

//    class Rhomb : Parallelogram
//    {
//        private double a;
//        private double angle1;
//        public Rhomb(double a, double angle1) : base(a, a, angle1)
//        {
//            this.a = a;
//            this.angle1 = angle1;
//        }
//        public override double Height()
//        {
//            return a * (int)Math.Sin(angle1);
//        }

//    }
//    class Rectangle : Parallelogram
//    {
//        private double a;
//        private double b;
//        public Rectangle(double a, double b) : base(a, b, 90) {
//            this.a = a;
//            this.b = b;
//        }
//        public override double Area() {
//            return a * b;
//        }
//    }
//    class Square : Rectangle {
//        private double a;
//        public Square(double a) : base(a, a) {
//            this.a = a;
//        }
//        public override double Area()
//        {
//            return a * a;
//        }
//    }



//}