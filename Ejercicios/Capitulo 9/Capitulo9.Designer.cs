namespace Ejercicios.Capitulo_9
{
    partial class Capitulo9
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ProductoslistView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AgregarProductobutton = new System.Windows.Forms.Button();
            this.FechaCaducidaddateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.PrecioProductonumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreProductotextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.GuardarMascotabutton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TelefonoDueñotextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DirecciónDueñotextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NombreDueñotextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BuscarMascotabutton = new System.Windows.Forms.Button();
            this.EdadMascotanumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.RazaMascotatextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NombreMascotatextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioProductonumericUpDown)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdadMascotanumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(336, 330);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ProductoslistView);
            this.tabPage1.Controls.Add(this.AgregarProductobutton);
            this.tabPage1.Controls.Add(this.FechaCaducidaddateTimePicker);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.PrecioProductonumericUpDown);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.NombreProductotextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(328, 304);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ejercicio 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ProductoslistView
            // 
            this.ProductoslistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.ProductoslistView.Location = new System.Drawing.Point(9, 155);
            this.ProductoslistView.Name = "ProductoslistView";
            this.ProductoslistView.Size = new System.Drawing.Size(312, 143);
            this.ProductoslistView.TabIndex = 7;
            this.ProductoslistView.UseCompatibleStateImageBehavior = false;
            this.ProductoslistView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Producto";
            this.columnHeader1.Width = 86;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Precio";
            this.columnHeader2.Width = 79;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fecha Caducidad";
            this.columnHeader3.Width = 194;
            // 
            // AgregarProductobutton
            // 
            this.AgregarProductobutton.Location = new System.Drawing.Point(9, 126);
            this.AgregarProductobutton.Name = "AgregarProductobutton";
            this.AgregarProductobutton.Size = new System.Drawing.Size(75, 23);
            this.AgregarProductobutton.TabIndex = 6;
            this.AgregarProductobutton.Text = "Agregar";
            this.AgregarProductobutton.UseVisualStyleBackColor = true;
            this.AgregarProductobutton.Click += new System.EventHandler(this.AgregarProductobutton_Click);
            // 
            // FechaCaducidaddateTimePicker
            // 
            this.FechaCaducidaddateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaCaducidaddateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaCaducidaddateTimePicker.Location = new System.Drawing.Point(131, 88);
            this.FechaCaducidaddateTimePicker.Name = "FechaCaducidaddateTimePicker";
            this.FechaCaducidaddateTimePicker.Size = new System.Drawing.Size(150, 20);
            this.FechaCaducidaddateTimePicker.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de Caducidad";
            // 
            // PrecioProductonumericUpDown
            // 
            this.PrecioProductonumericUpDown.Increment = new decimal(new int[] {
            500,
            0,
            0,
            65536});
            this.PrecioProductonumericUpDown.Location = new System.Drawing.Point(131, 56);
            this.PrecioProductonumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.PrecioProductonumericUpDown.Name = "PrecioProductonumericUpDown";
            this.PrecioProductonumericUpDown.Size = new System.Drawing.Size(150, 20);
            this.PrecioProductonumericUpDown.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio del Producto";
            // 
            // NombreProductotextBox
            // 
            this.NombreProductotextBox.Location = new System.Drawing.Point(131, 26);
            this.NombreProductotextBox.Name = "NombreProductotextBox";
            this.NombreProductotextBox.Size = new System.Drawing.Size(150, 20);
            this.NombreProductotextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del producto";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Nuevobutton);
            this.tabPage2.Controls.Add(this.GuardarMascotabutton);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(328, 304);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ejercicio 3";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(88, 270);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 23);
            this.Nuevobutton.TabIndex = 3;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // GuardarMascotabutton
            // 
            this.GuardarMascotabutton.Location = new System.Drawing.Point(6, 270);
            this.GuardarMascotabutton.Name = "GuardarMascotabutton";
            this.GuardarMascotabutton.Size = new System.Drawing.Size(75, 23);
            this.GuardarMascotabutton.TabIndex = 2;
            this.GuardarMascotabutton.Text = "Guardar";
            this.GuardarMascotabutton.UseVisualStyleBackColor = true;
            this.GuardarMascotabutton.Click += new System.EventHandler(this.GuardarMascotabutton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TelefonoDueñotextBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.DirecciónDueñotextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.NombreDueñotextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(7, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 121);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del dueño";
            // 
            // TelefonoDueñotextBox
            // 
            this.TelefonoDueñotextBox.Location = new System.Drawing.Point(78, 84);
            this.TelefonoDueñotextBox.Name = "TelefonoDueñotextBox";
            this.TelefonoDueñotextBox.Size = new System.Drawing.Size(184, 20);
            this.TelefonoDueñotextBox.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Telefono:";
            // 
            // DirecciónDueñotextBox
            // 
            this.DirecciónDueñotextBox.Location = new System.Drawing.Point(78, 58);
            this.DirecciónDueñotextBox.Name = "DirecciónDueñotextBox";
            this.DirecciónDueñotextBox.Size = new System.Drawing.Size(184, 20);
            this.DirecciónDueñotextBox.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Dirección:";
            // 
            // NombreDueñotextBox
            // 
            this.NombreDueñotextBox.Location = new System.Drawing.Point(78, 29);
            this.NombreDueñotextBox.Name = "NombreDueñotextBox";
            this.NombreDueñotextBox.Size = new System.Drawing.Size(184, 20);
            this.NombreDueñotextBox.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nombre:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BuscarMascotabutton);
            this.groupBox1.Controls.Add(this.EdadMascotanumericUpDown);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.RazaMascotatextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.NombreMascotatextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la mascota";
            // 
            // BuscarMascotabutton
            // 
            this.BuscarMascotabutton.Location = new System.Drawing.Point(262, 16);
            this.BuscarMascotabutton.Name = "BuscarMascotabutton";
            this.BuscarMascotabutton.Size = new System.Drawing.Size(53, 23);
            this.BuscarMascotabutton.TabIndex = 6;
            this.BuscarMascotabutton.Text = "Buscar";
            this.BuscarMascotabutton.UseVisualStyleBackColor = true;
            this.BuscarMascotabutton.Click += new System.EventHandler(this.BuscarMascotabutton_Click);
            // 
            // EdadMascotanumericUpDown
            // 
            this.EdadMascotanumericUpDown.Location = new System.Drawing.Point(78, 85);
            this.EdadMascotanumericUpDown.Name = "EdadMascotanumericUpDown";
            this.EdadMascotanumericUpDown.Size = new System.Drawing.Size(184, 20);
            this.EdadMascotanumericUpDown.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Edad:";
            // 
            // RazaMascotatextBox
            // 
            this.RazaMascotatextBox.Location = new System.Drawing.Point(78, 49);
            this.RazaMascotatextBox.Name = "RazaMascotatextBox";
            this.RazaMascotatextBox.Size = new System.Drawing.Size(184, 20);
            this.RazaMascotatextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Raza:";
            // 
            // NombreMascotatextBox
            // 
            this.NombreMascotatextBox.Location = new System.Drawing.Point(78, 17);
            this.NombreMascotatextBox.Name = "NombreMascotatextBox";
            this.NombreMascotatextBox.Size = new System.Drawing.Size(184, 20);
            this.NombreMascotatextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre:";
            // 
            // Capitulo9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 349);
            this.Controls.Add(this.tabControl1);
            this.Name = "Capitulo9";
            this.Text = "Capitulo9";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioProductonumericUpDown)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdadMascotanumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView ProductoslistView;
        private System.Windows.Forms.Button AgregarProductobutton;
        private System.Windows.Forms.DateTimePicker FechaCaducidaddateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown PrecioProductonumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombreProductotextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox RazaMascotatextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NombreMascotatextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TelefonoDueñotextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DirecciónDueñotextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NombreDueñotextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown EdadMascotanumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button GuardarMascotabutton;
        private System.Windows.Forms.Button BuscarMascotabutton;
    }
}