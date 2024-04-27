using Beehive_School___Recursos_Humanos.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beehive_School___Recursos_Humanos.Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdb_Direccion.Checked == true)
            {
                Empleados inicio = new Empleados();
                inicio.Inicio_Dir(textBox1.Text, textBox2.Text);
                this.Hide();
            }
            if (rdb_Administración.Checked == true)
            {
                rdb_Direccion.Checked = false;
                Empleados inicio = new Empleados();
                inicio.Inicio_Admin(textBox1.Text, textBox2.Text);
                this.Hide();
            }
            else if (rdb_Administración.Checked == false && rdb_Direccion.Checked == false)
            {
                MessageBox.Show("Selecciona las credenciales correctas");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

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
