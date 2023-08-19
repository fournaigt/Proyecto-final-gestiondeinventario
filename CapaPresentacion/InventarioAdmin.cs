using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class InventarioAdmin : Form
    {
        public InventarioAdmin()
        {
            InitializeComponent();
        }

        private void DtaGridAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InventarioAdmin_Load(object sender, EventArgs e)
        {
            N_Inventario negocio = new N_Inventario();
            List<E_Producto> productos = negocio.ObtenerProductos();

            DtaGridAdmin.DataSource = productos;
            DtaGridAdmin.Columns["Id"].HeaderText = "ID";
            DtaGridAdmin.Columns["Nombre"].HeaderText = "Nombre del Producto";
            DtaGridAdmin.Columns["Precio"].HeaderText = "Precio";
            DtaGridAdmin.Columns["Stock"].HeaderText = "Stock Disponible";
            DtaGridAdmin.ReadOnly = true;
            DtaGridAdmin.AllowUserToAddRows = false;
            DtaGridAdmin.AllowUserToDeleteRows = false;
            DtaGridAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DtaGridAdmin.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void txtCantidad_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            E_Producto producto = new E_Producto();
            producto.Nombre = txtNombre.Text;
            producto.Precio = txtPrecio.Text;
            producto.Stock = int.Parse(txtStock.Text);

            N_Inventario inventario = new N_Inventario();
            inventario.AgregarProducto(producto);

            MessageBox.Show("Producto agregado correctamente.");
        }

        private void btnModificarAdmin_Click(object sender, EventArgs e)
        {
            E_Producto producto = new E_Producto();
            producto.Id = Convert.ToInt32(txtId.Text);
            producto.Nombre = txtNombre.Text;
            producto.Precio = txtPrecio.Text;
            producto.Stock = int.Parse(txtStock.Text);

            N_Inventario inventario = new N_Inventario();
            inventario.ModificarProducto(producto);

            MessageBox.Show("Producto modificado correctamente");
        }

        private void btnEliminarAdmin_Click(object sender, EventArgs e)
        {
            N_Inventario inventario = new N_Inventario();
            int id = int.Parse(txtId.Text);
            inventario.EliminarProducto(id);
            MessageBox.Show("Producto eliminado correctamente.");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar frmBuscar = new Buscar();
            frmBuscar.ShowDialog();
        }

        private void btnCSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frmPrincipal = new Login();
            frmPrincipal.ShowDialog();
            this.Close();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            N_Inventario negocio = new N_Inventario();
            List<E_Producto> productos = negocio.ObtenerProductosUsuario();

            DtaGridAdmin.DataSource = productos;
            DtaGridAdmin.Columns["Id"].HeaderText = "ID";
            DtaGridAdmin.Columns["Nombre"].HeaderText = "Nombre del Producto";
            DtaGridAdmin.Columns["Precio"].HeaderText = "Precio";
            DtaGridAdmin.Columns["Stock"].HeaderText = "Stock Disponible";
            DtaGridAdmin.ReadOnly = true;
            DtaGridAdmin.AllowUserToAddRows = false;
            DtaGridAdmin.AllowUserToDeleteRows = false;
            DtaGridAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DtaGridAdmin.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
    }
}
