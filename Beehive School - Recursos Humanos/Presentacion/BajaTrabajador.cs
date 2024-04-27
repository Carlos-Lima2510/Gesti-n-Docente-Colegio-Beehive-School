using System;
using System.Windows.Forms;
using Beehive_School___Recursos_Humanos.Datos;

namespace Beehive_School___Recursos_Humanos.Presentacion
{
    public partial class BajaTrabajador : Form
    {
        public BajaTrabajador()
        {
            InitializeComponent();
            MostrarBajas();
            btn_IDRenuncia.Hide();
            btn_IDDespido.Hide();
            btn_IDAscenso.Hide();
            btn_IDCambio.Hide();
        }

        private void BajaTrabajador_Load(object sender, EventArgs e)
        {
        }
        private void MostrarBajas()
        {
            Empleados bajas = new Empleados();
            dataGridView2008.DataSource = bajas.ListarBaja2008();
            dataGridView2014.DataSource = bajas.ListarBaja2014();
            dataGridView2015.DataSource = bajas.ListarBaja2015();
            dataGridView2016.DataSource = bajas.ListarBaja2016();
            dataGridView2017.DataSource = bajas.ListarBaja2017();
            dataGridView2018.DataSource = bajas.ListarBaja2018();
            dataGridView2019.DataSource = bajas.ListarBaja2019();
            dataGridView2020.DataSource = bajas.ListarBaja2020();
            dataGridView21.DataSource = bajas.ListarBaja2021();
        }
        private void ActualizarEstado2008()
        {
            Empleados actualizar2008 = new Empleados();
            actualizar2008.ActualizarEstado2008(
                Convert.ToInt32(btn_IDRenuncia.Text), Convert.ToInt32(btn_IDDespido.Text), Convert.ToInt32(btn_IDAscenso.Text), Convert.ToInt32(btn_IDCambio.Text), Convert.ToInt32(labelID.Text)
                );
        }
        private void ActualizarEstados2014()
        {
            Empleados actualizar2014 = new Empleados();
            actualizar2014.ActualizarEstado2014(
                Convert.ToInt32(btn_IDRenuncia.Text), Convert.ToInt32(btn_IDDespido.Text), Convert.ToInt32(btn_IDAscenso.Text), Convert.ToInt32(btn_IDCambio.Text), Convert.ToInt32(labelID.Text)
                );
        }
        private void ActualizarEstados2015()
        {
            Empleados actualizar2015 = new Empleados();
            actualizar2015.ActualizarEstado2015(
                Convert.ToInt32(btn_IDRenuncia.Text), Convert.ToInt32(btn_IDDespido.Text), Convert.ToInt32(btn_IDAscenso.Text), Convert.ToInt32(btn_IDCambio.Text), Convert.ToInt32(labelID.Text)
                );
        }
        private void ActualizarEstados2016()
        {
            Empleados actualizar2016 = new Empleados();
            actualizar2016.ActualizarEstado2016(
                Convert.ToInt32(btn_IDRenuncia.Text), Convert.ToInt32(btn_IDDespido.Text), Convert.ToInt32(btn_IDAscenso.Text), Convert.ToInt32(btn_IDCambio.Text), Convert.ToInt32(labelID.Text)
                );
        }
        private void ActualizarEstados2017()
        {
            Empleados actualizar2017 = new Empleados();
            actualizar2017.ActualizarEstado2017(
                Convert.ToInt32(btn_IDRenuncia.Text), Convert.ToInt32(btn_IDDespido.Text), Convert.ToInt32(btn_IDAscenso.Text), Convert.ToInt32(btn_IDCambio.Text), Convert.ToInt32(labelID.Text)
                );
        }
        private void ActualizarEstados2018()
        {
            Empleados actualizar2018 = new Empleados();
            actualizar2018.ActualizarEstado2018(
                Convert.ToInt32(btn_IDRenuncia.Text), Convert.ToInt32(btn_IDDespido.Text), Convert.ToInt32(btn_IDAscenso.Text), Convert.ToInt32(btn_IDCambio.Text), Convert.ToInt32(labelID.Text)
                );
        }
        private void ActualizarEstados2019()
        {
            Empleados actualizar2019 = new Empleados();
            actualizar2019.ActualizarEstado2019(
                Convert.ToInt32(btn_IDRenuncia.Text), Convert.ToInt32(btn_IDDespido.Text), Convert.ToInt32(btn_IDAscenso.Text), Convert.ToInt32(btn_IDCambio.Text), Convert.ToInt32(labelID.Text)
                );
        }
        private void ActualizarEstados2020()
        {
            Empleados actualizar2020 = new Empleados();
            actualizar2020.ActualizarEstado2020(
                Convert.ToInt32(btn_IDRenuncia.Text), Convert.ToInt32(btn_IDDespido.Text), Convert.ToInt32(btn_IDAscenso.Text), Convert.ToInt32(btn_IDCambio.Text), Convert.ToInt32(labelID.Text)
                );
        }
        private void ActualizarEstados2021()
        {
            Empleados actualizar2021 = new Empleados();
            actualizar2021.ActualizarEstado2021(
                Convert.ToInt32(btn_IDRenuncia.Text), Convert.ToInt32(btn_IDDespido.Text), Convert.ToInt32(btn_IDAscenso.Text), Convert.ToInt32(btn_IDCambio.Text), Convert.ToInt32(labelID.Text)
                );
        }
        private void ActualizarEstados2022()
        {
            Empleados actualizar2022 = new Empleados();
            actualizar2022.ActualizarEstado2022(
                Convert.ToInt32(btn_IDRenuncia.Text), Convert.ToInt32(btn_IDDespido.Text), Convert.ToInt32(btn_IDAscenso.Text), Convert.ToInt32(btn_IDCambio.Text), Convert.ToInt32(labelID.Text)
                );
        }


