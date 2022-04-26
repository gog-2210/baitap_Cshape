using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDiemDanh_26_4
{
    internal class Cau1
    {
        private double a;
        private double b;
        private double c;

        public QuadraticEquation()
        {
        }

        public QuadraticEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double getA()
        {
            return a;
        }

        public void setA(double a)
        {
            this.a = a;
        }

        public double getB()
        {
            return b;
        }

        public void setB(double b)
        {
            this.b = b;
        }

        public double getC()
        {
            return c;
        }

        public void setC(double c)
        {
            this.c = c;
        }

        public double getDiscriminant()
        { //Tính delta
            return b * b - 4 * a * c;
        }

        public double getRoot1()
        { //tính nghiệm x1
            return (-b + Math.Sqrt(this.getDiscriminant())) / 2 * a;
        }

        public double getRoot2()
        { //tính nghiệm x2
            return (-b - Math.Sqrt(this.getDiscriminant())) / 2 * a;
        }
        static void Main(string[] args)
        {
            
        }
    }
}
