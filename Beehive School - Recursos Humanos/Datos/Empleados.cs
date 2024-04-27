using System;
using System.Data; // Añadir libreria
using System.Data.SqlClient; // Libreria para base de datos
using Beehive_School___Recursos_Humanos.Presentacion; //Acesso a nuestro archivo presentacion
using System.Windows.Forms; //Poder utilizar los formularios

namespace Beehive_School___Recursos_Humanos.Datos
{
    class Empleados
    {
        private Conexion conexion = new Conexion();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader Leerfilas;

        public DataTable ListarPersona()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "select e.Id, e.Nombre1, e.Nombre2, e.Apellido1, e.Apellido2, e.direccion, e.Fecha_Ingreso, e.DPI, e.Afiliacion_IGSS, e.Telefono1, e.Telefono2, e.Fecha_Nacimiento, d.Nombre_Departamento, p.Nombre_Puesto from empleados e INNER JOIN departamento d ON e.IdDepartamento = d.Id INNER JOIN puesto p ON e.IdPuesto = p.Id\r\n";
            Leerfilas = Comando.ExecuteReader();
            Tabla.Load(Leerfilas);
            Leerfilas.Close();
            conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable ListarBaja2008()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "SELECT t.Id, d.Nombre_Departamento as 'Nivel', p.Nombre_Puesto as 'Puesto', t.Fecha_Ingreso as 'Fecha de Ingreso' , t.Nombre1 as 'Nombre', t.Apellido1 as 'Apellido', cp.Baja, cp.Renuncia, cp.Despido, cp.Ascenso, cp.Cambio \r\nfrom Control_Puestos cp INNER JOIN TrabajadoresPasados2008 t ON cp.Id_Pasados2008 = t.Id INNER JOIN departamento d ON t.Id_Departamento = d.Id INNER JOIN puesto p ON t.Id_Puesto = p.Id\r\n";
            Leerfilas = Comando.ExecuteReader();
            Tabla.Load(Leerfilas);
            Leerfilas.Close();
            conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable ListarBaja2014()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "SELECT t.Id, d.Nombre_Departamento as 'Nivel', p.Nombre_Puesto as 'Puesto', t.Fecha_Ingreso , t.Nombre1, t.Apellido1, cp.Baja, cp.Renuncia, cp.Despido, cp.Ascenso, cp.Cambio \r\nfrom Control_Puestos cp RIGHT JOIN TrabajadoresPasados2014 t ON cp.Id_Pasados2014 = t.Id INNER JOIN departamento d ON t.Id_Departamento = d.Id INNER JOIN puesto p ON t.Id_Puesto = p.Id\r\n";
            Leerfilas = Comando.ExecuteReader();
            Tabla.Load(Leerfilas);
            Leerfilas.Close();
            conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable ListarBaja2015()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "SELECT t.Id, d.Nombre_Departamento as 'Nivel', p.Nombre_Puesto as 'Puesto', t.Fecha_Ingreso , t.Nombre1, t.Apellido1, cp.Baja, cp.Renuncia, cp.Despido, cp.Ascenso, cp.Cambio \r\nfrom Control_Puestos cp RIGHT JOIN TrabajadoresPasados2015 t ON cp.Id_Pasados2015 = t.Id INNER JOIN departamento d ON t.Id_Departamento = d.Id INNER JOIN puesto p ON t.Id_Puesto = p.Id\r\n";
            Leerfilas = Comando.ExecuteReader();
            Tabla.Load(Leerfilas);
            Leerfilas.Close();
            conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable ListarBaja2016()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "SELECT t.Id, d.Nombre_Departamento as 'Nivel', p.Nombre_Puesto as 'Puesto', t.Fecha_Ingreso , t.Nombre1, t.Apellido1, cp.Baja, cp.Renuncia, cp.Despido, cp.Ascenso, cp.Cambio \r\nfrom Control_Puestos cp RIGHT JOIN TrabajadoresPasados2016 t ON cp.Id_Pasados2016 = t.Id INNER JOIN departamento d ON t.Id_Departamento = d.Id INNER JOIN puesto p ON t.Id_Puesto = p.Id\r\n";
            Leerfilas = Comando.ExecuteReader();
            Tabla.Load(Leerfilas);
            Leerfilas.Close();
            conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable ListarBaja2017()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "SELECT t.Id, d.Nombre_Departamento as 'Nivel', p.Nombre_Puesto as 'Puesto', t.Fecha_Ingreso as 'Fecha de Ingreso', t.Nombre1 as 'Nombre', t.Apellido1 as 'Apellido', cp.Baja, cp.Renuncia, cp.Despido, cp.Ascenso, cp.Cambio \r\nfrom Control_Puestos cp RIGHT JOIN TrabajadoresPasados2017 t ON cp.Id_Pasados2017 = t.Id INNER JOIN departamento d ON t.Id_Departamento = d.Id INNER JOIN puesto p ON t.Id_Puesto = p.Id\r\n";
            Leerfilas = Comando.ExecuteReader();
            Tabla.Load(Leerfilas);
            Leerfilas.Close();
            conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable ListarBaja2018()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "SELECT t.Id, d.Nombre_Departamento as 'Nivel', p.Nombre_Puesto as 'Puesto', t.Fecha_Ingreso as 'Fecha de Ingreso', t.Nombre1 as 'Nombre', t.Apellido1 as 'Apellido', cp.Baja, cp.Renuncia, cp.Despido, cp.Ascenso, cp.Cambio \r\nfrom Control_Puestos cp RIGHT JOIN TrabajadoresPasados2018 t ON cp.Id_Pasados2018 = t.Id INNER JOIN departamento d ON t.Id_Departamento = d.Id INNER JOIN puesto p ON t.Id_Puesto = p.Id\r\n";
            Leerfilas = Comando.ExecuteReader();
            Tabla.Load(Leerfilas);
            Leerfilas.Close();
            conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable ListarBaja2019()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "SELECT t.Id, d.Nombre_Departamento as 'Nivel', p.Nombre_Puesto as 'Puesto', t.Fecha_Ingreso as 'Fecha de Ingreso', t.Nombre1 as 'Nombre', t.Apellido1 as 'Apellido', cp.Baja, cp.Renuncia, cp.Despido, cp.Ascenso, cp.Cambio \r\nfrom Control_Puestos cp RIGHT JOIN TrabajadoresPasados2019 t ON cp.Id_Pasados2019 = t.Id INNER JOIN departamento d ON t.Id_Departamento = d.Id INNER JOIN puesto p ON t.Id_Puesto = p.Id\r\n";
            Leerfilas = Comando.ExecuteReader();
            Tabla.Load(Leerfilas);
            Leerfilas.Close();
            conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable ListarBaja2020()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "SELECT t.Id, d.Nombre_Departamento as 'Nivel', p.Nombre_Puesto as 'Puesto', t.Fecha_Ingreso as 'Fecha de Ingreso', t.Nombre1 as 'Nombre', t.Apellido1 as 'Apellido', cp.Baja, cp.Renuncia, cp.Despido, cp.Ascenso, cp.Cambio \r\nfrom Control_Puestos cp RIGHT JOIN TrabajadoresPasados2020 t ON cp.Id_Pasados2020 = t.Id INNER JOIN departamento d ON t.Id_Departamento = d.Id INNER JOIN puesto p ON t.Id_Puesto = p.Id\r\n";
            Leerfilas = Comando.ExecuteReader();
            Tabla.Load(Leerfilas);
            Leerfilas.Close();
            conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable ListarBaja2021()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "SELECT t.Id, d.Nombre_Departamento as 'Nivel', p.Nombre_Puesto as 'Puesto', t.Fecha_Ingreso as 'Fecha de Ingreso', t.Nombre1 as 'Nombre', t.Apellido1 as 'Apellido', cp.Baja, cp.Renuncia, cp.Despido, cp.Ascenso, cp.Cambio \r\nfrom Control_Puestos cp RIGHT JOIN TrabajadoresPasados2021 t ON cp.Id_Pasados2021 = t.Id INNER JOIN departamento d ON t.Id_Departamento = d.Id INNER JOIN puesto p ON t.Id_Puesto = p.Id\r\n";
            Leerfilas = Comando.ExecuteReader();
            Tabla.Load(Leerfilas);
            Leerfilas.Close();
            conexion.CerrarConexion();
            return Tabla;
        }

