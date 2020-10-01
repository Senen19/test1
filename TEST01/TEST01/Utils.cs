
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
        //ISEven devuelve True si el valor es par 
        //y false en caso contrario
        public static bool IsEven(int value)
        {
            if ((value % 2) == 0)

                return true;
            else
                return false;

            

        }
    }
}
