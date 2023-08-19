using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class N_Inventario
    {
        private D_Inventario datos;
        private List<E_Producto> inventario;
        public N_Inventario()
        {
            datos = new D_Inventario();
            inventario = new List<E_Producto>();
        }

        public List<E_Producto> ObtenerProductos()
        {
            D_Inventario inventario = new D_Inventario();
            return inventario.ObtenerProductos();
        }
        public List<E_Producto> ObtenerProductosUsuario()
        {
            D_Inventario inventario = new D_Inventario();
            return inventario.ObtenerProductosUsuario();
        }
        public List<E_Comprado> ObtenerComprados()
        {
            D_Inventario inventario = new D_Inventario();
            return inventario.ObtenerComprados();
        }
        public void AgregarProducto(E_Producto e_Producto)
        {
            D_Inventario inventario = new D_Inventario();
            inventario.AgregarProducto(e_Producto);
        }
        public void ModificarProducto(E_Producto e_Producto)
        {
            D_Inventario inventario = new D_Inventario();
            inventario.ModificarProducto(e_Producto);
        }
        public void EliminarProducto(int id)
        {
            D_Inventario inventario = new D_Inventario();
            inventario.EliminarProducto(id);
        }
        public DataTable BuscarPorNombre(string nombre)
        {
            D_Inventario inventario = new D_Inventario();
            return inventario.BuscarPorNombre(nombre);
        }
        public bool VerificarCredenciales(string usuario, string contrasena)
        {
            return datos.VerificarCredenciales(usuario, contrasena);
        }
        public void ComprarProducto(string nombre, int stock)
        {
            D_Inventario inventario = new D_Inventario();
            inventario.ActualizarStock(nombre, stock);
        }
        public void RegistrarCompra(string nombre, int stock)
        {
            D_Inventario inventario = new D_Inventario();
            inventario.RegistrarCompra(nombre, stock);
        }
        public void RegistrarUsuario(E_Usuario e_Usuario)
        {
            D_Inventario inventario = new D_Inventario();
            inventario.RegistrarUsuario(e_Usuario);
        }
        
    }
}
