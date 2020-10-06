
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
        public static void Ejercicio3 (bool num1) //establecemos un nuevo void en nuestra clase 'ejercicios' para realizar
                                                  //el ejercicio número 3, con lo que creamos una nueva clase que no devuelva nada (void).
                                                  //Creamos una variable bool ya que el resultado de la función 'Utils.Ejercicio3'
                                                  //nos devolverá un 'true' o 'false' dependiendo si es primo o no.
        {
            num1 = Utils.Ejercicio3(84);          //En la variable tipo bool denominada num1, llamamos a la función que nos dice si un número
                                                  //es primo o no 'Utils.Ejercicio3'. En este caso he elegido el 84, el cual se asigna 
                                                  //al parámetro de la
                                                  //variable number de la función que se encuentra en 'Utils'. Con ello, comenzará
                                                  //a realizar toda la función que se encuentra en 'Utils' considerando a 84 como
                                                  //la variable 'number'.
            
            System.Console.WriteLine(num1);       //Le pedimos que imprima/muestre el resultado de la variable num1 una vez haya
                                                  //pasado ya por la función 'Utils.Ejercicio3' y haya comprobado si es primo o no.  
        }



    }


}
