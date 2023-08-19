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
    public partial class RegistroCompra : Form
    {
        public RegistroCompra()
        {
            InitializeComponent();
        }

        private void RegistroCompra_Load(object sender, EventArgs e)
        {
            N_Inventario negocio = new N_Inventario();
            List<E_Comprado> comprados = negocio.ObtenerComprados();

            dtaGridComprado.DataSource = comprados;
            dtaGridComprado.Columns["Id"].HeaderText = "ID";
            dtaGridComprado.Columns["Nombre"].HeaderText = "Nombre del Producto";
            dtaGridComprado.Columns["Stock"].HeaderText = "Stock Disponible";
            dtaGridComprado.ReadOnly = true;
            dtaGridComprado.AllowUserToAddRows = false;
            dtaGridComprado.AllowUserToDeleteRows = false;
            dtaGridComprado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtaGridComprado.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
