namespace SEGURIDAD1._0
{
    partial class Form1
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
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoAPerfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionDePerfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDePerfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoAPerfilesToolStripMenuItem,
            this.aToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1181, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlDeUsuariosToolStripMenuItem,
            this.mantenimientoDeUsuariosToolStripMenuItem});
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.aToolStripMenuItem.Text = "Mantenimiento a Usuarios";
            this.aToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
            // 
            // controlDeUsuariosToolStripMenuItem
            // 
            this.controlDeUsuariosToolStripMenuItem.Name = "controlDeUsuariosToolStripMenuItem";
            this.controlDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.controlDeUsuariosToolStripMenuItem.Text = "Control de Usuarios";
            this.controlDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.controlDeUsuariosToolStripMenuItem_Click);
            // 
            // mantenimientoDeUsuariosToolStripMenuItem
            // 
            this.mantenimientoDeUsuariosToolStripMenuItem.Name = "mantenimientoDeUsuariosToolStripMenuItem";
            this.mantenimientoDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.mantenimientoDeUsuariosToolStripMenuItem.Text = "Mantenimiento de Usuarios";
            this.mantenimientoDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDeUsuariosToolStripMenuItem_Click);
            // 
            // mantenimientoAPerfilesToolStripMenuItem
            // 
            this.mantenimientoAPerfilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignacionDePerfilesToolStripMenuItem,
            this.mantenimientoDePerfilesToolStripMenuItem});
            this.mantenimientoAPerfilesToolStripMenuItem.Name = "mantenimientoAPerfilesToolStripMenuItem";
            this.mantenimientoAPerfilesToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.mantenimientoAPerfilesToolStripMenuItem.Text = "Mantenimiento a Perfiles";
            // 
            // asignacionDePerfilesToolStripMenuItem
            // 
            this.asignacionDePerfilesToolStripMenuItem.Name = "asignacionDePerfilesToolStripMenuItem";
            this.asignacionDePerfilesToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.asignacionDePerfilesToolStripMenuItem.Text = "Nuevo perfil";
            this.asignacionDePerfilesToolStripMenuItem.Click += new System.EventHandler(this.asignacionDePerfilesToolStripMenuItem_Click);
            // 
            // mantenimientoDePerfilesToolStripMenuItem
            // 
            this.mantenimientoDePerfilesToolStripMenuItem.Name = "mantenimientoDePerfilesToolStripMenuItem";
            this.mantenimientoDePerfilesToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.mantenimientoDePerfilesToolStripMenuItem.Text = "Mantenimiento de perfiles";
            this.mantenimientoDePerfilesToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDePerfilesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 753);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoAPerfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignacionDePerfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDePerfilesToolStripMenuItem;
    }
}

