using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntTest
{
    public static class SecondFunction
    {
        
       public static double getLogarithm(double x, double baseshark)
        {
            double precision = 0.0001; // точность/начальное значение

            do // вычисляем по методу перебора
            {
                precision += 0.000001;

            } while (Math.Pow(baseshark, precision) < x);

            return precision;

        }

    }
}
