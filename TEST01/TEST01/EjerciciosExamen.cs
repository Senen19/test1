

using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace TEST01
{
    class EjerciciosExamen
    {
        /*1r Ejercicio: Hacer una función a la que se le pasen dos numeros enteros
        * y devuelva el resultado de la suma de esos dos números*/
        public static int Ejercicio1(int number, int number2)
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

        public static int Ejercicio3(int num1, int num2)
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
                i += 3;
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

        /*Ejercicio 12: Función que se le pase un número n e imprima una serie de asteriscos 3 = *** */
        public static void Ejercicio12(int n)
        {
            for (int i = 0; i < n; i++)
                System.Console.Write("*");
        }

        /*Ejercicio 13: Función que se le pase un número n e imprima una serie de asteriscos 5 y + = *+*+*   */
        public static void Ejercicio13(int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0) //Si es par imrpime +
                    System.Console.Write("*");
                else //Si no, imprime +
                    System.Console.Write("+");
            }
        }


        /*Ejercicio 14: Función que se devuelva el menor de 9 enteros, la función tiene que ocupar una sola línea */

        public static int Ejercicio14(int num1, int num2, int num3, int num4, int num5, int num6, int num7, int num8, int num9)
        {
            return Ejercicio7(Ejercicio7(num1, num2, num3), Ejercicio7(num4, num5, num6), Ejercicio7(num7, num8, num9));
            //Se puede llamar a otras funciones que ya hemos hecho, es un buen truco para resolver ejercicios y ahorrar tiempo
        }


        /*Ejercicio 15: Hacer una función que reciba un valor y escriba un rectángulo de *  */

        public static void Ejercicio15(int n)
        {
            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < n; c++)
                    System.Console.Write("*");
                System.Console.WriteLine();
            }
        }

        /* Ejercicio 16: Hacer una función que reciba un valor y escriba un rectángulo con* y la siguiente fila + */

        public static void Ejercicio16(int num)
        {
            for (int i = 0; i < num; i = i + 2)
            {
                for (int j = 0; j < num; j++)
                {
                    if ((i % 2) == 0) //Si es par que imprima *
                        System.Console.Write("*");
                    else              //Si no es par que imprima +
                        System.Console.Write("+");
                }
                System.Console.WriteLine();
            }
        }

        //Ejercicio 17: Hacer una función que reciba un valor y escriba una pirámide de * 

        public static void Ejercicio17(int num)
        {
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < i + 1; j++)
                    System.Console.Write("*");
            System.Console.WriteLine();
            }
        }
       
        public static void Ejercicio18(int num) //Piramide invertida de asteriscos
                                                //Es recomendable hacer a papel como funciona la lógica del programa para buscar
                                                //el truco / la forma de resolverlo.
        {
            for (int i = 0; i < num; i++)
            {
                int nespacios = num - i - 1; //calcula el número de espacios
                int nasteriscos = i + 1; //calcula el número de asteriscos
                for (int j = 0; j < nespacios; j++) //for para imprimir los espacios
                    System.Console.Write(" ");
                for (int f = 0; f < nasteriscos; f++) //for para imprimir los asteriscos 
                    System.Console.Write("*");
                System.Console.WriteLine(); //salto de línea
            }
        }

        public static void Ejercicio19(int num) //piramide total de asteriscos vacio
        {
            for (int i = 0; i < num; i++) //Este for indica las veces que se va a repetir num, solo hace falta mirar num
                                          //para saber cuantas veces se va a repetir
            {
                int nespacios1 = num - i - 1;        //primer int para calcular el número de espacios del principio
                int nespacios2 = i * 2;              //segundo int para calcular el segundo número de espacios despúes del primer *
                for (int j = 0; j < nespacios1; j++) //for para imprimir el número de espacios del principio
                    System.Console.Write(" ");
                System.Console.Write("*");           //al finalizar el bucle, imprime el asterisco
                for (int f = 0; f < nespacios2; f++) //for para imprimir el segundo número de espacios
                    System.Console.Write(" ");
                System.Console.Write("*");           //al finalizar el segundo bucle, imprime el asterisco
                System.Console.WriteLine();          //salto de línea
            }
        }

        public static void Ejercicio20(int num) //El mismo ejercicio anterior pero con la piramide invertida
        {
            for (int i = 0; i < num; i++)
            {
                int nespacios1 = i;                 //Calcula el número de espacios del principio; vemos que corresponde con el valor de i
                int nespacios2 = (num - i - 1) * 2; //calcula el número de espacios despúes del primer *, lo hemos calculado a papael
                for (int j = 0; j < nespacios1; j++)//primer for que imprime espacios
                    System.Console.Write(" ");
                System.Console.Write("*");          //finaliza el bucle e imprime *
                for (int f = 0; f < nespacios2; f++)//segundo for que imprime los segundos espacios, los de después del primer *
                    System.Console.Write(" ");
                System.Console.Write("*");          //finaliza el bucle e imprime *
                System.Console.WriteLine();         //salto de línea y, después de esto, se repite de nuevo el bucle
            }
        }

        public static void Ejercicio21(int num) //Hacer un rombo
        {
            Ejercicio19(num);//llamas a la función que ya has hecho que hace la piramide vacia
            Ejercicio20(num);//llamas a la función que ya has hecho que hace la piramide invertida
        }

        /*Ejercicio22: Hacer una función que devuelva 2 elevado a n, siendo n el parámetro que recibe la función*/
        public static int Ejercicio22(int num)
        {
            int exponente = num;
            int result = 1;
            for (int i = 0; i < exponente; i++)
                result *= 2;
            return result;
        }

        /*Ejercicio23: Hacer una función que imrpima la bandera americana*/
        //f = filas   c = columnas
        public static void Ejercicio23() //no dice que le pases ningún parametro
        {
            for (int f = 0; f < 10; f++) //filas
            {
                for (int c = 0; c < 70; c++) //columnas
                {
                    if (0 <= c && c <= 4 && 0 <= f && f <= 2) //imprime los + de la primera zona |Entre 0 (c) 0 (f) y 2 (f) 2 (c)
                    {
                        int flag = f + c;    //Sumo las filas y columnas | Busco hacer + (espacio) + (espacio) + (espacio)
                        if ((flag % 2) == 0) //Si es par, que imprima un + (espacio) + (espacio) +
                            System.Console.Write("+");
                        else                 //Si no es par, que imprima (espacio) + (espacio) + (espacio)
                            System.Console.Write(" ");
                    }
                    else if ((f % 4) < 2)   //Si el resto de f entre 4 es menor que 2, imprime *
                        System.Console.Write("*");
                    else                    //Si el resto de f entre 4 NO es menor que 2, imprime (espacio)
                        System.Console.Write(" ");
                }
                System.Console.WriteLine();
            }
        }
            /*Hacer una función que devuelva la distancia entre dos puntos 2D*/
        public static double Ejercicio24(double x1, double y1, double x2, double y2)
        {
            double vx = x2 - x1;
            double vy = y2 - y1;
            return System.Math.Sqrt((vx * vx) + (vy * vy));
        }

        /*Hacer una función que imprima la bandera de Japón*/
        public static void Ejercicio25()
        {
            for (int f = 0; f < 15; f++)
            {
                for (int c = 0; c < 70; c++)
                {
                    if (c == 0 || c == 69 || f == 0 || f == 14) //Imprime las esquinas de la bandera
                        System.Console.Write("*");
                    else if (Ejercicio24(35, 7, c, f) <= 5) //llama a la función de distancia 2D y calcula la distancia atendiendo al radio que le digo que es 5
                        System.Console.Write("o");
                    else
                        System.Console.Write(" ");
                }
                System.Console.WriteLine();
            }
        }

        /*Implementa una función que devuelva el sumatorio de un número*/
        static public int Ejercicio26(int num)
        {
            int j = 0;
            for (int i = 1; i <= num; i++)
                j += i;
            return j;
        }
        
    }
}

       
         //Usamos un for cuando conocemos el numero de elementos que vamos a imprimir, cuando NO, mejor un while
         //MUY RECOMENDABLE calcular primero el algoritmo a papel para luego pasarlo a la función