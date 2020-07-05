using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuadraticProj
{
    //public class Quadratic
    //{
    //    public double A { get; set; }
    //    public double B { get; set; }
    //    public double C { get; set; }

    //    public Quadratic(double a, double b, double c)
    //    {
    //        this.A = a;
    //        this.B = b;
    //        this.C = c;
    //    }

    //    public string Answer()
    //    {
    //        double D = 0;
    //        string result = string.Empty;

    //        if (A != 0)
    //        {
    //            D = B * B - 4 * A * C;
    //            if (D < 0)
    //            {
    //                result += "Рівняння коренів немає";
    //            }
    //            else if (D == 0)
    //            {
    //                if (-B / (2 * A) % 1 == 0)
    //                    result += string.Format("x = {0}", -B / (2 * A));
    //                else
    //                    result += string.Format("x = {0}/{1}", -B, 2 * A);
    //            }
    //            else if (D > 0)
    //            {
    //                if (((-B + Math.Sqrt(D)) / (2 * A)) % 1 == 0)
    //                    result += string.Format("x1 = {0}, ", (-B + Math.Sqrt(D)) / (2 * A));
    //                else
    //                    result += string.Format("x1 = {0}/{1}, ", (-B + Math.Sqrt(D)), A * 2);
    //                if (((-B - Math.Sqrt(D)) / (2 * A)) % 1 == 0)
    //                    result += string.Format("x2 = {0}", (-B - Math.Sqrt(D)) / (2 * A));
    //                else
    //                    result += string.Format("x2 = {0}/{1}", (-B - Math.Sqrt(D)), A * 2);
    //            }
    //        }
    //        else
    //            result += "Не вірно задані корені рівняння";

    //        return result;
    //    }
    //}
}
