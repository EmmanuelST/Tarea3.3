namespace Ejercicios
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ejerciciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capitulo9ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capitulo10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejerciciosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ejerciciosToolStripMenuItem
            // 
            this.ejerciciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capitulo9ToolStripMenuItem,
            this.capitulo10ToolStripMenuItem});
            this.ejerciciosToolStripMenuItem.Name = "ejerciciosToolStripMenuItem";
            this.ejerciciosToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.ejerciciosToolStripMenuItem.Text = "Ejercicios";
            // 
            // capitulo9ToolStripMenuItem
            // 
            this.capitulo9ToolStripMenuItem.Name = "capitulo9ToolStripMenuItem";
            this.capitulo9ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.capitulo9ToolStripMenuItem.Text = "Capitulo &9";
            this.capitulo9ToolStripMenuItem.Click += new System.EventHandler(this.Capitulo9ToolStripMenuItem_Click);
            // 
            // capitulo10ToolStripMenuItem
            // 
            this.capitulo10ToolStripMenuItem.Name = "capitulo10ToolStripMenuItem";
            this.capitulo10ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.capitulo10ToolStripMenuItem.Text = "Capitulo &10";
            this.capitulo10ToolStripMenuItem.Click += new System.EventHandler(this.Capitulo10ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Tarea 3.3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ejerciciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capitulo9ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capitulo10ToolStripMenuItem;
    }
}

