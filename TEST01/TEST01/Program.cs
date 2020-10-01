using System;

namespace TEST01
{
    class Program
    {
        static void Main(string[] args)
        {
            double s1, s2, S1, S2;

            s1 = Geometry.Get2DVectorLength(1, 1);
            System.Console.WriteLine(s1);
            s2 = Geometry.Get2DVectorLength(89.3, 57);
            System.Console.WriteLine(s2);

            S1 = Geometry.Get3DVectorLength(0, 1, 1);
            System.Console.WriteLine(S1);
            S2 = Geometry.Get3DVectorLength(5.3, 6.3, -7);
            System.Console.WriteLine(S2);

        }
    }
}
