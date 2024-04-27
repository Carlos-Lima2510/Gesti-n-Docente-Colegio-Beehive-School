using System;
using System.Windows.Forms;
using Beehive_School___Recursos_Humanos.Datos;

namespace Beehive_School___Recursos_Humanos
{
    public partial class btn_Actualizar : Form
    {
        public btn_Actualizar()
        {
            InitializeComponent();
            MostrarPlaza2();
            MostrarPlazaJI();
            MostrarPlazaMI();
            MostrarPlazaRelacion();
            MostrarResumen();
        }

        private void btn_Seleccionar_Click(object sender, EventArgs e)
        {
            ActualizarPlaza();
            MostrarPlaza2();
        }
        private void MostrarPlaza2()
        {
            Reclutamiento reclutamiento = new Reclutamiento();
            dataGridViewPlazaS.DataSource = reclutamiento.ListarPlaza2();
        }
        private void MostrarPlazaJI()
        {
            Reclutamiento reclutamiento = new Reclutamiento();
            dataGridViewJI.DataSource = reclutamiento.ListarJI();

        }
        private void MostrarPlazaMI()
        {
            Reclutamiento reclutamiento = new Reclutamiento();
            dataGridViewMI.DataSource = reclutamiento.ListarMI();

        }
        private void MostrarPlazaRelacion()
        {
            Reclutamiento relaciones = new Reclutamiento();
            dataGridViewRelaciones.DataSource = relaciones.ListarRelaciones();
        }

        private void MostrarResumen()
        {
            Reclutamiento resumen = new Reclutamiento();
            dataGridViewMostrar.DataSource = resumen.ListarResumen();
        }
        private void ActualizarPlaza()
        {
            Reclutamiento Actualizar = new Reclutamiento();
            Actualizar.ActualizarPlaza(
                Convert.ToInt32(IDlabel1.Text),dateTimePickerEvaluacion.Text, Convert.ToInt32(Exptext.Text), Convert.ToInt32(textAcademica.Text), Convert.ToInt32(textFluidez.Text), Convert.ToInt32(textDesenvolvimiento.Text), Convert.ToInt32(textConocimiento.Text), Convert.ToInt32(textCondiciones.Text), Convert.ToInt32(textTotal.Text)
                );

        }
        private void ActualizarEntJI()
        {
            Reclutamiento JI = new Reclutamiento();
            JI.ActualizarJI(
                Convert.ToInt32(IDlabelJI.Text), Convert.ToInt32(textTotalJI.Text)
                );
        }
        private void ActualizarEntMI()
        {
            Reclutamiento MI = new Reclutamiento();
            MI.ActualizarMI(
                Convert.ToInt32(ID_MAP.Text), Convert.ToInt32(lenguage_txt.Text),Convert.ToInt32(Reading_txt.Text)
                );
        }
        private void InsertarPMAP()
        {
            Reclutamiento reclutamiento = new Reclutamiento();
            reclutamiento.PuntajesMap(
                Convert.ToInt32(lenguage_txt.Text), Convert.ToInt32(Reading_txt.Text), Convert.ToInt32(ID_MAP.Text)
                );
        }
        private void InsertarFJI()
        {
            Reclutamiento FJI = new Reclutamiento();
            FJI.InsertarFechaJI(
                dateTimePickerJI.Text, Convert.ToInt32(IDlabelJI.Text)
                );
        }

        private void dataGridViewPlazaI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridViewPlazaS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDlabel1.Text = dataGridViewPlazaS.Rows[e.RowIndex].Cells[0].Value.ToString();
            IDnombre.Text = dataGridViewPlazaS.Rows[e.RowIndex].Cells[1].Value.ToString();
            IDapellido.Text = dataGridViewPlazaS.Rows[e.RowIndex].Cells[2].Value.ToString();
            IDplaza.Text = dataGridViewPlazaS.Rows[e.RowIndex].Cells[3].Value.ToString();
            dateTimePickerEvaluacion.Text = dataGridViewPlazaS.Rows[e.RowIndex].Cells[4].Value.ToString();
            Exptext.Text = dataGridViewPlazaS.Rows[e.RowIndex].Cells[5].Value.ToString();
            textAcademica.Text = dataGridViewPlazaS.Rows[e.RowIndex].Cells[6].Value.ToString();
            textFluidez.Text = dataGridViewPlazaS.Rows[e.RowIndex].Cells[7].Value.ToString();
            textDesenvolvimiento.Text = dataGridViewPlazaS.Rows[e.RowIndex].Cells[8].Value.ToString();
            textConocimiento.Text = dataGridViewPlazaS.Rows[e.RowIndex].Cells[9].Value.ToString();
            textCondiciones.Text = dataGridViewPlazaS.Rows[e.RowIndex].Cells[10].Value.ToString();
            textTotal.Text = dataGridViewPlazaS.Rows[e.RowIndex].Cells[11].Value.ToString();
        }

