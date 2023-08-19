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
    public partial class Buscar : Form
    {
        public Buscar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            N_Inventario inventario = new N_Inventario();
            bunifuCustomDataGrid1.DataSource = inventario.BuscarPorNombre(nombre);
            bunifuCustomDataGrid1.ReadOnly = true;
            bunifuCustomDataGrid1.AllowUserToAddRows = false;
            bunifuCustomDataGrid1.AllowUserToDeleteRows = false;
            bunifuCustomDataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            bunifuCustomDataGrid1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
