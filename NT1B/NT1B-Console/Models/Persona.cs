﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NT1B_Console.Models
{
    public class Persona
    {
        #region Consructores
        public Persona()
        {

        }
        public Persona(int id, string nombre, string apellido)
        {
            this.PersonaId = id;
            this.SetNombre(nombre);
            this.Apellido = apellido;
            this.Direccion = new Direccion();
        }
        public Persona(int id,string nombre, string apellido, Direccion direccion)
        {
            this.PersonaId = id;
            this.SetNombre(nombre);
            this.Apellido = apellido;
            this.Direccion = direccion;
        }
        #endregion

        #region Propiedades
        private int id;
        public int PersonaId { get => id; set => id = value; }

        private string nombre;
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string getNombre()
        {
            return this.nombre;
        }
        public string Apellido { get; set; }
        public Direccion Direccion { get; set; }
        //relacion uno a uno
        public Mascota Mascota { get; set; }
        //Uno a muchos
        public ICollection<Telefono> Telefonos { get; set; }
        //Muchos a muchos
        public ICollection<PersonaDireccion> Direcciones  { get; set; }
    #endregion
}
}
