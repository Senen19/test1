
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
        public static void Ejercicio3 (bool num1)
        {

            num1 = Utils.Ejercicio3(5894);

        }



    }


}