        private void Exptext_TextChanged(object sender, EventArgs e)
        {
            int sum = 0;

            if (int.TryParse(Exptext.Text, out int num1))
                sum += num1;

            if (int.TryParse(textAcademica.Text, out int num2))
                sum += num2;

            if (int.TryParse(textFluidez.Text, out int num3))
                sum += num3;

            if (int.TryParse(textDesenvolvimiento.Text, out int num4))
                sum += num4;

            if (int.TryParse(textConocimiento.Text, out int num5))
                sum += num5;

            if (int.TryParse(textCondiciones.Text, out int num6))
                sum += num6;

            textTotal.Text = sum.ToString();
        }

        private void textTotal_TextChanged(object sender, EventArgs e)
        {
            int sum = 0;

            if (int.TryParse(Exptext.Text, out int num1))
                sum += num1;

            if (int.TryParse(textAcademica.Text, out int num2))
                sum += num2;

            if (int.TryParse(textFluidez.Text, out int num3))
                sum += num3;

            if (int.TryParse(textDesenvolvimiento.Text, out int num4))
                sum += num4;

            if (int.TryParse(textConocimiento.Text, out int num5))
                sum += num5;

            if (int.TryParse(textCondiciones.Text, out int num6))
                sum += num6;

            textTotal.Text = sum.ToString();
        }

        private void textAcademica_TextChanged(object sender, EventArgs e)
        {
            int sum = 0;

            if (int.TryParse(Exptext.Text, out int num1))
                sum += num1;

            if (int.TryParse(textAcademica.Text, out int num2))
                sum += num2;

            if (int.TryParse(textFluidez.Text, out int num3))
                sum += num3;

            if (int.TryParse(textDesenvolvimiento.Text, out int num4))
                sum += num4;

            if (int.TryParse(textConocimiento.Text, out int num5))
                sum += num5;

            if (int.TryParse(textCondiciones.Text, out int num6))
                sum += num6;

            textTotal.Text = sum.ToString();
        }

        private void textFluidez_TextChanged(object sender, EventArgs e)
        {
            int sum = 0;

            if (int.TryParse(Exptext.Text, out int num1))
                sum += num1;

            if (int.TryParse(textAcademica.Text, out int num2))
                sum += num2;

            if (int.TryParse(textFluidez.Text, out int num3))
                sum += num3;

            if (int.TryParse(textDesenvolvimiento.Text, out int num4))
                sum += num4;

            if (int.TryParse(textConocimiento.Text, out int num5))
                sum += num5;

            if (int.TryParse(textCondiciones.Text, out int num6))
                sum += num6;

            textTotal.Text = sum.ToString();
        }

        private void textDesenvolvimiento_TextChanged(object sender, EventArgs e)
        {
            int sum = 0;

            if (int.TryParse(Exptext.Text, out int num1))
                sum += num1;

            if (int.TryParse(textAcademica.Text, out int num2))
                sum += num2;

            if (int.TryParse(textFluidez.Text, out int num3))
                sum += num3;

            if (int.TryParse(textDesenvolvimiento.Text, out int num4))
                sum += num4;

            if (int.TryParse(textConocimiento.Text, out int num5))
                sum += num5;

            if (int.TryParse(textCondiciones.Text, out int num6))
                sum += num6;

            textTotal.Text = sum.ToString();
        }

        private void textConocimiento_TextChanged(object sender, EventArgs e)
        {
            int sum = 0;

            if (int.TryParse(Exptext.Text, out int num1))
                sum += num1;

            if (int.TryParse(textAcademica.Text, out int num2))
                sum += num2;

            if (int.TryParse(textFluidez.Text, out int num3))
                sum += num3;

            if (int.TryParse(textDesenvolvimiento.Text, out int num4))
                sum += num4;

            if (int.TryParse(textConocimiento.Text, out int num5))
                sum += num5;

            if (int.TryParse(textCondiciones.Text, out int num6))
                sum += num6;

            textTotal.Text = sum.ToString();
        }

