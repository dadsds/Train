using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleNamespace
{
    public class Triangle
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

            if (!IsTriangle)
            {
                throw new ArgumentException("One or more sides of triangle are invalid");
            }
        }

        public double S
        {
            get
            {
                double p;
                p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }

        private bool IsTriangle
        {
            get
            {
                return a + b > c && a + c > b && b + c > a;
            }
        }
    }
}
