using System;

class Ejercicios2
{
    // Verifica si un número es positivo, negativo o cero.
    public void EvaluarNumero()
    {
        Console.Write("Ingrese un número: ");
        if (int.TryParse(Console.ReadLine(), out int numero)) // Validamos si el usuario ingresa un número válido.
        {
            if (numero > 0)
                Console.WriteLine("El número es positivo.");
            else if (numero < 0)
                Console.WriteLine("El número es negativo.");
            else
                Console.WriteLine("El número es cero.");
        }
        else
            Console.WriteLine("Entrada no válida."); // Mostramos un mensaje si el usuario no ingresó un número.
    }

    // Evalúa una calificación para saber si es "Aprobado" o "Reprobado".
    public void EvaluarCalificacion()
    {
        Console.Write("Ingrese una calificación: ");
        if (int.TryParse(Console.ReadLine(), out int calificacion)) // Validamos la entrada del usuario.
        {
            if (calificacion >= 60) // Si la calificación es 60 o más.
                Console.WriteLine("Aprobado.");
            else
                Console.WriteLine("Reprobado."); // Si es menor a 60.
        }
        else
            Console.WriteLine("Entrada no válida.");
    }

    // Determina en qué rango se encuentra un número ingresado.
    public void DeterminarRango()
    {
        Console.Write("Ingrese un número: ");
        if (int.TryParse(Console.ReadLine(), out int numero)) // Validamos la entrada.
        {
            if (numero < 10)
                Console.WriteLine("Menor que 10.");
            else if (numero <= 20)
                Console.WriteLine("Entre 10 y 20.");
            else
                Console.WriteLine("Mayor que 20.");
        }
        else
            Console.WriteLine("Entrada no válida.");
    }

    // Muestra el día de la semana según un número del 1 al 7.
    public void DiaDeLaSemana()
    {
        Console.Write("Ingrese un número del 1 al 7: ");
        if (int.TryParse(Console.ReadLine(), out int dia))
        {
            switch (dia) // Usamos "switch" para comparar el número.
            {
                case 1: Console.WriteLine("Lunes"); break;
                case 2: Console.WriteLine("Martes"); break;
                case 3: Console.WriteLine("Miércoles"); break;
                case 4: Console.WriteLine("Jueves"); break;
                case 5: Console.WriteLine("Viernes"); break;
                case 6: Console.WriteLine("Sábado"); break;
                case 7: Console.WriteLine("Domingo"); break;
                default: Console.WriteLine("Número fuera de rango."); break;
            }
        }
        else
            Console.WriteLine("Entrada no válida.");
    }

    // Calcula operaciones básicas (+, -, *, /) según el operador ingresado.
    public void Calculadora()
    {
        Console.Write("Ingrese el primer número: ");
        if (double.TryParse(Console.ReadLine(), out double num1)) // Validamos el primer número.
        {
            Console.Write("Ingrese el segundo número: ");
            if (double.TryParse(Console.ReadLine(), out double num2)) // Validamos el segundo número.
            {
                Console.Write("Ingrese la operación (+, -, *, /): ");
                char operacion = Console.ReadLine()[0]; // Leemos el operador.

                switch (operacion) // Usamos "switch" para ejecutar la operación.
                {
                    case '+': Console.WriteLine($"Resultado: {num1 + num2}"); break;
                    case '-': Console.WriteLine($"Resultado: {num1 - num2}"); break;
                    case '*': Console.WriteLine($"Resultado: {num1 * num2}"); break;
                    case '/':
                        if (num2 != 0) // Verificamos que no haya división entre cero.
                            Console.WriteLine($"Resultado: {num1 / num2}");
                        else
                            Console.WriteLine("División entre cero no permitida.");
                        break;
                    default: Console.WriteLine("Operación no válida."); break;
                }
            }
            else
                Console.WriteLine("Entrada no válida para el segundo número.");
        }
        else
            Console.WriteLine("Entrada no válida para el primer número.");
    }
}
