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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreProductotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PrecioProductonumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.FechaCaducidaddateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AgregarProductobutton = new System.Windows.Forms.Button();
            this.ProductoslistView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioProductonumericUpDown)).BeginInit();
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
            this.tabPage1.Text = "Capitulo 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(466, 378);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // NombreProductotextBox
            // 
            this.NombreProductotextBox.Location = new System.Drawing.Point(131, 26);
            this.NombreProductotextBox.Name = "NombreProductotextBox";
            this.NombreProductotextBox.Size = new System.Drawing.Size(150, 20);
            this.NombreProductotextBox.TabIndex = 1;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de Caducidad";
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
            // ProductoslistView
            // 
            this.ProductoslistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.ProductoslistView.Location = new System.Drawing.Point(16, 155);
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
    }
}