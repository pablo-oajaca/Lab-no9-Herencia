using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_no9_Herencia
{
    public partial class _Default : Page
    {
        static List<Alumno> alumnos;

        static List<Nota> notas = new List<Nota>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                alumnos = new List<Alumno>();
        }

        protected void Guardar()
        {
            string fileName = Server.MapPath("Alumnos.txt");

            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            foreach (var alumno in alumnos)
            {
                writer.WriteLine(alumno.Nombre);
                writer.WriteLine(alumno.Apellido);
                writer.WriteLine(alumno.Direccion);
                writer.WriteLine(alumno.FechaNacimiento.ToShortDateString());
                //como las notas son tambien una lista se necesita un segundo ciclo
                foreach (var nota in notas)
                {
                    writer.WriteLine(nota.Calificacion);
                    writer.WriteLine(nota.Curso);

                }
            }

            //Cerrar el archivo
            writer.Close();


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();

            alumno.Nombre = TextBoxNombre.Text;
            alumno.Apellido = TextBoxApellido.Text;
            alumno.Direccion = TextBoxDireccion.Text;
            alumno.FechaNacimiento = CalendarNacimiento.SelectedDate;
            alumno.Notas = notas;

            alumnos.Add(alumno);

            Guardar();
            notas.Clear();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Nota nota = new Nota();

            nota.Curso = DropDownListCurso.SelectedValue;
            nota.Calificacion = Convert.ToInt32(TextBoxNota.Text);

            notas.Add(nota);
        }
    }
}