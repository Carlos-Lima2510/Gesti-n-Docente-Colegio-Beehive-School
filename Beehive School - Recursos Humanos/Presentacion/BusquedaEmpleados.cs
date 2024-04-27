using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Beehive_School___Recursos_Humanos.Datos;
using System.Collections;
using System.Runtime.InteropServices;

namespace Beehive_School___Recursos_Humanos.Presentacion
{
    public partial class BusquedaEmpleados : Form
    {
        private string connectionString = "Server= LAPTOP-C3RL3T0; DataBase=Beehive_RRHH; Integrated Security=true";

        public BusquedaEmpleados()
        {
            InitializeComponent();
            MostrarPersonas();
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;

        }

        private void text_Busqempleados_Click(object sender, EventArgs e)
        {

        }
        private void MostrarPersonas() //Metodo para mostrar tabla Persona 
        {
            Empleados Mostrar = new Empleados(); //instancia de clase
            dataGridViewCrear.DataSource = Mostrar.ListarPersona();
            dataGridViewACT.DataSource = Mostrar.ListarPersona();
        }
        private void ActualizarEmpleados()
        {
            Empleados Actualizar = new Empleados();
            Actualizar.Actualizar(
            Convert.ToInt32(IDlabel.Text), PrimerNombreACT.Text, SegundoNombreACT.Text,
            PrimerApellidoACT.Text, SegundoApellidoACT.Text, dateTimePicker1.Text,
            DPI_ACT.Text, IGGS_ACT.Text, DireccionACT.Text, Convert.ToInt32(Tel_CelularACT.Text), Convert.ToInt32(Tel_EmergACT.Text), dateTimePicker2.Text, labelID2.Text, labelID1.Text
                );
            MessageBox.Show("Actualizado Correctamente");
        }
        private void InsertarEmpleados()
        {

            Empleados Insertar = new Empleados();
            Insertar.Insertar(
                textPrimerNombre.Text, textSegundoNombre.Text, textPrimerApellido.Text,
                textSegundoApellido.Text, textDireccion.Text, dateTimePickerIngreso.Text, textDPI.Text, textIGSS.Text,
                Convert.ToInt32(textCelular.Text), Convert.ToInt32(textEmergencia.Text), dateTimePickerNac.Text, ComboID.Text, ComboID2.Text
                );
        }
        private void EliminarEmpleado()
        {
            Empleados Eliminar = new Empleados();
            Eliminar.Eliminar(Convert.ToInt32(IDlabel.Text));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ActualizarEmpleados();
            MostrarPersonas();
        }

        private void dataGridViewACT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDlabel.Text = dataGridViewACT.Rows[e.RowIndex].Cells[0].Value.ToString();
            PrimerNombreACT.Text = dataGridViewACT.Rows[e.RowIndex].Cells[1].Value.ToString();
            SegundoNombreACT.Text = dataGridViewACT.Rows[e.RowIndex].Cells[2].Value.ToString();
            PrimerApellidoACT.Text = dataGridViewACT.Rows[e.RowIndex].Cells[3].Value.ToString();
            SegundoApellidoACT.Text = dataGridViewACT.Rows[e.RowIndex].Cells[4].Value.ToString();
            DireccionACT.Text = dataGridViewACT.Rows[e.RowIndex].Cells[5].Value.ToString();
            dateTimePicker1.Text = dataGridViewACT.Rows[e.RowIndex].Cells[6].Value.ToString();
            DPI_ACT.Text = dataGridViewACT.Rows[e.RowIndex].Cells[7].Value.ToString();
            IGGS_ACT.Text = dataGridViewACT.Rows[e.RowIndex].Cells[8].Value.ToString();
            Tel_CelularACT.Text = dataGridViewACT.Rows[e.RowIndex].Cells[9].Value.ToString();
            Tel_EmergACT.Text = dataGridViewACT.Rows[e.RowIndex].Cells[10].Value.ToString();
            dateTimePicker2.Text = dataGridViewACT.Rows[e.RowIndex].Cells[11].Value.ToString();
            comboBox3.Text = dataGridViewACT.Rows[e.RowIndex].Cells[12].Value.ToString();
            comboBox4.Text = dataGridViewACT.Rows[e.RowIndex].Cells[13].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EliminarEmpleado();
            MostrarPersonas();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            InsertarEmpleados();
            MostrarPersonas();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridViewCrear_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem.ToString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * from departamento WHERE Nombre_Departamento = @selectedValue;";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@selectedValue", selectedValue);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string detalle1 = reader["Id"].ToString();

                        ComboID.Text = detalle1;
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener detalles: " + ex.Message);
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox2.SelectedItem.ToString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * from puesto WHERE Nombre_Puesto = @selectedValue;";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@selectedValue", selectedValue);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string detalle1 = reader["Id"].ToString();

                        ComboID2.Text = detalle1;
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener detalles: " + ex.Message);
                }
            }

        }


        private void PuestoACT_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void DepartamentoACT_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox3.SelectedItem.ToString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * from departamento WHERE Nombre_Departamento = @selectedValue;";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@selectedValue", selectedValue);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string detalle1 = reader["Id"].ToString();

                        labelID2.Text = detalle1;
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    MessageBox.Show("Error al obtener detalles: " + ex.Message);
                }
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox4.SelectedItem.ToString();

            // Realizar acciones con el valor seleccionado (por ejemplo, obtener más detalles desde la base de datos)
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * from puesto WHERE Nombre_Puesto = @selectedValue;";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@selectedValue", selectedValue);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string detalle1 = reader["Id"].ToString();

                        // Mostrar los detalles en etiquetas de texto, MessageBox, o cualquier otro control de tu formulario
                        labelID1.Text = detalle1;
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    MessageBox.Show("Error al obtener detalles: " + ex.Message);
                }
            }
        }

        private void BusquedaEmpleados_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * from departamento d";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader["Nombre_Departamento"].ToString());
                        comboBox3.Items.Add(reader["Nombre_Departamento"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * from puesto p";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBox2.Items.Add(reader["Nombre_Puesto"].ToString());
                        comboBox4.Items.Add(reader["Nombre_Puesto"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }
        }
    }
}
