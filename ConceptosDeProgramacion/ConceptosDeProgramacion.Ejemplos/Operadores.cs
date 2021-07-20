// Las siguientes dos lineas indican a Visual Studio ignorar el uso innecesario de variables en este archivo
#pragma warning disable CS0219 // Variable is assigned but its value is never used
#pragma warning disable IDE0059 // Unnecessary assignment of a value

namespace ConceptosDeProgramacion.Ejemplos
{
    // Documentacion oficial
    // https://docs.microsoft.com/es-es/dotnet/csharp/language-reference/operators/

    public class Operadores
    {
        public static void OperadoresAritmeticos()
        {
            // Los operadores aritmeticos representan computaciones entre dos operandos

            // +
            // Operador de suma
            // Ejemplos de suma
            float resultadoA;
            // Sintaxis: variableResultado = operandoA operador operandoB;
            resultadoA = 1f + 2f; // 3
            // Se puede declarar una variable en la misma linea donde se realiza el operador
            // Sintaxis: tipoDeDato variableResultado = operandoA operador operandoB;
            float resultadoB = 1f + 4f; // 5
            float resultadoC = 3f + 4f; // 7

            // Al usar operadores los operando pueden ser variables
            float tres = 3f;
            float cuatro = 4f;
            float resultadoD = 3f + 4f; // 7
            float resultadoE = 3f + cuatro; // 7
            float resultadoF = tres + cuatro; // 7

            // +
            // Operador de resta
            // Ejemplos de resta
            float resultadoG = 2f - 1f; // 1
            float resultadoH = 1f - 4f; // -3
            float resultadoI = 4f - 3f; // 1

            // *
            // Operador de multiplicacion
            // Ejemplos de multiplicacion
            float resultadoJ = 2f * 1f; // 2
            float resultadoK = 2f * 4f; // 8
            float resultadoL = 4f * 3f; // 12

            // /
            // Operador de division
            // Ejemplos de division
            float resultadoM = 2f / 1f; // 2
            float resultadoN = 6f / 4f; // 1.5
            float resultadoO = 3f / 4f; // 0.75

            // Nota: La division entre numeros enteros se trunca a su valor entero (no se redondea)
            // Ejemplo 14 / 5 = 2.8, al truncarse a su valor entero da como resultado 2
            int resultadoEnteroP = 14 / 5; // 2

            // %
            // Operador de modulo (resto de division entera, es distinto al modulo del valor absoluto)
            // Ejemplos de modulo
            int resultadoEnteroQ = 4 % 2; // 0
            int resultadoEnteroR = 5 % 2; // 1
            int resultadoEnteroS = 5 % 10; // 5
        }

        public static void OperadoresDeIgualdad()
        {
            // Los operadores de comparacion comprueban si los operandos son iguales
            // Su resultado es siempre un bool, true o false

            // ==
            // Operador de igualdad
            // Retorna true si los dos operandos son iguales, de lo contrario false
            // Ejemplos
            bool resultadoA = 1 == 1; // true
            bool resultadoB = 10f == 10f; // true
            bool resultadoC = true == true; // true
            bool resultadoD = false == false; // true
            bool resultadoE = 2 == 1; // false
            bool resultadoF = 10f == 15f; // false
            bool resultadoG = true == false; // false
            bool resultadoH = false == true; // false

            // !=
            // Operador de desigualdad
            // Retorna true si los dos operandos son distintos, de lo contrario true
            // Ejemplos
            bool resultadoI = 1 != 1; // false
            bool resultadoJ = 10f != 10f; // false
            bool resultadoK = true != true; // false
            bool resultadoL = false != false; // false
            bool resultadoM = 2 != 1; // true
            bool resultadoN = 10f != 15f; // true
            bool resultadoO = true != false; // true
            bool resultadoP = false != true; // true
        }

        public static void OperadoresDeComparacion()
        {
            // Los operadores de comparacion representan comparaciones entre dos operandos
            // Su resultado es siempre un bool, true o false

            // <
            // Menor que
            // El operador < devuelve true si el operando izquierdo es menor que el derecho; en caso contrario, devuelve false.
            bool resultadoA = 0.0f < 1.5f; // true
            bool resultadoB = 1.5f < 1.5f; // false
            bool resultadoC = 3f < 1.5f; // false

            // >
            // Mayor que
            // El operador > devuelve true si el operando izquierdo es mayor que el derecho; en caso contrario, devuelve false.
            bool resultadoD = 0.0f > 1.5f; // false
            bool resultadoE = 1.5f > 1.5f; // false
            bool resultadoF = 3f > 1.5f; // true

            // <=
            // Menor o igual que
            // El operador <= devuelve true si el operando izquierdo es menor o igual que el derecho; en caso contrario, devuelve false.
            bool resultadoG = 0.0f <= 1.5f; // true
            bool resultadoH = 1.5f <= 1.5f; // true
            bool resultadoI = 3f <= 1.5f; // false

            // >=
            // Mayor o igual que
            // El operador >= devuelve true si el operando izquierdo es mayor o igual que el derecho; en caso contrario, devuelve false.
            bool resultadoJ = 0.0f >= 1.5f; // false
            bool resultadoK = 1.5f >= 1.5f; // true
            bool resultadoL = 3f >= 1.5f; // true
        }
    }
}

#pragma warning restore CS0219 // Variable is assigned but its value is never used
#pragma warning restore IDE0059 // Unnecessary assignment of a value
