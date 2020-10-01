using System;

namespace TEST01
{
    class Program
    {
        static void Main(string[] args)
        {
            double s1, s2, S1, S2, min1, min2, max1, max2;

            s1 = Geometry.Get2DVectorLength(1, 1);
            System.Console.WriteLine(s1);
            s2 = Geometry.Get2DVectorLength(89.3, 57);
            System.Console.WriteLine(s2);

            S1 = Geometry.Get3DVectorLength(1, 1, 1);
            System.Console.WriteLine(S1);
            S2 = Geometry.Get3DVectorLength(5.3, 6.3, -7);
            System.Console.WriteLine(S2);

            min1 = Utils.GetMinValue(3, 1);
            System.Console.WriteLine(min1);
            min2 = Utils.GetMinValue(1, 1);
            System.Console.WriteLine(min2);

            max1 = Utils.GetMaxValue(3, 1);
            System.Console.WriteLine(max1);
            max2 = Utils.GetMaxValue(1, 1);
            System.Console.WriteLine(max2);
        }
    }
}
