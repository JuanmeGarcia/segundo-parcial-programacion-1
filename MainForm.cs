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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quiere salir del programa?", "Cerrar Aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSalas_Click(object sender, EventArgs e)
        {
            SalasFrm salasForm = new SalasFrm();
            salasForm.Show();
            this.Hide();
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            Inscripcion inscribirse = new Inscripcion();
            inscribirse.Show();
            this.Hide();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            Alumnos alumnos = new Alumnos();
            alumnos.Show();
            this.Hide();
        }

        private void btnMaestras_Click(object sender, EventArgs e)
        {
            Maestras maestras = new Maestras();
            maestras.Show();
            this.Hide();
        }
    }
}
