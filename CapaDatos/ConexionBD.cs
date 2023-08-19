using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class ConexionBD
    {
        private string cadenaConexion = "Server=LAPTOP-I6UA3QM8;Database=DB_Inventario;Integrated Security=yes";
        private SqlConnection conexion;

        private static ConexionBD instancia = null;

        private ConexionBD()
        {
            conexion = new SqlConnection(cadenaConexion);
        }

        public static ConexionBD ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new ConexionBD();
            }
            return instancia;
        }

        public SqlConnection AbrirConexion()
        {
            try
            {
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la conexion: " + ex.Message); 
                return null;
            }
        }

        public void CerrarConexion()
        {
            try
            {
                conexion.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cerrar la conexion: " + ex.Message);

            }
        }
    }
}
