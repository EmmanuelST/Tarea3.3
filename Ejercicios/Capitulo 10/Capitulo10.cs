using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios.Capitulo_10
{
    public partial class Capitulo10 : Form
    {
        List<Estudiantes> lista;
        public Capitulo10()
        {
            InitializeComponent();
            lista = new List<Estudiantes>();
           
        }

        private void GuardarEstudiantebutton_Click(object sender, EventArgs e)
        {

            Estudiantes estudiante = new Estudiantes();

            estudiante = getEstudiante();

            if(estudiante != null)
             lista.Add(estudiante);

            LimpiarEstudiante();
        }

        private Estudiantes getEstudiante()
        {
            Estudiantes estudiante = new Estudiantes();

            estudiante.Nombre = NombreEstudiantetextBox.Text;
            estudiante.Matricula = MatriculaEstudiantetextBox.Text;
            estudiante.Grado = (int)GradoEstudiantenumericUpDown.Value;
            estudiante.FechaIngreso = FechaIngresoEstudiantedateTimePicker.Value;
            estudiante.NombreTutor = NombreTutorEstudiantetextBox.Text;
            estudiante.TelefonoTutor = TelefonoTutorEstudiantetextBox.Text;
            estudiante.Direccion = DireccionEstudiantetextBox.Text;

            return estudiante;
        }

        private void LimpiarEstudiante()
        {
            NombreEstudiantetextBox.Text =string.Empty;
            MatriculaEstudiantetextBox.Text = string.Empty;
            GradoEstudiantenumericUpDown.Value = 1;
            FechaIngresoEstudiantedateTimePicker.Value=DateTime.Now;
            NombreTutorEstudiantetextBox.Text = string.Empty;
            TelefonoTutorEstudiantetextBox.Text = string.Empty;
            DireccionEstudiantetextBox.Text = string.Empty;
        }

        private void NuevoEstudiantebutton_Click(object sender, EventArgs e)
        {
            LimpiarEstudiante();
        }

        private void EliminarEstudiantebutton_Click(object sender, EventArgs e)
        {
            lista.Remove(BuscarEstudiante(MatriculaEstudiantetextBox.Text));
            LimpiarEstudiante();
        }

        private Estudiantes BuscarEstudiante(string matricula)
        {
          

            foreach(Estudiantes obj in lista)
            {
                if(obj.Matricula.Equals(matricula))
                {
                    return obj;
                    break;
                }
            }

            return new Estudiantes();
        }

        private void BuscarEstudiantebutton_Click(object sender, EventArgs e)
        {
            setEstudiante(BuscarEstudiante(MatriculaEstudiantetextBox.Text));
        }

        private void setEstudiante(Estudiantes estudiante)
        {
            NombreEstudiantetextBox.Text = estudiante.Nombre; ;
            MatriculaEstudiantetextBox.Text = estudiante.Matricula;
            GradoEstudiantenumericUpDown.Value = estudiante.Grado;
            FechaIngresoEstudiantedateTimePicker.Value = estudiante.FechaIngreso;
            NombreTutorEstudiantetextBox.Text = estudiante.NombreTutor;
            TelefonoTutorEstudiantetextBox.Text = estudiante.TelefonoTutor;
            DireccionEstudiantetextBox.Text = estudiante.Direccion;

        }
    }
}
