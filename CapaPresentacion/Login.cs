using System;
using System.Windows.Forms;

using CapaNegocio;
using CapaEntidad;
using System.Linq;
using System.Collections.Generic;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntingresar_Click(object sender, EventArgs e)
        {

            List<Usuario> test = new CN_Usuario().Listar();

            Usuario ousuario = new CN_Usuario().Listar().Where(u => u.Documento == txtdocumento.Text && u.Clave == txtclave.Text).FirstOrDefault();

            if (ousuario != null)
            {

                Inicio form = new Inicio(ousuario);
                form.Show();
                this.Hide();

                form.FormClosing += frm_closing;
            }
            else { 
                MessageBox.Show("Usuario o clave incorrecta", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtdocumento.Clear();
            txtclave.Clear();

            this.Show();
        }
    }
}