        private void comboBoxAño_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAño.Text == "2008 - 2012")
            {
                //btn_Ingresar.Enabled = false;
                btn_Ingresar.Show();
                btn_IngresarFechaBaja.Show();
                btn_IngresarFechaIngreso2014.Hide();
                btn_IngresarFechaBaja2014.Hide();
                btn_IngresarFechaBaja2015.Hide();
                btn_IngresarFechaIngreso2015.Hide();
                btn_IngresarFechaIngreso2016.Hide();
                btn_IngresarFechaBaja2016.Hide();
                btn_IngresarFechaIngreso2017.Hide();
                btn_IngresarFechaBaja2017.Hide();
                btn_IngresarFechaIngreso2018.Hide();
                btn_IngresarFechaBaja2018.Hide();
                btn_IngresarFechaIngreso2019.Hide();
                btn_IngresarFechaBaja2019.Hide();
                btn_IngresarFechaIngreso2020.Hide();
                btn_IngresarFechaBaja2020.Hide();
                btn_IngresarFechaIngreso2021.Hide();
                btn_IngresarFechaBaja2021.Hide();
                dataGridView2008.Show();
                dataGridView2014.Hide();
                dataGridView2015.Hide();
                dataGridView2016.Hide();
                dataGridView2017.Hide();
                dataGridView2018.Hide();
                dataGridView2019.Hide();
                dataGridView2020.Hide();
                dataGridView21.Hide();
                button1.Show();
                btn_Actualizar2014.Hide();
                btn_Actualizar2015.Hide();
                btn_Actualizar2016.Hide();
                btn_Actualizar2017.Hide();
                btn_Actualizar2018.Hide();
                btn_Actualizar2019.Hide();
                btn_Actualizar2020.Hide();
                btn_Actualizar2021.Hide();

            }
            if (comboBoxAño.Text == "2014")
            {
                //btn_IngresarFechaIngreso2014.Enabled = false;
                btn_Ingresar.Hide();
                btn_IngresarFechaBaja.Hide();
                btn_IngresarFechaIngreso2014.Show();
                btn_IngresarFechaBaja2014.Show();
                btn_IngresarFechaBaja2015.Hide();
                btn_IngresarFechaIngreso2015.Hide();
                btn_IngresarFechaBaja2016.Hide();
                btn_IngresarFechaIngreso2016.Hide();
                btn_IngresarFechaIngreso2017.Hide();
                btn_IngresarFechaBaja2017.Hide();
                btn_IngresarFechaIngreso2018.Hide();
                btn_IngresarFechaBaja2018.Hide();
                btn_IngresarFechaIngreso2019.Hide();
                btn_IngresarFechaBaja2019.Hide();
                btn_IngresarFechaIngreso2020.Hide();
                btn_IngresarFechaBaja2020.Hide();
                btn_IngresarFechaIngreso2021.Hide();
                btn_IngresarFechaBaja2021.Hide();
                dataGridView2008.Hide();
                dataGridView2014.Show();
                dataGridView2015.Hide();
                dataGridView2016.Hide();
                dataGridView2017.Hide();
                dataGridView2018.Hide();
                dataGridView2019.Hide();
                dataGridView2020.Hide();
                dataGridView21.Hide();
                button1.Hide();
                btn_Actualizar2014.Show();
                btn_Actualizar2015.Hide();
                btn_Actualizar2016.Hide();
                btn_Actualizar2017.Hide();
                btn_Actualizar2018.Hide();
                btn_Actualizar2019.Hide();
                btn_Actualizar2020.Hide();
                btn_Actualizar2021.Hide();
            }
            if (comboBoxAño.Text == "2015")
            {
                //btn_IngresarFechaIngreso2015.Enabled = false;
                btn_Ingresar.Hide();
                btn_IngresarFechaBaja.Hide();
                btn_IngresarFechaIngreso2014.Hide();
                btn_IngresarFechaBaja2014.Hide();
                btn_IngresarFechaBaja2015.Show();
                btn_IngresarFechaIngreso2015.Show();
                btn_IngresarFechaBaja2016.Hide();
                btn_IngresarFechaIngreso2016.Hide();
                btn_IngresarFechaIngreso2017.Hide();
                btn_IngresarFechaBaja2017.Hide();
                btn_IngresarFechaIngreso2018.Hide();
                btn_IngresarFechaBaja2018.Hide();
                btn_IngresarFechaIngreso2019.Hide();
                btn_IngresarFechaBaja2019.Hide();
                btn_IngresarFechaIngreso2020.Hide();
                btn_IngresarFechaBaja2020.Hide();
                btn_IngresarFechaIngreso2021.Hide();
                btn_IngresarFechaBaja2021.Hide();
                dataGridView2008.Hide();
                dataGridView2014.Hide();
                dataGridView2015.Show();
                dataGridView2016.Hide();
                dataGridView2017.Hide();
                dataGridView2018.Hide();
                dataGridView2019.Hide();
                dataGridView2020.Hide();
                dataGridView21.Hide();
                button1.Hide();
                btn_Actualizar2014.Hide();
                btn_Actualizar2015.Show();
                btn_Actualizar2016.Hide();
                btn_Actualizar2017.Hide();
                btn_Actualizar2018.Hide();
                btn_Actualizar2019.Hide();
                btn_Actualizar2020.Hide();
                btn_Actualizar2021.Hide();
            }
            if (comboBoxAño.Text == "2016")
            {
                btn_Ingresar.Hide();
                btn_IngresarFechaBaja.Hide();
                btn_IngresarFechaIngreso2014.Hide();
                btn_IngresarFechaBaja2014.Hide();
                btn_IngresarFechaBaja2015.Hide();
                btn_IngresarFechaIngreso2015.Hide();
                btn_IngresarFechaBaja2016.Show();
                btn_IngresarFechaIngreso2016.Show();
                btn_IngresarFechaIngreso2017.Hide();
                btn_IngresarFechaBaja2017.Hide();
                btn_IngresarFechaIngreso2018.Hide();
                btn_IngresarFechaBaja2018.Hide();
                btn_IngresarFechaIngreso2019.Hide();
                btn_IngresarFechaBaja2019.Hide();
                btn_IngresarFechaIngreso2020.Hide();
                btn_IngresarFechaBaja2020.Hide();
                btn_IngresarFechaIngreso2021.Hide();
                btn_IngresarFechaBaja2021.Hide();
                dataGridView2008.Hide();
                dataGridView2014.Hide();
                dataGridView2015.Hide();
                dataGridView2016.Show();
                dataGridView2017.Hide();
                dataGridView2018.Hide();
                dataGridView2019.Hide();
                dataGridView2020.Hide();
                dataGridView21.Hide();
                button1.Hide();
                btn_Actualizar2014.Hide();
                btn_Actualizar2015.Hide();
                btn_Actualizar2016.Show();
                btn_Actualizar2017.Hide();
                btn_Actualizar2018.Hide();
                btn_Actualizar2019.Hide();
                btn_Actualizar2020.Hide();
                btn_Actualizar2021.Hide();
            }
            if (comboBoxAño.Text == "2017")
            {
                btn_Ingresar.Hide();
                btn_IngresarFechaBaja.Hide();
                btn_IngresarFechaIngreso2014.Hide();
                btn_IngresarFechaBaja2014.Hide();
                btn_IngresarFechaBaja2015.Hide();
                btn_IngresarFechaIngreso2015.Hide();
                btn_IngresarFechaBaja2016.Hide();
                btn_IngresarFechaIngreso2016.Hide();
                btn_IngresarFechaIngreso2017.Show();
                btn_IngresarFechaBaja2017.Show();
                btn_IngresarFechaIngreso2018.Hide();
                btn_IngresarFechaBaja2018.Hide();
                btn_IngresarFechaIngreso2019.Hide();
                btn_IngresarFechaBaja2019.Hide();
                btn_IngresarFechaIngreso2020.Hide();
                btn_IngresarFechaBaja2020.Hide();
                btn_IngresarFechaIngreso2021.Hide();
                btn_IngresarFechaBaja2021.Hide();
                dataGridView2008.Hide();
                dataGridView2014.Hide();
                dataGridView2015.Hide();
                dataGridView2016.Hide();
                dataGridView2017.Show();
                dataGridView2018.Hide();
                dataGridView2019.Hide();
                dataGridView2020.Hide();
                dataGridView21.Hide();
                button1.Hide();
                btn_Actualizar2014.Hide();
                btn_Actualizar2015.Hide();
                btn_Actualizar2016.Hide(); 
                btn_Actualizar2017.Show();
                btn_Actualizar2018.Hide();
                btn_Actualizar2019.Hide();
                btn_Actualizar2020.Hide();
                btn_Actualizar2021.Hide();
            }
            if (comboBoxAño.Text == "2018")
            {
                btn_Ingresar.Hide();
                btn_IngresarFechaBaja.Hide();
                btn_IngresarFechaIngreso2014.Hide();
                btn_IngresarFechaBaja2014.Hide();
                btn_IngresarFechaBaja2015.Hide();
                btn_IngresarFechaIngreso2015.Hide();
                btn_IngresarFechaBaja2016.Hide();
                btn_IngresarFechaIngreso2016.Hide();
                btn_IngresarFechaIngreso2017.Hide();
                btn_IngresarFechaBaja2017.Hide();
                btn_IngresarFechaIngreso2018.Show();
                btn_IngresarFechaBaja2018.Show();
                btn_IngresarFechaIngreso2019.Hide();
                btn_IngresarFechaBaja2019.Hide();
                btn_IngresarFechaIngreso2020.Hide();
                btn_IngresarFechaBaja2020.Hide();
                btn_IngresarFechaIngreso2021.Hide();
                btn_IngresarFechaBaja2021.Hide();
                dataGridView2008.Hide();
                dataGridView2014.Hide();
                dataGridView2015.Hide();
                dataGridView2016.Hide();
                dataGridView2017.Hide();
                dataGridView2018.Show();
                dataGridView2019.Hide();
                dataGridView2020.Hide();
                dataGridView21.Hide();
                button1.Hide();
                btn_Actualizar2014.Hide();
                btn_Actualizar2015.Hide();
                btn_Actualizar2016.Hide();
                btn_Actualizar2017.Hide();
                btn_Actualizar2018.Show();
                btn_Actualizar2019.Hide();
                btn_Actualizar2020.Hide();
                btn_Actualizar2021.Hide();
            }
            if (comboBoxAño.Text == "2019")
            {
                btn_Ingresar.Hide();
                btn_IngresarFechaBaja.Hide();
                btn_IngresarFechaIngreso2014.Hide();
                btn_IngresarFechaBaja2014.Hide();
                btn_IngresarFechaBaja2015.Hide();
                btn_IngresarFechaIngreso2015.Hide();
                btn_IngresarFechaBaja2016.Hide();
                btn_IngresarFechaIngreso2016.Hide();
                btn_IngresarFechaIngreso2017.Hide();
                btn_IngresarFechaBaja2017.Hide();
                btn_IngresarFechaIngreso2018.Hide();
                btn_IngresarFechaBaja2018.Hide();
                btn_IngresarFechaIngreso2019.Show();
                btn_IngresarFechaBaja2019.Show();
                btn_IngresarFechaIngreso2020.Hide();
                btn_IngresarFechaBaja2020.Hide();
                btn_IngresarFechaIngreso2021.Hide();
                btn_IngresarFechaBaja2021.Hide();
                dataGridView2008.Hide();
                dataGridView2014.Hide();
                dataGridView2015.Hide();
                dataGridView2016.Hide();
                dataGridView2017.Hide();
                dataGridView2018.Hide();
                dataGridView2019.Show();
                dataGridView2020.Hide();
                dataGridView21.Hide();
                button1.Hide();
                btn_Actualizar2014.Hide();
                btn_Actualizar2015.Hide();
                btn_Actualizar2016.Hide();
                btn_Actualizar2017.Hide();
                btn_Actualizar2018.Hide();
                btn_Actualizar2019.Show();
                btn_Actualizar2020.Hide();
                btn_Actualizar2021.Hide();
            }
            if (comboBoxAño.Text == "2020")
            {
                btn_Ingresar.Hide();
                btn_IngresarFechaBaja.Hide();
                btn_IngresarFechaIngreso2014.Hide();
                btn_IngresarFechaBaja2014.Hide();
                btn_IngresarFechaBaja2015.Hide();
                btn_IngresarFechaIngreso2015.Hide();
                btn_IngresarFechaBaja2016.Hide();
                btn_IngresarFechaIngreso2016.Hide();
                btn_IngresarFechaIngreso2017.Hide();
                btn_IngresarFechaBaja2017.Hide();
                btn_IngresarFechaIngreso2018.Hide();
                btn_IngresarFechaBaja2018.Hide();
                btn_IngresarFechaIngreso2019.Hide();
                btn_IngresarFechaBaja2019.Hide();
                btn_IngresarFechaIngreso2020.Show();
                btn_IngresarFechaBaja2020.Show();
                btn_IngresarFechaIngreso2021.Hide();
                btn_IngresarFechaBaja2021.Hide();
                dataGridView2008.Hide();
                dataGridView2014.Hide();
                dataGridView2015.Hide();
                dataGridView2016.Hide();
                dataGridView2017.Hide();
                dataGridView2018.Hide();
                dataGridView2019.Hide();
                dataGridView2020.Show();
                dataGridView21.Hide();
                button1.Hide();
                btn_Actualizar2014.Hide();
                btn_Actualizar2015.Hide();
                btn_Actualizar2016.Hide();
                btn_Actualizar2017.Hide();
                btn_Actualizar2018.Hide();
                btn_Actualizar2019.Hide();
                btn_Actualizar2020.Show();
                btn_Actualizar2021.Hide();
            }
            if (comboBoxAño.Text == "2021")
            {
                btn_Ingresar.Hide();
                btn_IngresarFechaBaja.Hide();
                btn_IngresarFechaIngreso2014.Hide();
                btn_IngresarFechaBaja2014.Hide();
                btn_IngresarFechaBaja2015.Hide();
                btn_IngresarFechaIngreso2015.Hide();
                btn_IngresarFechaBaja2016.Hide();
                btn_IngresarFechaIngreso2016.Hide();
                btn_IngresarFechaIngreso2017.Hide();
                btn_IngresarFechaBaja2017.Hide();
                btn_IngresarFechaIngreso2018.Hide();
                btn_IngresarFechaBaja2018.Hide();
                btn_IngresarFechaIngreso2019.Hide();
                btn_IngresarFechaBaja2019.Hide();
                btn_IngresarFechaIngreso2020.Hide();
                btn_IngresarFechaBaja2020.Hide();
                btn_IngresarFechaIngreso2021.Show();
                btn_IngresarFechaBaja2021.Show();
                dataGridView2008.Hide();
                dataGridView2014.Hide();
                dataGridView2015.Hide();
                dataGridView2016.Hide();
                dataGridView2017.Hide();
                dataGridView2018.Hide();
                dataGridView2019.Hide();
                dataGridView2020.Hide();
                dataGridView21.Show();
                button1.Hide();
                btn_Actualizar2014.Hide();
                btn_Actualizar2015.Hide();
                btn_Actualizar2016.Hide();
                btn_Actualizar2017.Hide();
                btn_Actualizar2018.Hide();
                btn_Actualizar2019.Hide();
                btn_Actualizar2020.Hide();
                btn_Actualizar2021.Show();
            }

        }

        private void InsertarIngreso2008()
        {
            Empleados ingreso2008 = new Empleados();
            ingreso2008.InsertarFechaIngreso_2008(
                dateTimePickerIngreso.Text, Convert.ToInt32(labelID.Text)
                );
        }
        private void InsertarBaja2008()
        {
            Empleados ingreso2008 = new Empleados();
            ingreso2008.InsertarFechaBaja_2008(
                dateTimePickerBaja.Text, Convert.ToInt32(labelID2.Text)
                );
        }
        private void InsertarIngreso2014()
        {
            Empleados ingreso2014 = new Empleados();
            ingreso2014.InsertarFechaIngreso_2014(
                dateTimePickerIngreso.Text, Convert.ToInt32(labelID.Text)
                );
        }
        private void InsertarBaja2014()
        {
            Empleados insertarbaja2014 = new Empleados();
            insertarbaja2014.InsertarFechaBaja_2014(
                dateTimePickerBaja.Text, Convert.ToInt32(labelID2.Text)
                );
        }
        private void InsertarIngreso2015()
        {
            Empleados ingreso2015 = new Empleados();
            ingreso2015.InsertarFechaIngreso_2015(
                dateTimePickerIngreso.Text, Convert.ToInt32(labelID.Text)
                );
        }
        private void InsertarBaja2015()
        {
            Empleados ingreso2015 = new Empleados();
            ingreso2015.InsertarFechaBaja_2015(
                dateTimePickerBaja.Text, Convert.ToInt32(labelID.Text)
                );
        }
        private void InsertarIngreso2016()
        {
            Empleados ingreso2016 = new Empleados();
            ingreso2016.InsertarFechaIngreso_2016(
                dateTimePickerIngreso.Text, Convert.ToInt32(labelID.Text)
                );
        }
        private void InsertarBaja2016()
        {
            Empleados insertarbaja2016 = new Empleados();
            insertarbaja2016.InsertarFechaBaja_2016(
                dateTimePickerBaja.Text, Convert.ToInt32(labelID.Text)
                );
        }
        private void InsertarIngreso2017()
        {
            Empleados ingreso2017 = new Empleados();
            ingreso2017.InsertarFechaIngreso_2017(
                dateTimePickerIngreso.Text, Convert.ToInt32(labelID.Text)
                );
        }
        private void InsertarBaja2017()
        {
            Empleados insertarbaja2017 = new Empleados();
            insertarbaja2017.InsertarFechaBaja_2017(
                dateTimePickerBaja.Text, Convert.ToInt32(labelID.Text)
                );
        }
        private void InsertarIngreso2018()
        {
            Empleados ingreso2018 = new Empleados();
            ingreso2018.InsertarFechaIngreso_2018(
                dateTimePickerIngreso.Text, Convert.ToInt32(labelID.Text)
                );
        }
        private void InsertarBaja2018()
        {
            Empleados insertarbaja2018 = new Empleados();
            insertarbaja2018.InsertarFechaBaja_2018(
                dateTimePickerBaja.Text, Convert.ToInt32(labelID.Text)
                );
        }
        private void InsertarIngreso2019()
        {
            Empleados ingreso2019 = new Empleados();
            ingreso2019.InsertarFechaIngreso_2019(
                dateTimePickerIngreso.Text, Convert.ToInt32(labelID.Text)
                );
        }
        private void InsertarBaja2019()
        {
            Empleados insertarbaja2019 = new Empleados();
            insertarbaja2019.InsertarFechaBaja_2019(
                dateTimePickerBaja.Text, Convert.ToInt32(labelID.Text)
                );
        }
        private void InsertarIngreso2020()
        {
            Empleados ingreso2020 = new Empleados();
            ingreso2020.InsertarFechaIngreso_2020(
                dateTimePickerIngreso.Text, Convert.ToInt32(labelID.Text)
                );
        }
        private void InsertarBaja2020()
        {
            Empleados insertarbaja2020 = new Empleados();
            insertarbaja2020.InsertarFechaBaja_2020(
                dateTimePickerBaja.Text, Convert.ToInt32(labelID.Text)
                );
        }
        private void InsertarIngreso2021()
        {
            Empleados ingreso2021 = new Empleados();
            ingreso2021.InsertarFechaIngreso_2021(
                dateTimePickerIngreso.Text, Convert.ToInt32(labelID.Text)
                );
        }
        private void InsertarBaja2021()
        {
            Empleados insertarbaja2021 = new Empleados();
            insertarbaja2021.InsertarFechaBaja_2021(
                dateTimePickerBaja.Text, Convert.ToInt32(labelID.Text)
                );
        }
        private void InsertarIngreso2022()
        {
            Empleados ingreso2022 = new Empleados();
            ingreso2022.InsertarFechaIngreso_2022(
                dateTimePickerIngreso.Text, Convert.ToInt32(labelID.Text)
                );
        }
        private void InsertarBaja2022()
        {
            Empleados insertarbaja2022 = new Empleados();
            insertarbaja2022.InsertarFechaBaja_2022(
                dateTimePickerBaja.Text, Convert.ToInt32(labelID.Text)
                );
        }
        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
                InsertarIngreso2008();
                MostrarBajas();
        }

        private void dataGridView2008_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            labelID.Text = dataGridView2008.Rows[e.RowIndex].Cells[0].Value.ToString();
            labelID2.Text = dataGridView2008.Rows[e.RowIndex].Cells[0].Value.ToString();
            dateTimePickerIngreso.Text = dataGridView2008.Rows[e.RowIndex].Cells[3].Value.ToString();
            btn_IDRenuncia.Text = dataGridView2008.Rows[e.RowIndex].Cells[7].Value.ToString();
            btn_IDDespido.Text = dataGridView2008.Rows[e.RowIndex].Cells[8].Value.ToString();
            btn_IDAscenso.Text = dataGridView2008.Rows[e.RowIndex].Cells[9].Value.ToString();
            btn_IDCambio.Text = dataGridView2008.Rows[e.RowIndex].Cells[10].Value.ToString();
        }

        private void btn_IngresarFechaBaja_Click(object sender, EventArgs e)
        {
            InsertarBaja2008();
            MostrarBajas();
        }

        private void radioButtonRenuncia_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRenuncia.Checked == true)
            {
                btn_IDRenuncia.Text = "1";
            }
            else
            {
                btn_IDRenuncia.Text = "0";
            }
            if (radioButtonDespido.Checked == true)
            {
                btn_IDDespido.Text = "1";
            }
            else
            {
                btn_IDDespido.Text = "0";
            }
        }

        private void radioButtonAscenso_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAscenso.Checked == true)
            {
                btn_IDAscenso.Text = "1";
                btn_IDRenuncia.Text = "0";
                btn_IDDespido.Text = "0";
                btn_IDCambio.Text = "0";
            }
            else
            {
                btn_IDAscenso.Text = "0";
            }
        }

        private void radioButtonDespido_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDespido.Checked == true)
            {
                btn_IDDespido.Text = "1";
                btn_IDRenuncia.Text = "0";
                btn_IDAscenso.Text = "0";
                btn_IDCambio.Text = "0";
            }
            else
            {
                btn_IDDespido.Text = "0";
            }

        }

        private void radioButtonCambio_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCambio.Checked == true)
            {
                btn_IDDespido.Text = "0";
                btn_IDRenuncia.Text = "0";
                btn_IDAscenso.Text = "0";
                btn_IDCambio.Text = "1";
            }
            else
            {
                btn_IDCambio.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActualizarEstado2008();
            MostrarBajas();
        }

        private void radioButton0_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCambio.Checked == true)
            {
                btn_IDDespido.Text = "0";
                btn_IDRenuncia.Text = "0";
                btn_IDAscenso.Text = "0";
                btn_IDCambio.Text = "0";
            }
        }

        private void dataGridView2014_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            labelID.Text = dataGridView2014.Rows[e.RowIndex].Cells[0].Value.ToString();
            labelID2.Text = dataGridView2014.Rows[e.RowIndex].Cells[0].Value.ToString();
            dateTimePickerIngreso.Text = dataGridView2014.Rows[e.RowIndex].Cells[3].Value.ToString();
            btn_IDRenuncia.Text = dataGridView2014.Rows[e.RowIndex].Cells[7].Value.ToString();
            btn_IDDespido.Text = dataGridView2014.Rows[e.RowIndex].Cells[8].Value.ToString();
            btn_IDAscenso.Text = dataGridView2014.Rows[e.RowIndex].Cells[9].Value.ToString();
            btn_IDCambio.Text = dataGridView2014.Rows[e.RowIndex].Cells[10].Value.ToString();
        }

        private void btn_IngresarFechaIngreso2014_Click(object sender, EventArgs e)
        {
            InsertarIngreso2014();
            MostrarBajas();
        }

        private void btn_IngresarFechaBaja2014_Click(object sender, EventArgs e)
        {
            InsertarBaja2014();
            MostrarBajas();
        }

        private void btn_Actualizar2014_Click(object sender, EventArgs e)
        {
            ActualizarEstados2014();
            MostrarBajas();
        }

        private void btn_IngresarFechaIngreso2015_Click(object sender, EventArgs e)
        {
            InsertarIngreso2015();
            MostrarBajas();
        }

        private void btn_IngresarFechaBaja2015_Click(object sender, EventArgs e)
        {
            InsertarBaja2015();
            MostrarBajas();
        }

        private void dataGridView2015_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            labelID.Text = dataGridView2015.Rows[e.RowIndex].Cells[0].Value.ToString();
            labelID2.Text = dataGridView2015.Rows[e.RowIndex].Cells[0].Value.ToString();
            dateTimePickerIngreso.Text = dataGridView2015.Rows[e.RowIndex].Cells[3].Value.ToString();
            btn_IDRenuncia.Text = dataGridView2015.Rows[e.RowIndex].Cells[7].Value.ToString();
            btn_IDDespido.Text = dataGridView2015.Rows[e.RowIndex].Cells[8].Value.ToString();
            btn_IDAscenso.Text = dataGridView2015.Rows[e.RowIndex].Cells[9].Value.ToString();
            btn_IDCambio.Text = dataGridView2015.Rows[e.RowIndex].Cells[10].Value.ToString();
        }

        private void btn_Actualizar2015_Click(object sender, EventArgs e)
        {
            ActualizarEstados2015();
            MostrarBajas();
        }

        private void dataGridView2016_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            labelID.Text = dataGridView2016.Rows[e.RowIndex].Cells[0].Value.ToString();
            labelID2.Text = dataGridView2016.Rows[e.RowIndex].Cells[0].Value.ToString();
            dateTimePickerIngreso.Text = dataGridView2016.Rows[e.RowIndex].Cells[3].Value.ToString();
            btn_IDRenuncia.Text = dataGridView2016.Rows[e.RowIndex].Cells[7].Value.ToString();
            btn_IDDespido.Text = dataGridView2016.Rows[e.RowIndex].Cells[8].Value.ToString();
            btn_IDAscenso.Text = dataGridView2016.Rows[e.RowIndex].Cells[9].Value.ToString();
            btn_IDCambio.Text = dataGridView2016.Rows[e.RowIndex].Cells[10].Value.ToString();
        }

        private void btn_Actualizar2016_Click(object sender, EventArgs e)
        {
            ActualizarEstados2016();
            MostrarBajas();
        }

        private void btn_IngresarFechaIngreso2016_Click(object sender, EventArgs e)
        {
            InsertarIngreso2016();
            MostrarBajas();
        }

        private void btn_IngresarFechaBaja2016_Click(object sender, EventArgs e)
        {
            InsertarBaja2016();
            MostrarBajas();
        }

        private void dataGridView2017_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            labelID.Text = dataGridView2017.Rows[e.RowIndex].Cells[0].Value.ToString();
            labelID2.Text = dataGridView2017.Rows[e.RowIndex].Cells[0].Value.ToString();
            dateTimePickerIngreso.Text = dataGridView2017.Rows[e.RowIndex].Cells[3].Value.ToString();
            btn_IDRenuncia.Text = dataGridView2017.Rows[e.RowIndex].Cells[7].Value.ToString();
            btn_IDDespido.Text = dataGridView2017.Rows[e.RowIndex].Cells[8].Value.ToString();
            btn_IDAscenso.Text = dataGridView2017.Rows[e.RowIndex].Cells[9].Value.ToString();
            btn_IDCambio.Text = dataGridView2017.Rows[e.RowIndex].Cells[10].Value.ToString();
        }

        private void btn_IngresarFechaIngreso2017_Click(object sender, EventArgs e)
        {
            InsertarIngreso2017();
            MostrarBajas();
        }

        private void btn_IngresarFechaBaja2017_Click(object sender, EventArgs e)
        {
            InsertarBaja2017();
            MostrarBajas();
        }

        private void btn_Actualizar2017_Click(object sender, EventArgs e)
        {
            ActualizarEstados2017();
            MostrarBajas();
        }

        private void dataGridView2018_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            labelID.Text = dataGridView2018.Rows[e.RowIndex].Cells[0].Value.ToString();
            labelID2.Text = dataGridView2018.Rows[e.RowIndex].Cells[0].Value.ToString();
            dateTimePickerIngreso.Text = dataGridView2018.Rows[e.RowIndex].Cells[3].Value.ToString();
            btn_IDRenuncia.Text = dataGridView2018.Rows[e.RowIndex].Cells[7].Value.ToString();
            btn_IDDespido.Text = dataGridView2018.Rows[e.RowIndex].Cells[8].Value.ToString();
            btn_IDAscenso.Text = dataGridView2018.Rows[e.RowIndex].Cells[9].Value.ToString();
            btn_IDCambio.Text = dataGridView2018.Rows[e.RowIndex].Cells[10].Value.ToString();
        }

        private void btn_Actualizar2018_Click(object sender, EventArgs e)
        {
            ActualizarEstados2018();
            MostrarBajas();
        }

        private void btn_IngresarFechaIngreso2018_Click(object sender, EventArgs e)
        {
            InsertarIngreso2018();
            MostrarBajas();
        }

        private void btn_IngresarFechaBaja2018_Click(object sender, EventArgs e)
        {
            InsertarBaja2018();
            MostrarBajas();
        }

        private void dataGridView2019_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            labelID.Text = dataGridView2019.Rows[e.RowIndex].Cells[0].Value.ToString();
            labelID2.Text = dataGridView2019.Rows[e.RowIndex].Cells[0].Value.ToString();
            dateTimePickerIngreso.Text = dataGridView2019.Rows[e.RowIndex].Cells[3].Value.ToString();
            btn_IDRenuncia.Text = dataGridView2019.Rows[e.RowIndex].Cells[7].Value.ToString();
            btn_IDDespido.Text = dataGridView2019.Rows[e.RowIndex].Cells[8].Value.ToString();
            btn_IDAscenso.Text = dataGridView2019.Rows[e.RowIndex].Cells[9].Value.ToString();
            btn_IDCambio.Text = dataGridView2019.Rows[e.RowIndex].Cells[10].Value.ToString();
        }

        private void btn_IngresarFechaIngreso2019_Click(object sender, EventArgs e)
        {
            InsertarIngreso2019();
            MostrarBajas();
        }

        private void dataGridView2020_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            labelID.Text = dataGridView2020.Rows[e.RowIndex].Cells[0].Value.ToString();
            labelID2.Text = dataGridView2020.Rows[e.RowIndex].Cells[0].Value.ToString();
            dateTimePickerIngreso.Text = dataGridView2020.Rows[e.RowIndex].Cells[3].Value.ToString();
            btn_IDRenuncia.Text = dataGridView2020.Rows[e.RowIndex].Cells[7].Value.ToString();
            btn_IDDespido.Text = dataGridView2020.Rows[e.RowIndex].Cells[8].Value.ToString();
            btn_IDAscenso.Text = dataGridView2020.Rows[e.RowIndex].Cells[9].Value.ToString();
            btn_IDCambio.Text = dataGridView2020.Rows[e.RowIndex].Cells[10].Value.ToString();
        }

        private void btn_IngresarFechaBaja2019_Click(object sender, EventArgs e)
        {
            InsertarBaja2019();
            MostrarBajas();
        }

        private void btn_IngresarFechaBaja2020_Click(object sender, EventArgs e)
        {
            InsertarBaja2020();
            MostrarBajas();
        }

        private void btn_Actualizar2020_Click(object sender, EventArgs e)
        {
            ActualizarEstados2020();
            MostrarBajas();
        }

        private void btn_Actualizar2019_Click(object sender, EventArgs e)
        {
            ActualizarEstados2019();
            MostrarBajas();
        }

        private void btn_IngresarFechaIngreso2020_Click(object sender, EventArgs e)
        {
            InsertarIngreso2020();
            MostrarBajas();
        }

        private void dataGridView21_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            labelID.Text = dataGridView21.Rows[e.RowIndex].Cells[0].Value.ToString();
            labelID2.Text = dataGridView21.Rows[e.RowIndex].Cells[0].Value.ToString();
            dateTimePickerIngreso.Text = dataGridView21.Rows[e.RowIndex].Cells[3].Value.ToString();
            btn_IDRenuncia.Text = dataGridView21.Rows[e.RowIndex].Cells[7].Value.ToString();
            btn_IDDespido.Text = dataGridView21.Rows[e.RowIndex].Cells[8].Value.ToString();
            btn_IDAscenso.Text = dataGridView21.Rows[e.RowIndex].Cells[9].Value.ToString();
            btn_IDCambio.Text = dataGridView21.Rows[e.RowIndex].Cells[10].Value.ToString();
        }

        private void btn_IngresarFechaIngreso2021_Click(object sender, EventArgs e)
        {
            InsertarIngreso2021();
            MostrarBajas();
        }

        private void btn_IngresarFechaBaja2021_Click(object sender, EventArgs e)
        {
            InsertarBaja2021();
            MostrarBajas();
        }

        private void btn_Actualizar2021_Click(object sender, EventArgs e)
        {
            ActualizarEstados2021();
            MostrarBajas();
        }

        private void dataGridView2022_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            labelID.Text = dataGridView2022.Rows[e.RowIndex].Cells[0].Value.ToString();
            labelID2.Text = dataGridView2022.Rows[e.RowIndex].Cells[0].Value.ToString();
            dateTimePickerIngreso.Text = dataGridView2022.Rows[e.RowIndex].Cells[3].Value.ToString();
            btn_IDRenuncia.Text = dataGridView2022.Rows[e.RowIndex].Cells[7].Value.ToString();
            btn_IDDespido.Text = dataGridView2022.Rows[e.RowIndex].Cells[8].Value.ToString();
            btn_IDAscenso.Text = dataGridView2022.Rows[e.RowIndex].Cells[9].Value.ToString();
            btn_IDCambio.Text = dataGridView2022.Rows[e.RowIndex].Cells[10].Value.ToString();

        }

        private void btn_IngresarFechaIngreso2022_Click(object sender, EventArgs e)
        {
            InsertarIngreso2022();
            MostrarBajas();
        }

        private void btn_IngresarBaja2022_Click(object sender, EventArgs e)
        {
            InsertarBaja2022();
            MostrarBajas();
        }

        private void btn_Actualizar2022_Click(object sender, EventArgs e)
        {
            ActualizarEstados2022();
            MostrarBajas();
        }
    }
}
