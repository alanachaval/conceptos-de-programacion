// Las siguientes dos lineas indican a Visual Studio ignorar el uso innecesario de variables en este archivo
#pragma warning disable IDE0059 // Unnecessary assignment of a value

namespace ConceptosDeProgramacion.Ejemplos
{
    public class Funciones
    {
        public static void Estaticas()
        {
            // Una funcion es una secuencia de instrucciones
            // Para llamar una funcion, se escribe su nombre y luego parentesis
            // entre los parentesis se incluyen los parametros si los hubiere
            // Ejemplo llamado a funcion
            int enteroA = DevolverUno();

            int enteroB = DevolverValor(5);

            int enteroC = SumarValores(enteroA, enteroB);
        }

        public static int DevolverUno()
        {
            // Se definen por su modificador de acceso, nombre y tipo de retorno
            // public: modificador de acceso, indica que no tiene reestricciones de acceso
            // static: (opcional) indica que la funcion es estatica, una funcion estatica pertenece a la propia clase en vez de a un objeto
            // int: tipo de retorno, en este caso indica que devuelve un entero
            // DevolverUno: nombre de la funcion

            // La instruccion return indica el valor a retornar por la funcion
            return 1;
        }

        public static int DevolverValor(int valor)
        {
            // Las funciones pueden recibir parametros
            // Los parametros son las forma de pasar valores a una funcion
            // Dentro de la funcion los parametros son variables cuyo valor se asigna en el momento de la llamada

            return valor;
        }

        public static int SumarValores(int valorA, int valorB)
        {
            // Las variables declaradas dentro de una funcion existen dentro de la funcion
            // Solo tienen valor y pueden ser utilizadas dentro de la funcion donde son declaradas
            int resultado = valorA + valorB;
            return resultado;
        }
    }
}

#pragma warning restore IDE0059 // Unnecessary assignment of a value
