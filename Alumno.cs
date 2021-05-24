using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_no9_Herencia
{

    public class Nota
    {
        int calificacion;
        string curso;

        public int Calificacion { get => calificacion; set => calificacion = value; }
        public string Curso { get => curso; set => curso = value; }
    }
    public class Alumno : Persona
    {
        string carne;
        List<Nota> notas = new List<Nota>();

        public string Carne { get => carne; set => carne = value; }
        public List<Nota> Notas { get => notas; set => notas = value; }

        //Constructor de la clase:
        //Es un método especial que se llama igual que la clase,
        //y no devuelve ningun tipo
        //ejecuta su código cada vez que se crea un objeto de esta clase.
        public Alumno()
        {
            //cada vez que se crea un objeto Alumno se crea su lista de Notas
            Notas = new List<Nota>();

        }
    }
}