
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

            while (i < number)                  //While se ejecutará mientras que el contador(i) sea más pequeño que el número que 
                                                //queramos saber si es primo o no('number')...
            {
                if ((number % i) == 0)          //Para que se cumpla la condición, el número ('number') que elijamos entre contador, su resto
                                                //deberá ser igual a 0, en ese caso será primo.
                    return false;               //Si el if no se cumple nos dirijirá a 'return false;', es decir, no es primo. El contador se incrementará en 1
                                                //mientras el if se cumpla hasta que deje de cumplirse la condición del while para comprobar así todos
                                                //los valores posibles en la variable number. En el caso de que la condición if NO se cumpla,
                                                //lo que devolverá es 'return false' y terminará la función, ya que al recibir un return las funciones que
                                                //son diferentes a void terminan. En este caso, si el if se cumple recibirá un true y seguirá el bucle
                                                //hasta agotar la condición del while o no se cumpla la condición del if.
                                                //En esta función de tipo bool, un 'false' es admitido en el return, con lo que al recibir el return una vez
                                                //cumplida la condición terminará la función y entonces, al no cumplirse el IF, sabremos que el valor de 'number'
                                                //no es un número primo ya que su resto será diferente de 0.

                i++;                          
            }
            return true;                        //si se cumple la condición del if, dará un true y el bucle seguirá omitiendo el 'return false', 
                                                //con lo que el contador seguirá aumentando hasta que deje de cumplirse la condición de while.
                                                //Cuando la condición del while deje
                                                //de cumplirse saldrá del bucle y la función nos dirijirá a 'return true', es decir 'number' es un número primo.
                                                //porque se ha cumplido la condición del if y se ha agotado la condición del while. En caso de que alguna vez dentro del bucle NO se haya cumplido
                                                //la condición del if, nos remitirá a 'return false'. Por tanto, la función estará terminada.
                                               
        }
    }
}
