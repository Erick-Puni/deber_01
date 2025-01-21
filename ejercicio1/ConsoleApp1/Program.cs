using System;

class Ejercicios1
{
    // Imprime los números pares del 0 al 100 sin usar "if".
    public void ImprimirNumerosParesSinIf()
    {
        for (int i = 0; i <= 100; i += 2) // Incrementamos de 2 en 2, empezando en 0.
        {
            Console.WriteLine(i); // Mostramos el número en la consola.
        }
    }

    // Imprime los números pares del 0 al 100 usando "if".
    public void ImprimirNumerosParesConIf()
    {
        for (int i = 0; i <= 100; i++) // Recorremos los números del 0 al 100.
        {
            if (i % 2 == 0) // Verificamos si el número es divisible entre 2.
            {
                Console.WriteLine(i); // Mostramos el número en la consola.
            }
        }
    }

    // Juego FizzBuzz: imprime números del 1 al 50 con reglas específicas.
    public void FizzBuzz()
    {
        for (int i = 1; i <= 50; i++) // Recorremos los números del 1 al 50.
        {
            if (i % 3 == 0 && i % 5 == 0) // Si el número es divisible entre 3 y 5.
                Console.WriteLine("FizzBuzz");
            else if (i % 3 == 0) // Si es divisible solo entre 3.
                Console.WriteLine("Fizz");
            else if (i % 5 == 0) // Si es divisible solo entre 5.
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(i); // Si no cumple ninguna condición, mostramos el número.
        }
    }

    // Imprime números del 1 al 10 usando un bucle "while".
    public void ImprimirDel1Al10ConWhile()
    {
        int i = 1; // Inicializamos la variable en 1.
        while (i <= 10) // Mientras "i" sea menor o igual a 10.
        {
            Console.WriteLine(i); // Mostramos el número en la consola.
            i++; // Incrementamos "i" en 1.
        }
    }

    // Calcula la suma de los primeros 100 números enteros usando un bucle "while".
    public void SumarPrimeros100ConWhile()
    {
        int suma = 0, i = 1; // Inicializamos la suma en 0 y el contador en 1.
        while (i <= 100) // Mientras "i" sea menor o igual a 100.
        {
            suma += i; // Sumamos "i" a la variable "suma".
            i++; // Incrementamos "i" en 1.
        }
        Console.WriteLine($"La suma es: {suma}"); // Mostramos el resultado.
    }

    // Imprime los números pares del 0 al 100 usando un bucle "while".
    public void ImprimirParesConWhile()
    {
        int i = 0; // Iniciamos en 0.
        while (i <= 100) // Mientras "i" sea menor o igual a 100.
        {
            Console.WriteLine(i); // Mostramos el número en la consola.
            i += 2; // Incrementamos de 2 en 2.
        }
    }
}
