

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

        /*Ejercicio 5: Hacer una función a la que se le pasen 3 strings y devuelva la concatenación de 
         * los 3 strings */

        public static string Ejercicio5(string message1, string message2, string message3) //Se suele llamar Cat que significa concatenar
        {
            return message1 + message2 + message3;
        }

        /* Ejercicio 6: Hacer una función que reciba 2 enteros y devuelva -1 si el primero es menor que el segundo, +1 si el segundo es
         menor que el primero, y 0 en cualquier otro caso (que sean iguales)*/

        public static int Ejercicio6(int num1, int num2)
        {
            if (num1 < num2)
                return -1;
            if (num1 > num2)
                return +1;
            return 0;
        }

        /*Ejercicio 7: Hacer una función que te devuelva el menor de tres enteros*/

        public static int Ejercicio7(int a, int b, int c)
        {
            if (a <= b && a <= c) // Con esta comprobamos si es a o si la eliminamos
                return a;
            if (b < c) //una vez elminada a, solo queda comprobar b y c
                return b;
            else 
                return c;
        }

        /*Replica del ejercicio 7 pero de otra forma --óptima-- */
        /* public static int Ejercicio7yMedio(int a, int b, int c) //Aquí solo se inician dos procesos, en la anterior al menos 3 o 4
         {
             if (a <= b)
             {
                 return a;
             else
                 return c;
             }   
             else
             {
                 if (b < c)
                     return b;
                 else c;
             }    
         }
        */

        /*Ejercicio 8: Hacer una función que reciba un código de error e imprima por pantalla lo siguiente
         * "Error grave" si el código de error es 0
         * "Error moderado" si el código de error es 1
         * "Error leve" si el código de error es 2
         * "Error desconocido" en cualquer otro caso*/
        public static void Ejercicio8(int num) //Si no dice que devuelve, CASI SIEMPRE será void
        {
            switch (num)
            {
                case 0:
                    System.Console.WriteLine("Error grave");
                    break;
                case 1:
                    System.Console.WriteLine("Error moderado");
                    break;
                case 2:
                    System.Console.WriteLine("Error leve");
                    break;
                default: //En cualquier otro caso
                    System.Console.WriteLine("Error desconocido");
                    break;
            }
        }

        /*Ejercicio 9: Crear una función a la que se le pase un número e imprima por pantalla una serie como
         * la siguiente 10, imprima 0, 3, 6, 9... */

        public static void Ejercicio9(int num)
        {

            /*for (int i = 0; i <= num; i = i + 3)
            {
                System.Console.Write(i +" , ");
            }*/

            int i = 0;
            while (i <= num)
            {
                System.Console.Write(i + ", ");
                i+= 3;
            }
        }

        /*Ejercicio 10: Hacer una función que imprima por pantalla la siguiente serie, usando un for,
         * serie (10): 0,1,2,3,4,5,6,7,8,9*/
         
        public static void Ejercicio10(int num)
        {
            for (int i = 0; i < num; i++) //Cuando tiene solo 1 instrucción, no hace falta poner las {}
                System.Console.Write(i + ", ");
        }

        /*Ejercicio 11: Hacer una función igual que la anterior pero eliminando la coma ',' final **/

        public static void Ejercicio11(int num)
        {
            for (int i = 0; i < num; i++)  //Cuando tiene solo 1 instrucción, no hace falta poner las {}
            {
                System.Console.Write(i);
                if (i < num - 1)
                    System.Console.Write(", ");
            }
        }

        public static void Ejercicio11yMedio(int num) //Solución óptima
        {
            for (int i = 0; i < num - 1; i++)  //Cuando tiene solo 1 instrucción, no hace falta poner las {}
                System.Console.Write(i + ",");
            System.Console.Write(num - 1);
        }
    }
}
        //Usamos un for = cuando conocemos el numero de elementos que vamos a imprimir, cuando NO, mejor un while