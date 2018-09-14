using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AsignacionModulos;
using MantenimientoUsuarios;
using Mantenimiento_perfiles;
using DiseñoUsuarioPassWordCambiar;

namespace SEGURIDAD1._0
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }//prueba

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void controlDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlUsuarioPass cup = new ControlUsuarioPass();
            cup.Show();
        }

        private void mantenimientoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoUsuar mnu = new MantenimientoUsuar();
            mnu.Show();
        }

        private void asignacionDePerfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsigPerfiles asp = new AsigPerfiles();
            asp.Show();
        }

        private void mantenimientoDePerfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantPerfiles mnp = new MantPerfiles();
            mnp.Show();
        }

        private void permisosExtraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            extraApp exapp = new extraApp();
            exapp.Show();
        }
    }
}
