
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
            int i = 2;                          //iniciamos el contador en 2 porque si lo iniciamos en 0 cuando
                                                //llegue a 1 dirá que ya es primo.

            while (i < number)                  //Mientras que el contador(i) sea más pequeño que el número que 
                                                //queramos saber si es primo o no...
            {
                if ((number % i) == 0)          //Para que se cumpla la cond. el número que elijamos entre contador, su resto
                                                // deberá ser igual a 0, en ese caso será primo.
                    return false;               // si esto no ocurre dará false, es decir, no es primo. El contador se incrementará en 1
                                                // hasta que deje de cumplirse la condición del while para comprobar así todos
                                                //los valores posibles en la variable number.

                i++;                          
            }
            return true;                        //si se cumple la condición del if, dará un true. Cuando la condición del while deje
                                                //de cumplirse saldrá del bucle y nos encontraremos con tantos 'true' como 'false'
                                                //se haya incrementado el contador 'i' hasta llegar al número que hayamos introducido
                                                //en la variable 'number'. En caso de que alguna vez dentro del bucle se haya cumplido
                                                //la condición del if, nos habrá devuelto un valor 'true'. Por tanto, como hemos
                                                //creado una función que debe devolver o 'true' o 'false' al ser bool, indicaremos que
                                                //solo nos devuelva los valores true que hemos obtenido del bucle tras comprobar
                                                //'number' de veces con el condicional if si es primo('true') o no('false'). Si 
                                                //indicamos que nos devuelva true, solo nos lo devolverá si la variable 'number' es
                                                //primo.

        }
    }
}
