using System;
using System.Collections.Generic;
using System.Text;

namespace NT1B_Console.Models
{
    public class Direccion
    {
        #region Propiedades
        public int DireccionId { get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }
        public int Piso { get; set; }
        public string Departamento { get; set; }
        public int CodigoPostal { get; set; }
        #endregion
        //private int PersonaId { get; set; }
        //public Persona Duenio { get; set; }
        //Muchos a mchos
        public ICollection<PersonaDireccion> Habitantes { get; set; }

        public string GetEstadoInternoEnLineas()
        {
            //Sin Id, porque no es de mi interes
            return
                "Calle = " + this.Calle + Environment.NewLine +
                "Piso = " + this.Piso + Environment.NewLine +
                "Numero = " + this.Numero + Environment.NewLine +
                "Departamento = " + this.Departamento + Environment.NewLine +
                "Codigo Postal = " + this.CodigoPostal + Environment.NewLine;
        }
    }
}
