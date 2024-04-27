using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //Añadir libreria para usar conexion
using System.Data.SqlClient;

namespace Beehive_School___Recursos_Humanos.Datos
{
    class Conexion
    {
        static private string CadenaConexion = "Server= LAPTOP-C3RL3T0; DataBase=Beehive_RRHH; Integrated Security=true";
        private SqlConnection conexion = new SqlConnection(CadenaConexion);

        public SqlConnection AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            return conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            return conexion;
        }
    }
}
