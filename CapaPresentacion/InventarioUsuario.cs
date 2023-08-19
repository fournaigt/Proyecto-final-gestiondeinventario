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
    public partial class InventarioUsuario : Form
    {
        public InventarioUsuario()
        {
            InitializeComponent();
        }

        private void InventarioUsuario_Load(object sender, EventArgs e)
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar frmBuscar = new Buscar();
            frmBuscar.ShowDialog();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            
            string nombre = txtNombre.Text;
            int stock = int.Parse(txtCantidad.Text);
            N_Inventario inventario = new N_Inventario();
            inventario.ComprarProducto(nombre, stock);
            inventario.RegistrarCompra(nombre, stock);
            MessageBox.Show("Compra realizada exitosamente.");
            DtaGridAdmin.Refresh();

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            RegistroCompra frmBuscar = new RegistroCompra();
            frmBuscar.ShowDialog();
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

        private void btnCSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frmPrincipal = new Login();
            frmPrincipal.ShowDialog();
            this.Close();
        }
    }
}
