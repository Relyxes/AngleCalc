using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Application
{
    public sealed class Calculate : ICalculated
    {

        private const double smallDivideAngle = 0.06;
        private const double PiGrad = 180;
        private const double halfPiGrad = 90;

        public Calculate()
        {

        }

        public double DegToMdu(double degries)
        {
            return degries / smallDivideAngle;
        }
              
        public double DegToRad(double degries)
        {
            return degries * Math.PI / PiGrad;
        }
               
        public double MduToDeg(double mdu)
        {
            return smallDivideAngle * mdu;
        }

        public double RadToDeg(double radians)
        {
            return radians * PiGrad / Math.PI;
        }

        public double LegLength(double distance, double degries)
        {
            return distance * Math.Cos(DegToRad(halfPiGrad - degries));
        }

        public double AngleOnField(double distance, double height)
        {            
            return RadToDeg(Math.Atan(height / distance));
        }
    }
}
