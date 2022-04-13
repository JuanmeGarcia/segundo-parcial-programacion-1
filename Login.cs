using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Segundo_Parcial_Programacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quiere salir del programa?", "Cerrar Aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (txtUser.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Usuario o Contraseña están vacíos", "Error al Iniciar Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtUser.Text == "Jorge Roda" && txtPassword.Text == "Roda2021")
            {

                MainForm MenuFrm = new MainForm();
                MenuFrm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("El Usuario o Contraseña son incorrectos", "Error al Iniciar Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuario: Jorge Roda  ||  Contraseña: Roda2021", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }
    }  
}
