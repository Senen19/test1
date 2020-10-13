
using System.Runtime.Serialization;
using System.Threading;

namespace TEST01
{
    class ejercicios
    {
        //Ejercicio: Hacer una función que imprima por pantalla los números
        //           del 0 al 99.
        public static void Ejercicio()
        {
            int contador;
            contador = 0;
            while (contador < 100)
            {
                System.Console.WriteLine(contador);
                contador = contador + 1;
                //contador += 1; Incrementa en 1, otra opción al de arriba 
                //contador ++; Incrementa en 1, otra opción al de arriba
            }
        }
        //Ejercicio2: Haz una función que imprima los números pares que hay desde el 0 hasta n
        public static void Ejercicio2 (int n)
        {
            int i; //i es un nombre tipico de la variable contador
            i = 0;
            while (i < n)
            {
                if (Utils.IsEven(i))
                    System.Console.WriteLine(i);
                i++;
            }
        }
        public static void Ejercicio3 (int num1)                                      
        {
            bool num = Utils.Ejercicio3(num1);
            if (num == true)
                System.Console.WriteLine($"El número {num1} es primo");
            else
                System.Console.WriteLine($"El número {num1} no es primo");                                                              
        }
        //Ejercicio 4
        //Hacer un programa que imprima una serie desde el 0 al 100.
        public static void Ejercicio4(int num)
        {
            int i = 0;
            while(i < num)
            {
               System.Console.WriteLine(i);  
                i++;
            }


        }
        //Ejercicio 5 calcular multiplos de 3.
        public static void Ejercicio5(int num)
        {
            int i = 0;
            while(i < num)
            {
                System.Console.WriteLine(i*3);
                i++;
            }

        }

        public static void Ejercicio6(int num)
        {
            int i = 0;
            while(i < num)
            {
                System.Console.WriteLine(i * i);
                i++;

            }
        }
        public static void Ejercicio7(int num)

        {
            int i = 0;
            while (i < num)
            {
                System.Console.WriteLine((i * i) + 1);
                i++;
            }

        }
        public static void Ejercicio8(int num)
        {
            int i = 0;
            while (i < num)
            {
                System.Console.WriteLine(5 - i);
                i++;
            }
        }
        public static void Ejercicio9(int num)

        {
            int i = 0;
            while (i < num)
            {
                if (Utils.IsEven(i)) //((i % 2) == 0)
                    System.Console.WriteLine(i);
                else 
                    System.Console.WriteLine(-i);
                i++;
            }
        }
        public static void Ejercicio10(int num)//fibonacci
                
        {
            int a = 0; //anterior
            int aa = 1; //anteanterior
            int i = 0;
            System.Console.WriteLine(0);
            while (i <= num)
            {
                System.Console.WriteLine(a + aa);//se IMPRIME la sucesión: es el anterior más el anteanterior
                int aux = a; //se crea una variable aux para almacenar el valor de a y no perderlo cuando hagamos la suma
                a = a + aa; //a es igual al número anterior de la sucesión más el anteanterior de la situación, obteniendo así el siguiente de la sucesión
                aa = aux; // el anteanterior, después de haber seguido la sucesión, pasa a ser el anterior (a) que lo almacenabamos en la variable auxiliar para no perderlo
                i++; //incrementa el bucle nada más
            }
        }

    }


}
