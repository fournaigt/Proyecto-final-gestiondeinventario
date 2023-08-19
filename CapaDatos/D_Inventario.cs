using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class D_Inventario
    {
        private ConexionBD conexion = null;

        public D_Inventario()
        {
            conexion = ConexionBD.ObtenerInstancia();
        }

        public List<E_Producto> ObtenerProductos()
        {
            List<E_Producto> producto = new List<E_Producto>();

            using (SqlConnection conn = conexion.AbrirConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_ObtenerProductos", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    E_Producto e_producto = new E_Producto();
                    e_producto.Id = reader.GetInt32(0);
                    e_producto.Nombre = reader.GetString(1);
                    e_producto.Precio = reader.GetString(2);
                    e_producto.Stock = reader.GetInt32(3);

                    producto.Add(e_producto);
                }

                reader.Close();
            }

            conexion.CerrarConexion();

            return producto;

        }
        public List<E_Producto> ObtenerProductosUsuario()
        {
            List<E_Producto> producto = new List<E_Producto>();
            string connectionString = "Server=LAPTOP-I6UA3QM8;Database=DB_Inventario;Integrated Security=yes";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_ObtenerProductos", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    E_Producto e_producto = new E_Producto();
                    e_producto.Id = reader.GetInt32(0);
                    e_producto.Nombre = reader.GetString(1);
                    e_producto.Precio = reader.GetString(2);
                    e_producto.Stock = reader.GetInt32(3);

                    producto.Add(e_producto);
                }

                reader.Close();
                conn.Close();
            }

            return producto;
        }
        public void AgregarProducto(E_Producto e_Producto)
        {
            string connectionString = "Server=LAPTOP-I6UA3QM8;Database=DB_Inventario;Integrated Security=yes";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_AgregarProducto", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", e_Producto.Nombre);
                cmd.Parameters.AddWithValue("@precio", e_Producto.Precio);
                cmd.Parameters.AddWithValue("@stock", e_Producto.Stock);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void ModificarProducto(E_Producto e_Producto)
        {
            string connectionString = "Server=LAPTOP-I6UA3QM8;Database=DB_Inventario;Integrated Security=yes";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_ModificarProducto", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombre", e_Producto.Nombre);
                cmd.Parameters.AddWithValue("@precio", e_Producto.Precio);
                cmd.Parameters.AddWithValue("@stock", e_Producto.Stock);
                cmd.Parameters.AddWithValue("@id", e_Producto.Id);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        public void EliminarProducto(int id)
        {
            string connectionString = "Server=LAPTOP-I6UA3QM8;Database=DB_Inventario;Integrated Security=yes";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_EliminarProducto", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            
        }

        public bool VerificarCredenciales(string usuario, string contrasena)
        {
            bool esValido = false;
            string connectionString = "Server=LAPTOP-I6UA3QM8;Database=DB_Inventario;Integrated Security=yes";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SP_VerificarCredenciales", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@contrasena", contrasena);

                    esValido = (bool)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    // Handle the exception here
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    // Close the connection
                    conn.Close();
                }
            }

            return esValido;
        }
        public DataTable BuscarPorNombre(string nombre)
        {
            string connectionString = "Server=LAPTOP-I6UA3QM8;Database=DB_Inventario;Integrated Security=yes";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_BuscarPorNombre", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", nombre);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
        }

        public void ActualizarStock(string nombre, int stock)
        {
            string connectionString = "Server=LAPTOP-I6UA3QM8;Database=DB_Inventario;Integrated Security=yes";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_ActualizarStock", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Stock", stock);
                cmd.ExecuteNonQuery();
            }
        }

        public void RegistrarCompra(string nombre, int stock)
        {
            string connectionString = "Server=LAPTOP-I6UA3QM8;Database=DB_Inventario;Integrated Security=yes";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_RegistrarCompra", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@stock", stock);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public List<E_Comprado> ObtenerComprados()
        {
            List<E_Comprado> comprado = new List<E_Comprado>();
            string connectionString = "Server=LAPTOP-I6UA3QM8;Database=DB_Inventario;Integrated Security=yes";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_ObtenerComprados", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    E_Comprado e_comprado = new E_Comprado();
                    e_comprado.Id = reader.GetInt32(0);
                    e_comprado.Nombre = reader.GetString(1);
                    e_comprado.Stock = reader.GetInt32(2);

                    comprado.Add(e_comprado);
                }

                reader.Close();
                conn.Close();
            }

            return comprado;
        }
        public void RegistrarUsuario(E_Usuario e_usuario)
        {
            string connectionString = "Server=LAPTOP-I6UA3QM8;Database=DB_Inventario;Integrated Security=yes";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_RegistrarUsuario", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", e_usuario.Usuario);
                cmd.Parameters.AddWithValue("@contrasena", e_usuario.Contrasena);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
