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
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frmPrincipal = new Login();
            frmPrincipal.ShowDialog();
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContrasena.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
            else
            {
                E_Usuario usuario = new E_Usuario();
                usuario.Usuario = txtUsuario.Text;
                usuario.Contrasena = txtContrasena.Text;
                N_Inventario inventario = new N_Inventario();
                inventario.RegistrarUsuario(usuario);
                MessageBox.Show("Usuario registrado correctamente.");
                this.Hide();
                Login frmPrincipal = new Login();
                frmPrincipal.ShowDialog();
                this.Close();
            }

        }
    }
}
