
namespace TEST01
{
    class Geometry
    {
        public static double Get2DVectorLength (double x, double y)
        {
            double aux1, lenght;

            aux1 = (x * x) + (y * y);
            lenght = System.Math.Sqrt(aux1);

            return lenght;

        }
        public static double Get3DVectorLength (double x, double y, double z)
        {


        }
    }
}
