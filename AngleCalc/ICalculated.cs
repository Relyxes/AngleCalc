using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Application
{
    public interface ICalculated
    {
        double DegToRad(double degries);

        double RadToDeg(double radians);

        double DegToMdu(double degries);

        double MduToDeg(double mdu);

        double LegLength(double distance, double degries);

        double AngleOnField(double distance, double height);

    }
}
