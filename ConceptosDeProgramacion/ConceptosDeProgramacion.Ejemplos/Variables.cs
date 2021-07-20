// Las siguientes dos lineas indican a Visual Studio ignorar el uso innecesario de variables en este archivo
#pragma warning disable CS0219 // Variable is assigned but its value is never used
#pragma warning disable IDE0059 // Unnecessary assignment of a value

namespace ConceptosDeProgramacion.Ejemplos
{
    // Documentacion oficial
    // https://docs.microsoft.com/es-es/dotnet/csharp/language-reference/builtin-types/value-types

    public class Variables
    {
        public static void TiposDeVariables()
        {
            // Una variable almacena un valor de un tipo especifico
            // Se declaran con su tipo y un nombre
            // Sintaxis: tipoDeDato nombreVariable;

            // En esta primer etapa se utilizaran tres tipos de variables: int, float y bool.


            // int
            // Una variable de tipo int, almacena un numero entero
            // Ejemplo declaracion
            int numeroEntero;
            // Si no se les asigna un valor, las variables se generan con un valor por defecto (en caso de int es el numero 0)

            // Para asignarle un valor a una variable se utiliza el simbolo =
            // Sintaxis: nombreVariable = valor;
            // A esta operacion se la denomina asignacion
            // Ejemplo asignando el valor 1 a la variable numeroEntero
            numeroEntero = 1;
            // A una variable se le puede asignar valor mas de una vez, sobrescribiendo el valor anterior
            // Ejemplo asignando el valor 5 a la variable numeroEntero
            numeroEntero = 5;

            // Para simplicar la escritura, se puede declarar una variable y asignarle valor en una misma linea
            // Con la sintaxis:
            // tipoDeDato nombreVariable = valor;
            // Ejemplo declarando variable uno de tipo int con valor 1
            int uno = 1;

            // A una variable se le puede asignar el valor de otra variable
            // Ejemplo asignando el valor de la variable uno (1) a numeroEntero
            numeroEntero = uno;

            // Ejemplos de int
            int cuarenta = 40;
            int menosQuince = -15;
            int trecientos = 300;


            // float
            // Una variable de tipo float, almacena un numero decimal.
            // Para indicar un numero como float se incluye la letra f concatenada al final del numero
            float unoFlotante = 1f;
            // Los valores enteros se separan de los decimales mediante el .
            float unoComaCinco = 1.5f;

            // Ejemplos de float
            float pi = 3.14f;
            float unMedio = 0.5f;


            // bool
            // Una variable de tipo bool, almacena un valor de verdadero (true) o falso (false).
            // Los valores bool son relevantes para la ejecucion condicional
            // Ejemplos de bool
            bool verdadero = true;
            bool falso = false;
        }
    }
}

#pragma warning restore CS0219 // Variable is assigned but its value is never used
#pragma warning restore IDE0059 // Unnecessary assignment of a value
