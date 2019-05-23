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
        List<Inventario> inventario;
        public Capitulo10()
        {
            InitializeComponent();
            lista = new List<Estudiantes>();
            inventario = new List<Inventario>();
           
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

        private void GuardarProductobutton_Click(object sender, EventArgs e)
        {
            inventario.Add(getProducto());
            LimpiarProducto();
        }

        private Inventario getProducto()
        {

            Inventario producto = new Inventario();

            producto.CodigoProducto = (int)CodigoProductonumericUpDown.Value;
            producto.NombreProducto = NombreProductotextBox.Text;
            producto.PrecioProducto = (float)PrecioProductonumericUpDown.Value;
            producto.CantidadProducto = (int)CantidadProductonumericUpDown.Value;
            producto.FechaCaducidad = FechaCaducidadProdcutodateTimePicker.Value;
            producto.DescripcionProducto = DescripcionProductotextBox.Text;
            producto.Gondola = (string)GondolaProductocomboBox.SelectedItem;

            return producto;
        }

        private void LimpiarProducto()
        {
            CodigoProductonumericUpDown.Value = 0;
            NombreProductotextBox.Text = string.Empty;
            PrecioProductonumericUpDown.Value= 0;
            CantidadProductonumericUpDown.Value = 0;
            FechaCaducidadProdcutodateTimePicker.Value = DateTime.Now;
            DescripcionProductotextBox.Text = string.Empty;
            GondolaProductocomboBox.SelectedItem = string.Empty;
        }

        private void NuevoProductobutton_Click(object sender, EventArgs e)
        {
            LimpiarProducto();
        }

        private void BuscarProductobutton_Click(object sender, EventArgs e)
        {
            setProducto(BuscarProducto((int)CodigoProductonumericUpDown.Value));
        }

        private Inventario BuscarProducto(int codigo)
        {
            Inventario producto = new Inventario();

            foreach(Inventario obj in inventario)
            {
                if (obj.CodigoProducto == codigo)
                {
                    return producto = obj; 
                }
            }

            return producto;
        }

        private void setProducto(Inventario producto)
        {
            CodigoProductonumericUpDown.Value = producto.CodigoProducto;
            NombreProductotextBox.Text = producto.NombreProducto;
            PrecioProductonumericUpDown.Value = (int)producto.PrecioProducto;
            CantidadProductonumericUpDown.Value = producto.CantidadProducto;
            FechaCaducidadProdcutodateTimePicker.Value = producto.FechaCaducidad;
            DescripcionProductotextBox.Text = producto.DescripcionProducto;
            GondolaProductocomboBox.SelectedItem = producto.Gondola;

          
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            inventario.Remove(BuscarProducto((int)CodigoProductonumericUpDown.Value));
            LimpiarProducto();
        }
    }
}
