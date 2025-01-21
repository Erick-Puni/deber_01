using System;

namespace MiAplicacion
{
    // Clase Persona con atributos y métodos básicos.
    class Persona
    {
        private string nombre;
        private int edad;
        private string dni;

        public void EstablecerNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string ObtenerNombre()
        {
            return nombre;
        }

        public void EstablecerEdad(int edad)
        {
            this.edad = edad;
        }

        public int ObtenerEdad()
        {
            return edad;
        }

        public void EstablecerDni(string dni)
        {
            this.dni = dni;
        }

        public string ObtenerDni()
        {
            return dni;
        }
    }

    // Clase Punto que representa un punto en el plano cartesiano.
    class Punto
    {
        private int x;
        private int y;

        public void EstablecerX(int x)
        {
            this.x = x;
        }

        public int ObtenerX()
        {
            return x;
        }

        public void EstablecerY(int y)
        {
            this.y = y;
        }

        public int ObtenerY()
        {
            return y;
        }
    }

    // Clase Circulo que incluye las coordenadas de su centro y su radio.
    class Circulo
    {
        private int x;
        private int y;
        private double radio;

        public void EstablecerX(int x)
        {
            this.x = x;
        }

        public int ObtenerX()
        {
            return x;
        }

        public void EstablecerY(int y)
        {
            this.y = y;
        }

        public int ObtenerY()
        {
            return y;
        }

        public void EstablecerRadio(double radio)
        {
            this.radio = radio;
        }

        public double ObtenerRadio()
        {
            return radio;
        }

        public double CalcularArea()
        {
            return Math.PI * radio * radio; // Fórmula del área de un círculo: π * r^2.
        }
    }

    // Clase PersonaDetallada que incluye más atributos y un método para mostrar información.
    class PersonaDetallada
    {
        private string nombre;
        private string apellido;
        private int edad;
        private string genero;

        public void EstablecerNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string ObtenerNombre()
        {
            return nombre;
        }

        public void EstablecerApellido(string apellido)
        {
            this.apellido = apellido;
        }

        public string ObtenerApellido()
        {
            return apellido;
        }

        public void EstablecerEdad(int edad)
        {
            this.edad = edad;
        }

        public int ObtenerEdad()
        {
            return edad;
        }

        public void EstablecerGenero(string genero)
        {
            this.genero = genero;
        }

        public string ObtenerGenero()
        {
            return genero;
        }

        public void ImprimirInformacion()
        {
            Console.WriteLine($"Nombre: {nombre} {apellido}");
            Console.WriteLine($"Edad: {edad}");
            Console.WriteLine($"Género: {genero}");
        }
    }

    // Programa principal.
    class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo de uso de la clase Persona.
            Persona persona = new Persona();
            persona.EstablecerNombre("Juan");
            persona.EstablecerEdad(30);
            persona.EstablecerDni("123456789");
            Console.WriteLine($"Nombre: {persona.ObtenerNombre()}, Edad: {persona.ObtenerEdad()}, DNI: {persona.ObtenerDni()}");

            // Ejemplo de uso de la clase Punto.
            Punto punto = new Punto();
            punto.EstablecerX(5);
            punto.EstablecerY(10);
            Console.WriteLine($"Punto: ({punto.ObtenerX()}, {punto.ObtenerY()})");

            // Ejemplo de uso de la clase Circulo.
            Circulo circulo = new Circulo();
            circulo.EstablecerX(0);
            circulo.EstablecerY(0);
            circulo.EstablecerRadio(5);
            Console.WriteLine($"Área del círculo: {circulo.CalcularArea()}");

            // Ejemplo de uso de la clase PersonaDetallada.
            PersonaDetallada personaDetallada = new PersonaDetallada();
            personaDetallada.EstablecerNombre("Ana");
            personaDetallada.EstablecerApellido("Gómez");
            personaDetallada.EstablecerEdad(25);
            personaDetallada.EstablecerGenero("Femenino");
            personaDetallada.ImprimirInformacion();
        }
    }
}