        private void textCondiciones_TextChanged(object sender, EventArgs e)
        {
            int sum = 0;

            if (int.TryParse(Exptext.Text, out int num1))
                sum += num1;

            if (int.TryParse(textAcademica.Text, out int num2))
                sum += num2;

            if (int.TryParse(textFluidez.Text, out int num3))
                sum += num3;

            if (int.TryParse(textDesenvolvimiento.Text, out int num4))
                sum += num4;

            if (int.TryParse(textConocimiento.Text, out int num5))
                sum += num5;

            if (int.TryParse(textCondiciones.Text, out int num6))
                sum += num6;

            textTotal.Text = sum.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btn_Ingreso_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            IDlabelJI.Text = dataGridViewJI.Rows[e.RowIndex].Cells[0].Value.ToString();
            IDnombreJI.Text = dataGridViewJI.Rows[e.RowIndex].Cells[1].Value.ToString();
            IDapellidoJI.Text = dataGridViewJI.Rows[e.RowIndex].Cells[2].Value.ToString();
            IDplazaJI.Text = dataGridViewJI.Rows[e.RowIndex].Cells[3].Value.ToString();
            dateTimePickerJI.Text = dataGridViewJI.Rows[e.RowIndex].Cells[4].Value.ToString();
            textTotalJI.Text = dataGridViewJI.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btn_ActualizarJI_Click(object sender, EventArgs e)
        {
            ActualizarEntJI();
            MostrarPlazaJI();
        }

        private void EvaluacionPlazas_Load(object sender, EventArgs e)
        {
            foreach (TabPage tabPage5 in tabControl1.TabPages)
            {
                tabPage5.MouseDown += tabPage5_MouseDown;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertarFJI();
            MostrarPlazaJI();
        }

        private void Puntaje_Btn_Click(object sender, EventArgs e)
        {

        }

        private void Puntaje_Btn_Click_1(object sender, EventArgs e)
        {
            ActualizarEntMI();
            InsertarPMAP();
            MostrarPlazaMI();
        }

        private void InsertarRelacionesLaborales()
        {
            Reclutamiento reclutamiento = new Reclutamiento();
            reclutamiento.RelacionesLaborales(
                Convert.ToInt32(textR_Jefe.Text), Convert.ToInt32(textR_Estudiantes.Text), Convert.ToInt32(textR_Padres.Text),Convert.ToInt32(textR_Compañeros.Text), Convert.ToInt32(textResponsabilidad.Text), Convert.ToInt32(textRTotal.Text), Convert.ToInt32(textClaseModelo.Text), Convert.ToInt32(IDrelaciones.Text) 
                );
        }
        private void ActualizarRelacionesLaborales()
        {
            Reclutamiento actualizacion = new Reclutamiento();
            actualizacion.ActualizarRelaciones(
                Convert.ToInt32(IDrelaciones.Text), Convert.ToInt32(textR_Jefe.Text), Convert.ToInt32(textR_Estudiantes.Text), Convert.ToInt32(textR_Padres.Text), Convert.ToInt32(textR_Compañeros.Text), Convert.ToInt32(textResponsabilidad.Text), Convert.ToInt32(textRTotal.Text), Convert.ToInt32(textClaseModelo.Text)
                );
        }
        private void dataGridViewMI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_MAP.Text = dataGridViewMI.Rows[e.RowIndex].Cells[0].Value.ToString();
            LBL_NOMBRE_M.Text = dataGridViewMI.Rows[e.RowIndex].Cells[1].Value.ToString();
            LBL_APELLIDO_M.Text = dataGridViewMI.Rows[e.RowIndex].Cells[2].Value.ToString();
            LBL_PLAZA_M.Text = dataGridViewMI.Rows[e.RowIndex].Cells[3].Value.ToString();
            lenguage_txt.Text = dataGridViewMI.Rows[e.RowIndex].Cells[4].Value.ToString();
            Reading_txt.Text = dataGridViewMI.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void dataGridViewRelaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDrelaciones.Text = dataGridViewRelaciones.Rows[e.RowIndex].Cells[0].Value.ToString();
            IDnombreR.Text = dataGridViewRelaciones.Rows[e.RowIndex].Cells[1].Value.ToString();
            IDapellidoR.Text = dataGridViewRelaciones.Rows[e.RowIndex].Cells[2].Value.ToString();
            IDplazaR.Text = dataGridViewRelaciones.Rows[e.RowIndex].Cells[3].Value.ToString();
            textR_Jefe.Text = dataGridViewRelaciones.Rows[e.RowIndex].Cells[4].Value.ToString();
            textR_Estudiantes.Text = dataGridViewRelaciones.Rows[e.RowIndex].Cells[5].Value.ToString();
            textR_Padres.Text = dataGridViewRelaciones.Rows[e.RowIndex].Cells[6].Value.ToString();
            textR_Compañeros.Text = dataGridViewRelaciones.Rows[e.RowIndex].Cells[7].Value.ToString();
            textResponsabilidad.Text = dataGridViewRelaciones.Rows[e.RowIndex].Cells[8].Value.ToString();
            textRTotal.Text = dataGridViewRelaciones.Rows[e.RowIndex].Cells[9].Value.ToString();
            textClaseModelo.Text = dataGridViewRelaciones.Rows[e.RowIndex].Cells[10].Value.ToString();
        }

        private void btn_Calificar_Click(object sender, EventArgs e)
        {
            InsertarRelacionesLaborales();
            MostrarPlazaRelacion();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActualizarRelacionesLaborales();
            MostrarPlazaRelacion();
        }

        private void textR_Jefe_TextChanged(object sender, EventArgs e)
        {
            int sum = 0;

            if (int.TryParse(textR_Jefe.Text, out int num1))
                sum += num1;

            if (int.TryParse(textR_Estudiantes.Text, out int num2))
                sum += num2;

            if (int.TryParse(textR_Padres.Text, out int num3))
                sum += num3;

            if (int.TryParse(textR_Compañeros.Text, out int num4))
                sum += num4;

            if (int.TryParse(textResponsabilidad.Text, out int num5))
                sum += num5;

            textRTotal.Text = sum.ToString();
        }

        private void textR_Estudiantes_TextChanged(object sender, EventArgs e)
        {
            int sum = 0;

            if (int.TryParse(textR_Jefe.Text, out int num1))
                sum += num1;

            if (int.TryParse(textR_Estudiantes.Text, out int num2))
                sum += num2;

            if (int.TryParse(textR_Padres.Text, out int num3))
                sum += num3;

            if (int.TryParse(textR_Compañeros.Text, out int num4))
                sum += num4;

            if (int.TryParse(textResponsabilidad.Text, out int num5))
                sum += num5;

            textRTotal.Text = sum.ToString();
        }

        private void textR_Padres_TextChanged(object sender, EventArgs e)
        {
            int sum = 0;

            if (int.TryParse(textR_Jefe.Text, out int num1))
                sum += num1;

            if (int.TryParse(textR_Estudiantes.Text, out int num2))
                sum += num2;

            if (int.TryParse(textR_Padres.Text, out int num3))
                sum += num3;

            if (int.TryParse(textR_Compañeros.Text, out int num4))
                sum += num4;

            if (int.TryParse(textResponsabilidad.Text, out int num5))
                sum += num5;

            textRTotal.Text = sum.ToString();
        }

        private void textR_Compañeros_TextChanged(object sender, EventArgs e)
        {
            int sum = 0;

            if (int.TryParse(textR_Jefe.Text, out int num1))
                sum += num1;

            if (int.TryParse(textR_Estudiantes.Text, out int num2))
                sum += num2;

            if (int.TryParse(textR_Padres.Text, out int num3))
                sum += num3;

            if (int.TryParse(textR_Compañeros.Text, out int num4))
                sum += num4;

            if (int.TryParse(textResponsabilidad.Text, out int num5))
                sum += num5;

            textRTotal.Text = sum.ToString();

        }

        private void textResponsabilidad_TextChanged(object sender, EventArgs e)
        {
            int sum = 0;

            if (int.TryParse(textR_Jefe.Text, out int num1))
                sum += num1;

            if (int.TryParse(textR_Estudiantes.Text, out int num2))
                sum += num2;

            if (int.TryParse(textR_Padres.Text, out int num3))
                sum += num3;

            if (int.TryParse(textR_Compañeros.Text, out int num4))
                sum += num4;

            if (int.TryParse(textResponsabilidad.Text, out int num5))
                sum += num5;

            textRTotal.Text = sum.ToString();

        }

        private void textRTotal_TextChanged(object sender, EventArgs e)
        {
            int sum = 0;

            if (int.TryParse(textR_Jefe.Text, out int num1))
                sum += num1;

            if (int.TryParse(textR_Estudiantes.Text, out int num2))
                sum += num2;

            if (int.TryParse(textR_Padres.Text, out int num3))
                sum += num3;

            if (int.TryParse(textR_Compañeros.Text, out int num4))
                sum += num4;

            if (int.TryParse(textResponsabilidad.Text, out int num5))
                sum += num5;

            textRTotal.Text = sum.ToString();

        }

        private void tabPage5_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void tabPage5_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void tabPage5_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_Refrescar_Click(object sender, EventArgs e)
        {
            MostrarResumen();
        }
    }
}
