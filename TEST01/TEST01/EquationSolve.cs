using System;
using System.Collections.Generic;
using System.Text;

namespace TEST01
{
    class EquationSolve //Se ha creado una nueva 
    {
        static public double EquationSolve2(double a, double b, double c)
        {
            double aux1, x1;

            aux1 = (System.Math.Sqrt(b * b - 4 * a * c));
            x1 = (-b + aux1) / (2 * a);
            return x1;

        }
         static public double EquationSolve1(double a, double b) => -b / a;



    }
}
