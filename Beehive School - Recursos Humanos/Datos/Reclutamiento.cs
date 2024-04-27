using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; // Añadir libreria
using System.Data.SqlClient; // Libreria para base de datos
using Beehive_School___Recursos_Humanos.Presentacion; //Acesso a nuestro archivo presentacion
using System.Windows.Forms; //Poder utilizar los formularios
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Beehive_School___Recursos_Humanos.Datos
{
    class Reclutamiento
    {
        private Conexion conexion = new Conexion();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader Leerfilas;

        public DataTable ListarPlaza()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "select r.Id, r.Nombre, r.Apellido, r.Telefono, r.Fuente, p.NombrePlaza\r\nfrom Reclutamiento r INNER JOIN Plaza p ON r.IdPlaza = p.Id";
            Leerfilas = Comando.ExecuteReader();
            Tabla.Load(Leerfilas);
            Leerfilas.Close();
            conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable ListarPlaza2()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "select r.Id, r.Nombre, r.Apellido, p.NombrePlaza as 'Nombre de la Plaza', ei.Fecha_Entrevista_RHH as 'Fecha de la Entrevista', ei.Exp_Laboral as'Experiencia Laboral',ei.Área_Académica as 'Área Académica',ei.Fluidez_Verbal_Ingles as 'Fluidez Verbal en Ingles',ei.Desenvolvimiento_Ingles as 'Desenvolvimiento en Ingles',ei.Conocimiento_del_Colegio as 'Conocimiento del Colegio',ei.Condiciones_Laborales as 'Condiciones Laborales', ei.Total \r\nfrom Reclutamiento r LEFT JOIN Plaza p ON r.IdPlaza = p.Id LEFT JOIN Entrevista_Ingles ei ON r.Id = ei.Id";
            Leerfilas = Comando.ExecuteReader();
            Tabla.Load(Leerfilas);
            Leerfilas.Close();
            conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable ListarJI()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "select r.Id, r.Nombre, r.Apellido, p.NombrePlaza as 'Nombre de la Plaza', ji.Entrevista_JI as 'Fecha de la Entrevista', ji.Total from Reclutamiento r LEFT JOIN Plaza p ON r.IdPlaza = p.Id LEFT JOIN Entrevista_JI ji ON r.Id = ji.Id\r\n";
            Leerfilas = Comando.ExecuteReader();
            Tabla.Load(Leerfilas);
            Leerfilas.Close();
            conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable ListarMI()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "select r.Id,r.Nombre,r.Apellido,p.NombrePlaza as 'Nombre de la Plaza', mi.MAP_Lenguage as 'MAP de Lenguaje',mi.MAP_Reading as 'MAP de Reading'\r\nfrom Reclutamiento r LEFT JOIN Plaza p ON r.IdPlaza = p.Id LEFT JOIN Map_I  mi ON r.Id = mi.Id\r\n\r\n";
            Leerfilas = Comando.ExecuteReader();
            Tabla.Load(Leerfilas);
            Leerfilas.Close();
            conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable ListarResumen()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "select  r.Id, r.Nombre, r.Apellido, r.Telefono, r.Fuente, p.NombrePlaza as'Nombre de la Plaza', ei.Fecha_Entrevista_RHH as 'Fecha de la Entrevista', ei.Exp_Laboral as'Experiencia Laboral',ei.Área_Académica as 'Área Académica',ei.Fluidez_Verbal_Ingles as 'Fluidez Verban en Ingles',ei.Desenvolvimiento_Ingles as 'Desenvolvimiento en Ingles',ei.Conocimiento_del_Colegio as 'Conocimiento del Colegio',ei.Condiciones_Laborales as 'Condiciones Laborales',ei.Total as 'Total #1',eji.Entrevista_JI as 'Entrevista con Jefe Interno',eji.Total as 'Total #2',me.MAP_Lenguage as 'Map de Language',me.Map_Reading as 'Map de Reading',re.R_Con_Jefe_Inmediato as 'Relación con Jefe Inmediato',re.R_Con_Estudiantes as 'Relación con Estudiantes',re.R_Con_Padres_De_Familia as 'Relación con Padres de Familia',re.R_Con_Compañeros as 'Relación con Compañeros',re.Responsabilidad, re.Total as 'Total #3',re.Clase_Modelo as 'Clase Modelo'\r\nfrom Reclutamiento r INNER JOIN Plaza p ON r.IdPlaza = p.Id INNER JOIN Entrevista_Ingles ei ON r.Id = ei.Id INNER JOIN Entrevista_JI eji ON r.Id = eji.Id INNER JOIN Map_I me ON r.Id = me.Id INNER JOIN Relaciones re ON r.Id = re.Id";
            Leerfilas = Comando.ExecuteReader();
            Tabla.Load(Leerfilas);
            Leerfilas.Close();
            conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable ListarRelaciones()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "select r.Id,r.Nombre,r.Apellido,p.NombrePlaza as 'Nombre de la Plaza', rc.R_Con_Jefe_Inmediato as 'Relación con Jefe Inmediato', rc.R_Con_Estudiantes as 'Relación con Estudiantes', rc.R_Con_Padres_De_Familia as 'Relación con Padres de Familia', rc.R_Con_Compañeros as 'Relación con Compañeros', rc.Responsabilidad, rc.Total, rc.Clase_Modelo as 'Clase Modelo'\r\nfrom Reclutamiento r LEFT JOIN Plaza p ON r.IdPlaza = p.Id LEFT JOIN Relaciones rc ON r.Id = rc.Id";
            Leerfilas = Comando.ExecuteReader();
            Tabla.Load(Leerfilas);
            Leerfilas.Close();
            conexion.CerrarConexion();
            return Tabla;
        }

        public void InsertarPlaza(string Nombre, string Apellido, int Telefono, string Fuente, string plaza)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "insert into Reclutamiento  (r.Nombre, r.Apellido, r.Telefono, r.Fuente, r.IdPlaza)" +
                " values ('" + Nombre + "','" + Apellido + "','" + Telefono + "','" + Fuente + "', '" + plaza + "')";
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Comando.Connection = conexion.CerrarConexion();
        }
        public void Eliminar(int Id)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "Delete from Entrevista_Ingles WHERE Id_Reclutamiento = " + Id + " ";
            Comando.ExecuteNonQuery();
            Comando.CommandText = "Delete from Entrevista_JI WHERE Id_Reclutamiento = " + Id + " ";
            Comando.ExecuteNonQuery();
            Comando.CommandText = "Delete from Entrevista1 WHERE Id_Reclutamiento = " + Id + " ";
            Comando.ExecuteNonQuery();
            Comando.CommandText = "Delete from MAP WHERE Id_Reclutamiento = " + Id + " ";
            Comando.ExecuteNonQuery();
            Comando.CommandText = "Delete from Map_I WHERE Id_Reclutamiento = " + Id + " ";
            Comando.ExecuteNonQuery();
            Comando.CommandText = "Delete from Relaciones WHERE Id_Reclutamiento = " + Id + " ";
            Comando.ExecuteNonQuery();
            Comando.CommandText = "Delete from Reclutamiento WHERE Id = " + Id + " ";
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Comando.Connection = conexion.CerrarConexion();
        }
        public void Actualizar(int Id, string Nombre, string Apellido, int telefono, string fuente, string plaza)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "UPDATE Reclutamiento SET Nombre='" + Nombre + "', Apellido='" + Apellido + "', Telefono='" + telefono + "', Fuente='" + fuente + "', IdPlaza='" + plaza + "' WHERE Id = " + Id + "";
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Comando.Connection.Close();
        }
        public void ActualizarPlaza(int Id, string fecha, int Exp, int Academica, int Fluidez, int desenvolvimiento, int conocimiento, int condiciones, int total)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "UPDATE Entrevista_Ingles SET Fecha_Entrevista_RHH= '" + fecha + "', Exp_Laboral= '" + Exp + "', Área_Académica= '" + Academica + "', Fluidez_Verbal_Ingles= '" + Fluidez + "', Desenvolvimiento_Ingles= '" + desenvolvimiento + "', Conocimiento_del_Colegio= '" + conocimiento + "', Condiciones_Laborales= '" + condiciones + "', Total= '" + total + "' WHERE Id = " + Id + "";
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Comando.Connection.Close();
        }
        public void ActualizarJI(int Id, int total)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "UPDATE Entrevista_JI SET Total= '" + total + "' WHERE Id = " + Id + "";
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Comando.Connection.Close();
        }

        public void ActualizarMI(int Id, int M_Lenguaje, int M_Reading)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "UPDATE Map_I SET Map_Lenguage= '" + M_Lenguaje + "', Map_Reading= '" + M_Reading + "'WHERE Id = " + Id + "";
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Comando.Connection.Close();

        }
        public void InsertarFechaJI(string fecha, int Id)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "insert into Entrevista_JI  (Entrevista_JI, Id_Reclutamiento)" +
                " values ('" + fecha + "', '" + Id + "')";
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Comando.Connection = conexion.CerrarConexion();
        }
        public void PuntajesMap(int resultado1, int resultado2, int Id)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "insert into Map_I(MAP_Lenguage,MAP_Reading,Id_Reclutamiento)" + "values('" + resultado1 + "','" + resultado2 + "','" + Id + "')";
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Comando.Connection = conexion.CerrarConexion();
        }
        public void RelacionesLaborales(int R_Jefe, int R_Estudiantes, int R_Padres, int R_Compañeros, int Responsabilidad, int total, int clase_modelo, int Id)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "insert into Relaciones (R_Con_Jefe_Inmediato, R_Con_Estudiantes, R_Con_Padres_De_Familia, R_Con_Compañeros, Responsabilidad, Total, Clase_Modelo, Id_Reclutamiento)" + "values('" + R_Jefe + "','" + R_Estudiantes + "','" + R_Padres + "', '" + R_Compañeros + "', '" + Responsabilidad + "', '" + total + "', '" + clase_modelo + "', '" + Id + "')";
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Comando.Connection = conexion.CerrarConexion();
        }
        public void ActualizarRelaciones(int Id, int R_Jefe, int R_Estudiantes, int R_Padres, int R_Compañeros, int Responsabilidad, int total, int clase_modelo)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "UPDATE Relaciones SET R_Con_Jefe_Inmediato='" + R_Jefe + "', R_Con_Estudiantes='" + R_Estudiantes + "', R_Con_Padres_De_Familia='" + R_Padres + "', R_Con_Compañeros='" + R_Compañeros + "', Responsabilidad='" + Responsabilidad + "', Total='" + total + "', Clase_Modelo ='" + clase_modelo + "' WHERE Id = " + Id + "";
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Comando.Connection = conexion.CerrarConexion();
        }
    }
}
