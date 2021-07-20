using ConceptosDeProgramacion.Ejemplos;

namespace ConceptosDeProgramacion.Guia
{
    public class ComenzarAqui
    {
        static void Main(string[] args)
        {
            // En cada una de las funciones se explica un concepto
            // Realizar el debug permite visualizar la ejecucion de ConceptosDeProgramacion.Ejemplos

            // Para realizar el debug primero hay que seleccionar un punto de interrupcion
            // Hacer click izquierdo en la franja gris a la izquierda del numero 8 (Se vera un punto rojo y se resaltara la linea, el simbolo {, en rojo)
            // El debug se inicia presionando la tecla F5
            // Una vez iniciado se pasa a la siguiente instruccion con F11

            // Variables (primitivos: int, float, bool)
            Variables.TiposDeVariables();

            // Operadores Aritmeticos (+, -, *, /, %)
            Operadores.OperadoresAritmeticos();

            // Operadores de Igualdad (==, !=)
            Operadores.OperadoresDeIgualdad();

            // Operadores de Comparacion (<, >, <=, >=)
            Operadores.OperadoresDeComparacion();

            // Funciones (static)
            Funciones.Estaticas();

            // Realizar Ejercicio1
        }
    }
}
