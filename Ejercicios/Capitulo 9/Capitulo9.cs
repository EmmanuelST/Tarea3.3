using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios.Capitulo_9
{
    public partial class Capitulo9 : Form
    {
        public struct Producto
        {
            public string nombre;
            public float precio;
            public DateTime fechaCaducidad;
        }

        public Capitulo9()
        {
            InitializeComponent();
        }

        private void AgregarProductobutton_Click(object sender, EventArgs e)
        {

            Producto producto;
            producto.nombre =NombreProductotextBox.Text;
            producto.precio = (float)PrecioProductonumericUpDown.Value;
            producto.fechaCaducidad = FechaCaducidaddateTimePicker.Value;

            ListViewItem item = new ListViewItem(producto.nombre);
            item.SubItems.Add(producto.precio.ToString());
            item.SubItems.Add(producto.fechaCaducidad.ToShortDateString());
            ProductoslistView.Items.Add(item);

            NombreProductotextBox.Text = string.Empty;
            PrecioProductonumericUpDown.Value = 0;
            FechaCaducidaddateTimePicker.Value = DateTime.Now;
        }
    }
}
