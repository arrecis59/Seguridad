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
        AsigPerfiles asp = new AsigPerfiles();
        MantPerfiles mnp = new MantPerfiles();
        MantenimientoUsuar mnu = new MantenimientoUsuar();
        ControlUsuarioPass cup = new ControlUsuarioPass();
        public Form1()
        {
            InitializeComponent();
        }//prueba

        private void button1_Click(object sender, EventArgs e)
        {
            asp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mnp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mnu.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cup.Show();
        }
    }
}
