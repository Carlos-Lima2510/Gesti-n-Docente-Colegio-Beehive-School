using Beehive_School___Recursos_Humanos.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beehive_School___Recursos_Humanos
{
    public partial class ReclutamientoEmpleados : Form
    {
        public ReclutamientoEmpleados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreacionPlaza creacionPlaza = new CreacionPlaza();
            creacionPlaza.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btn_Actualizar evaluacionPlazas = new btn_Actualizar();
            evaluacionPlazas.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
