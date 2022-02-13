using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haromszog
{
    class Haromszog
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }

        public Haromszog(double a_, double b_, double c_)
        {
            a = a_;
            b = b_;
            c = c_;
        }

        public bool szerkesztheto()
        {
            return a + b > c && a + c > b && b + c > a;
        }

        public double kerulet()
        {
            return a + b + c;
        }

        public double terulet()
        {
            double s = kerulet() / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
    }
}
