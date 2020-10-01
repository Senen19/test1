
namespace TEST01
{
    class Utils 
    {
        public static int GetMinValue(int a, int b)
        {
            if (a < b)
                return a;
            else
                return b;  
        }
        public static int GetMaxValue(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }

        }
    }
}
