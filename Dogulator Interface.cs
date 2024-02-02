using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_2_1
{
    internal interface Dogulator_Interface
    {
        double Addition(double x, double y);
        double Subtraction(double x, double y);
        double Multiplication(double x, double y);
        double Division(double x, double y);
        string Dogulate(string x);
    }
    class Calculations : Dogulator_Interface
    {
        public double Addition(double x, double y)
        {
            return x + y;
        }

        public double Division(double x, double y)
        {
            return x / y;
        }

        public string Dogulate(string x)
        {
            if (x == "1")
                return "15";
            else if (x == "2")
                return "24";
            else if (x == "3")
                return "28";
            else if (x == "4")
                return "32";
            else if (x == "5")
                return "36";
            else if (x == "6")
                return "42";
            else if (x == "7")
                return "47";
            else if (x == "8")
                return "51";
            else if (x == "9")
                return "56";
            else if (x == "10")
                return "60";
            else if (x == "11")
                return "65";
            else if (x == "12")
                return "69";
            else if (x == "13")
                return "74";
            else if (x == "14")
                return "78";
            else if (x == "15")
                return "83";
            else if (x == "16")
                return "87";
            else
                return "Immortal";
        }

        public double Multiplication(double x, double y)
        {
            return x * y;
        }

        public double Subtraction(double x, double y)
        {
            return x - y;
        }
    }
}

