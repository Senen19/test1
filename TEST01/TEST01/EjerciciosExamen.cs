

namespace TEST01
{
    class EjerciciosExamen
    {  
       /*1r Ejercicio: Hacer una función a la que se le pasen dos numeros enteros
       * y devuelva el resultado de la suma de esos dos números*/
        public static int Ejercicio1 (int number, int number2)
        {
            int result = number + number2;
            return result; //se puede hacer también return number + number2; | Es más mejor
        }

        /*2. Ejercicio: Hacer una función que reciba dos reales y devuelva la resta de esos dos reales*/
        public static double Ejercicio2(double num, double num2)
        {
            return num - num2;

        }

        /*3r Ejercicio: Hacer una función a la que se le pasen dos enteros
         * y devuelva el menor de ellos*/

        public static int Ejercicio3 (int num1, int num2)
        {
            if (num1 < num2)
                return num1;
            else
                return num2;

        }

        /*Ejercicio 4: Hacer una función que reciba como parámetros dos enteros
         * y devuelva si el primer es menor que el segundo*/

        public static bool Ejercicio4(int num1, int num2)
        {
            if (num1 < num2)
                return true;
            else
                return false;

            //otro opción de 10: return num1<num2; --> Esto devuelve true o false
        }
    }
}