        public void InsertarFechaIngreso_2008(string ingreso, int ID)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "UPDATE TrabajadoresPasados2008 SET Fecha_Ingreso='" + ingreso + "' WHERE Id= " + ID + "";
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Comando.Connection = conexion.CerrarConexion();

        }
        public void InsertarFechaBaja_2008(string baja, int ID)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "UPDATE Control_Puestos SET Baja='" + baja + "' WHERE Id_Pasados2008= " + ID + "";
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Comando.Connection = conexion.CerrarConexion();
        }
        public void ActualizarEstado2008(int renuncia, int despido, int ascenso, int cambio, int ID)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "UPDATE Control_Puestos SET Renuncia='" + renuncia + "', Despido='" + despido + "', Ascenso='" + ascenso + "', Cambio='" + cambio + "'  WHERE Id_Pasados2008= " + ID + "";
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Comando.Connection = conexion.CerrarConexion();
        }
        public void InsertarFechaIngreso_2014(string ingreso, int ID)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "UPDATE TrabajadoresPasados2014 SET Fecha_Ingreso='" + ingreso + "' WHERE Id= " + ID + "";
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Comando.Connection = conexion.CerrarConexion();
        }
        public void InsertarFechaBaja_2014(string baja, int ID)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "UPDATE Control_Puestos SET Baja='" + baja + "' WHERE Id_Pasados2014= " + ID + " as 'SI'";
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Comando.Connection = conexion.CerrarConexion();
        }
        public void ActualizarEstado2014(int renuncia, int despido, int ascenso, int cambio, int ID)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "UPDATE Control_Puestos SET Renuncia='" + renuncia + "', Despido='" + despido + "', Ascenso='" + ascenso + "', Cambio='" + cambio + "'  WHERE Id_Pasados2014= " + ID + "";
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
        public void InsertarFechaIngreso_2015(string ingreso, int ID)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "UPDATE TrabajadoresPasados2015 SET Fecha_Ingreso='" + ingreso + "' WHERE Id= " + ID + "";
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Comando.Connection = conexion.CerrarConexion();
        }
        public void InsertarFechaBaja_2015(string baja, int ID)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "UPDATE Control_Puestos SET Baja='" + baja + "' WHERE Id_Pasados2015= " + ID + "";
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Comando.Connection = conexion.CerrarConexion();
        }
        public void ActualizarEstado2015(int renuncia, int despido, int ascenso, int cambio, int ID)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "UPDATE Control_Puestos SET Renuncia='" + renuncia + "', Despido='" + despido + "', Ascenso='" + ascenso + "', Cambio='" + cambio + "'  WHERE Id_Pasados2015= " + ID + "";
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
        public void InsertarFechaIngreso_2016(string ingreso, int ID)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "UPDATE TrabajadoresPasados2016 SET Fecha_Ingreso='" + ingreso + "' WHERE Id= " + ID + "";
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Comando.Connection = conexion.CerrarConexion();
        }
        public void InsertarFechaBaja_2016(string baja, int ID)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "UPDATE Control_Puestos SET Baja='" + baja + "' WHERE Id_Pasados2016= " + ID + "";
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Comando.Connection = conexion.CerrarConexion();
        }
        public void ActualizarEstado2016(int renuncia, int despido, int ascenso, int cambio, int ID)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "UPDATE Control_Puestos SET Renuncia='" + renuncia + "', Despido='" + despido + "', Ascenso='" + ascenso + "', Cambio='" + cambio + "'  WHERE Id_Pasados2016= " + ID + "";
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
        public void InsertarFechaIngreso_2017(string ingreso, int ID)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "UPDATE TrabajadoresPasados2017 SET Fecha_Ingreso='" + ingreso + "' WHERE Id= " + ID + "";
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Comando.Connection = conexion.CerrarConexion();
        }
        public void InsertarFechaBaja_2017(string baja, int ID)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "UPDATE Control_Puestos SET Baja='" + baja + "' WHERE Id_Pasados2017= " + ID + "";
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Comando.Connection = conexion.CerrarConexion();
        }
        public void ActualizarEstado2017(int renuncia, int despido, int ascenso, int cambio, int ID)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "UPDATE Control_Puestos SET Renuncia='" + renuncia + "', Despido='" + despido + "', Ascenso='" + ascenso + "', Cambio='" + cambio + "'  WHERE Id_Pasados2018= " + ID + "";
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
        public void InsertarFechaIngreso_2018(string ingreso, int ID)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "UPDATE TrabajadoresPasados2018 SET Fecha_Ingreso='" + ingreso + "' WHERE Id= " + ID + "";
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Comando.Connection = conexion.CerrarConexion();
        }
        public void InsertarFechaBaja_2018(string baja, int ID)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "UPDATE Control_Puestos SET Baja='" + baja + "' WHERE Id_Pasados2018= " + ID + "";
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Comando.Connection = conexion.CerrarConexion();
        }
        public void ActualizarEstado2018(int renuncia, int despido, int ascenso, int cambio, int ID)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "UPDATE Control_Puestos SET Renuncia='" + renuncia + "', Despido='" + despido + "', Ascenso='" + ascenso + "', Cambio='" + cambio + "'  WHERE Id_Pasados2018= " + ID + "";
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
        public void InsertarFechaIngreso_2019(string ingreso, int ID)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "UPDATE TrabajadoresPasados2019 SET Fecha_Ingreso='" + ingreso + "' WHERE Id= " + ID + "";
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Comando.Connection = conexion.CerrarConexion();
        }
        public void InsertarFechaBaja_2019(string baja, int ID)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "UPDATE Control_Puestos SET Baja='" + baja + "' WHERE Id_Pasados2019= " + ID + "";
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Comando.Connection = conexion.CerrarConexion();
        }
        public void ActualizarEstado2019(int renuncia, int despido, int ascenso, int cambio, int ID)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "UPDATE Control_Puestos SET Renuncia='" + renuncia + "', Despido='" + despido + "', Ascenso='" + ascenso + "', Cambio='" + cambio + "'  WHERE Id_Pasados2019= " + ID + "";
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
        public void InsertarFechaIngreso_2020(string ingreso, int ID)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "UPDATE TrabajadoresPasados2020 SET Fecha_Ingreso='" + ingreso + "' WHERE Id= " + ID + "";
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Comando.Connection = conexion.CerrarConexion();
        }
        public void InsertarFechaBaja_2020(string baja, int ID)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "UPDATE Control_Puestos SET Baja='" + baja + "' WHERE Id_Pasados2020= " + ID + "";
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Comando.Connection = conexion.CerrarConexion();
        }
        public void ActualizarEstado2020(int renuncia, int despido, int ascenso, int cambio, int ID)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "UPDATE Control_Puestos SET Renuncia='" + renuncia + "', Despido='" + despido + "', Ascenso='" + ascenso + "', Cambio='" + cambio + "'  WHERE Id_Pasados2020= " + ID + "";
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
        public void InsertarFechaIngreso_2021(string ingreso, int ID)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "UPDATE TrabajadoresPasados2021 SET Fecha_Ingreso='" + ingreso + "' WHERE Id= " + ID + "";
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Comando.Connection = conexion.CerrarConexion();
        }
        public void InsertarFechaBaja_2021(string baja, int ID)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "UPDATE Control_Puestos SET Baja='" + baja + "' WHERE Id_Pasados2021= " + ID + "";
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Comando.Connection = conexion.CerrarConexion();
        }
        public void ActualizarEstado2021(int renuncia, int despido, int ascenso, int cambio, int ID)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "UPDATE Control_Puestos SET Renuncia='" + renuncia + "', Despido='" + despido + "', Ascenso='" + ascenso + "', Cambio='" + cambio + "'  WHERE Id_Pasados2021= " + ID + "";
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
        public void InsertarFechaIngreso_2022(string ingreso, int ID)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "UPDATE TrabajadoresPasados2022 SET Fecha_Ingreso='" + ingreso + "' WHERE Id= " + ID + "";
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Comando.Connection = conexion.CerrarConexion();
        }
        public void InsertarFechaBaja_2022(string baja, int ID)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "UPDATE Control_Puestos SET Baja='" + baja + "' WHERE Id_Pasados2022= " + ID + "";
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Comando.Connection = conexion.CerrarConexion();
        }
        public void ActualizarEstado2022(int renuncia, int despido, int ascenso, int cambio, int ID)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "UPDATE Control_Puestos SET Renuncia='" + renuncia + "', Despido='" + despido + "', Ascenso='" + ascenso + "', Cambio='" + cambio + "'  WHERE Id_Pasados2022= " + ID + "";
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
        public void Insertar(string Nombre1,string Nombre2, string Apellido1, string Apellido2, string direccion,
   string Fecha_Ingreso , string DPI, string IGSS, int Telefono1, int Telefono2, string Fecha_Nac, string departamento, string puesto)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "insert into empleados  (e.Nombre1, e.Nombre2, e.Apellido1, e.Apellido2, e.direccion, e.Fecha_Ingreso, e.DPI, e.Afiliacion_IGSS, e.Telefono1, e.Telefono2, e.Fecha_Nacimiento, d.IdDepartamento, p.IdPuesto)" +
                " values ('" + Nombre1 + "','" + Nombre2 + "','" + Apellido1 + "','" + Apellido2 + "','" + direccion + "','" + Fecha_Ingreso + "','" + DPI + "','" + IGSS + "','" + Telefono1 + "','" + Telefono2 + "','" + Fecha_Nac + "', '" + departamento + "', '" + puesto + "')";
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Comando.Connection = conexion.CerrarConexion();
        }
        public void InsertarDep(string departamento)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "insert into departamento (Nombre_Departamento)" +
                " values ('" + departamento + "')";
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Comando.Connection = conexion.CerrarConexion();
        }
        public void InsertarPuest(string puesto)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "insert into puesto (Nombre_Puesto)" +
                " values ('" + puesto + "')";
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Comando.Connection = conexion.CerrarConexion();
        }

        public void Actualizar(int Id, string Nombre1, string Nombre2, string Apellido1, string Apellido2,
           string Fecha_Ingreso, string DPI, string IGSS, string direccion, int Telefono1, int Telefono2, string Fecha_Nac, string departamento, string puesto)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "UPDATE empleados SET Nombre1='" + Nombre1 + "', Nombre2='" + Nombre2 + "',Apellido1='" + Apellido1 + "', Apellido2='" + Apellido2 + "', Fecha_Ingreso='" + Fecha_Ingreso + "', DPI='" + DPI + "', Afiliacion_IGSS='" + IGSS + "', direccion='" + direccion + "', Telefono1='" + Telefono1 + "', Telefono2='" + Telefono2 + "', Fecha_Nacimiento='" + Fecha_Nac + "', IdDepartamento='" + departamento +"', IdPuesto='" + puesto + "' WHERE Id = " + Id + "";
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Comando.Connection.Close();
        }

        public void Eliminar(int Id)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "Delete from empleados WHERE Id = " + Id + " ";
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Comando.Connection = conexion.CerrarConexion();
        }
        public void Inicio_Admin(string NomUsuario, string contrasena)
        {
            try
            {
                Comando.Connection = conexion.AbrirConexion();
                Comando.CommandText = "Select * from Usuario WHERE contrasena = '" + contrasena + "' and Nombre_Usuario = '" + NomUsuario + "' ";
                int a = Convert.ToInt32(Comando.ExecuteScalar()); //mira cuantos valores retorna
                Comando.Parameters.Clear();
                if (a == 0)
                {
                    MessageBox.Show("Usuario o contraseña invalidos");

                }
                else
                {
                    Inicio inicio = new Inicio();
                    inicio.Show();

                }
            }
            catch
            {

            }
        }
        public void Inicio_Dir(string NomUsuario, string contrasena)
        {
            try
            {
                Comando.Connection = conexion.AbrirConexion();
                Comando.CommandText = "Select * from Usuario_Master WHERE contrasena = '" + contrasena + "' and Nombre_Master = '" + NomUsuario + "' ";
                int a = Convert.ToInt32(Comando.ExecuteScalar()); //mira cuantos valores retorna
                Comando.Parameters.Clear();
                if (a == 0)
                {
                    MessageBox.Show("Usuario o contraseña invalidos");
                    Login login = new Login();
                    login.Show();

                }
                else
                {
                    CreacionUsuarios inicio = new CreacionUsuarios();
                    inicio.Show();

                }
            }
            catch
            {

            }
        }
    }
}
