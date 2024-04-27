using Beehive_School___Recursos_Humanos.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beehive_School___Recursos_Humanos.Presentacion
{
    public partial class CreacionPlaza : Form
    {
        private string connectionString = "Server= LAPTOP-C3RL3T0; DataBase=Beehive_RRHH; Integrated Security=true";

        public CreacionPlaza()
        {
            InitializeComponent();
            MostrarPersonas();
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void MostrarPersonas() //Metodo para mostrar tabla Persona 
        {
            Reclutamiento Mostrar = new Reclutamiento(); //instancia de clase
            dataGridViewPlazas.DataSource = Mostrar.ListarPlaza();
            dataGridViewACT.DataSource = Mostrar.ListarPlaza();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            InsertarPLAZAS();
            MostrarPersonas();
        }
        private void InsertarPLAZAS()
        {
            Reclutamiento Insertar = new Reclutamiento();
            Insertar.InsertarPlaza(
                textPrimerNombre.Text, textPrimerApellido.Text,
                Convert.ToInt32(textTelefono.Text), textFuente.Text, ComboID.Text);

            MessageBox.Show("Insertado Correctamente");
        }
        private void EliminarPlazas()
        {
            Reclutamiento eliminar = new Reclutamiento();
            eliminar.Eliminar(Convert.ToInt32(IDLabel.Text));
        }

        private void dataGridViewPlazas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {    
        }

        private void CreacionPlaza_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * from Plaza p";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader["NombrePlaza"].ToString());
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem.ToString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * from Plaza WHERE NombrePlaza = @selectedValue;";
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
        private void Actualizar()
        {
            Reclutamiento actualizar = new Reclutamiento();
            actualizar.Actualizar(
                Convert.ToInt32(IDLabel.Text), PrimerNombreACT.Text, PrimerApellidoACT.Text, Convert.ToInt32(TelefonoACT.Text), FuenteACT.Text,idPlaza.Text
                );
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Actualizar();
            MostrarPersonas();
        }

        private void dataGridViewACT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDLabel.Text = dataGridViewACT.Rows[e.RowIndex].Cells[0].Value.ToString();
            PrimerNombreACT.Text = dataGridViewACT.Rows[e.RowIndex].Cells[1].Value.ToString();
            PrimerApellidoACT.Text = dataGridViewACT.Rows[e.RowIndex].Cells[2].Value.ToString();
            TelefonoACT.Text = dataGridViewACT.Rows[e.RowIndex].Cells[3].Value.ToString();
            FuenteACT.Text = dataGridViewACT.Rows[e.RowIndex].Cells[4].Value.ToString();
            comboACT.Text = dataGridViewACT.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void comboACT_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboACT.SelectedItem.ToString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * from Plaza WHERE NombrePlaza = @selectedValue;";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@selectedValue", selectedValue);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string detalle1 = reader["Id"].ToString();

                        idPlaza.Text = detalle1;
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener detalles: " + ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EliminarPlazas();
            MostrarPersonas();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
