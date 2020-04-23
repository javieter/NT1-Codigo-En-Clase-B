using NT1B_Console.Models;
using System;
using System.Runtime.CompilerServices;

namespace NT1B_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region Constructor por defecto
            Persona per1 = new Persona();

            MostrarEstadoInterno(per1);

            per1.PersonaId = 1;
            per1.SetNombre("Mariano");
            per1.Apellido = ("Longo");

            MostrarEstadoInterno(per1);

            #endregion
            Pausa();

            #region Constructor parametrizado 1
            Persona per2 = new Persona(2, "Pedro", "Picapiedra");
            MostrarEstadoInterno(per2);
            per2.Direccion.Calle = "Roca Buena";
            per2.Direccion.Numero = 25;
            per2.Direccion.CodigoPostal = 1111;
            MostrarEstadoInterno(per2);

            #endregion
            Pausa();

            #region Constructor parametrizado 2
            Direccion direcPM = new Direccion();
            direcPM.Calle = "Caverna oscura";
            direcPM.Numero = 666;
            direcPM.CodigoPostal = 2323;

            Persona per3 = new Persona(3, "Pablo", "Marmol", direcPM);

            MostrarEstadoInterno(per3);
            #endregion

        }
        private static void MostrarEstadoInterno(Persona persona)
        {
            ImprimirEncabezado("Mostrando estado interno de la persona " + persona.PersonaId);
            ImprimirLinea("Id = " + persona.PersonaId);
            ImprimirLinea("Nombre = " + persona.getNombre());
            ImprimirLinea("Apellido = " + persona.Apellido);
            //ImprimirLinea("Direccion = " + persona.Direccion);

            //Para acceder a los atributos de direccion y que no se presenten una excepcion, se debe disponer del objeto ya instanciado
            if (persona.Direccion != null)
            {
                ImprimirLinea(persona.Direccion.GetEstadoInternoEnLineas());
            }
            else
            {
                ImprimirLinea("No hay una direccion definida");
            }
        }
        private static void ImprimirEncabezado(string msg)
        {
            if (msg == null)
            {
                msg = "Mostrando encabezado por defecto";
            }

            ImprimirLinea(GenerarBarra(msg.Length));
            ImprimirLinea(msg);
            ImprimirLinea(GenerarBarra(msg.Length));
        }
        private static string GenerarBarra(int largo)
        {
            string barra = String.Empty;
            for(int i=0; i< largo; i++)
            {
                barra += "#";
            }
            return barra;
        }
        private static void ImprimirLinea(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
        private static void Pausa()
        {
            Console.ReadKey();
        }
    }
}
