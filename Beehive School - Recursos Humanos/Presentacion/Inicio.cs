using System;
using System.Windows.Forms;
using Beehive_School___Recursos_Humanos.Datos;

namespace Beehive_School___Recursos_Humanos.Presentacion
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void btn_Busqueda_Click(object sender, EventArgs e)
        {
            BusquedaEmpleados busqueda = new BusquedaEmpleados();
            busqueda.Show();
            this.Hide();
        }

        private void btn_Reclutamiento_Click(object sender, EventArgs e)
        {
            ReclutamientoEmpleados reclutamiento = new ReclutamientoEmpleados();
            reclutamiento.Show();
            this.Hide();
        }

        private void btn_Bajas_Click(object sender, EventArgs e)
        {
            BajaTrabajador bajaTrabajador = new BajaTrabajador();
            bajaTrabajador.Show();
            this.Hide();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
