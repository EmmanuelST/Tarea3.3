﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicios.Capitulo_9;
using Ejercicios.Capitulo_10;

namespace Ejercicios
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Capitulo9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Capitulo9 capitulo9 = new Capitulo9();
            capitulo9.MdiParent = this;
            capitulo9.Show();
        }

        private void Capitulo10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Capitulo10 capitulo = new Capitulo10();
            capitulo.MdiParent = this;
            capitulo.Show();
        }
    }
}
