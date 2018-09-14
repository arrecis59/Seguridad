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
            this.pERFILESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nUEVOPERFILToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gESTIONPERFILToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pERFILESToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pERFILESToolStripMenuItem
            // 
            this.pERFILESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nUEVOPERFILToolStripMenuItem,
            this.gESTIONPERFILToolStripMenuItem});
            this.pERFILESToolStripMenuItem.Name = "pERFILESToolStripMenuItem";
            this.pERFILESToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.pERFILESToolStripMenuItem.Text = "PERFILES";
            // 
            // nUEVOPERFILToolStripMenuItem
            // 
            this.nUEVOPERFILToolStripMenuItem.Name = "nUEVOPERFILToolStripMenuItem";
            this.nUEVOPERFILToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.nUEVOPERFILToolStripMenuItem.Text = "NUEVO PERFIL";
            // 
            // gESTIONPERFILToolStripMenuItem
            // 
            this.gESTIONPERFILToolStripMenuItem.Name = "gESTIONPERFILToolStripMenuItem";
            this.gESTIONPERFILToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.gESTIONPERFILToolStripMenuItem.Text = "GESTION PERFIL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
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
        private System.Windows.Forms.ToolStripMenuItem pERFILESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nUEVOPERFILToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gESTIONPERFILToolStripMenuItem;
    }
}

