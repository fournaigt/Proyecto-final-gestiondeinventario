using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        N_Inventario negocio = new N_Inventario();
        public Login()
        {
            InitializeComponent();
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registrarse frmPrincipal = new Registrarse();
            frmPrincipal.ShowDialog();
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContra.Text;

            
            if (usuario == "admin" && contrasena == "admin")
            {
                MessageBox.Show("Bienvenido Admin!");
                this.Hide();
                InventarioAdmin frmPrincipal = new InventarioAdmin();
                frmPrincipal.ShowDialog();
                this.Close();
            }
            else
            {

                bool esValido = negocio.VerificarCredenciales(usuario, contrasena);

                
                if (esValido)
                {
                    MessageBox.Show("Inicio de sesión exitoso!");
                    this.Hide();
                    InventarioUsuario frmPrincipal = new InventarioUsuario();
                    frmPrincipal.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contraseña inválido!");
                }
            }

        }
    }
}
