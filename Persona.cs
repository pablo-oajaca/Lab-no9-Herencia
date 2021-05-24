using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_no9_Herencia
{
    public class Persona
    {
        string nombre;
        string apellido;
        string direccion;
        DateTime fechaNacimiento;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }

        public int edad()
        {
            DateTime fechaActual = DateTime.Today;

            int edad = fechaActual.Year - FechaNacimiento.Year;

            if (FechaNacimiento.Month > fechaActual.Month)
            {
                --edad;
            }

            return edad;

        }

    }
}