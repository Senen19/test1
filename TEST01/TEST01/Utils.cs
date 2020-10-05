
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
        public static bool Ejercicio3(int number)//pregunta examen
        {
            int i = 2;//iniciamos el contador en 2 porque si lo iniciamos en 0 cuando
                       // llegue a 1 dirá ya que es primo
            while (i < number) 
            {
                if ((number % i) == 0) //el número que elijamos entre contador será igual a 0, entonces será primo
                    return false;      // si esto no ocurre dará false y se incrementará
                i++;
            }
            return true;

        }
    }
}
