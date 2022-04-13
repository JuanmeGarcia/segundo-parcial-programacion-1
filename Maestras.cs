using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Segundo_Parcial_Programacion
{
    public partial class Maestras : Form
    {
        public Maestras()
        {
            InitializeComponent();
        }

        private void btnHome1_Click(object sender, EventArgs e)
        {
            MainForm home = new MainForm();
            home.Show();
            this.Close();
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarMaestra agg = new AgregarMaestra();
            agg.Show();
            this.Hide();
            
        }

        private void Maestras_Load(object sender, EventArgs e)
        {
            lblLegajoMod.Hide();
            txtLegajoMod.Hide();
            lblNombreMod.Hide();
            txtNombreMod.Hide();
            lblApellidoMod.Hide();
            txtApellidoMod.Hide();
            lblTurnoMod.Hide();
            cmbTurnoMod.Hide();
            lblSalaMod.Hide();
            cmbSalaMod.Hide();
            lblSueldoMod.Hide();
            txtSueldoMod.Hide();
            lblEstSueldoMod.Hide();
            cmbEstSueldoMod.Hide();
            lblRecibidaMod.Hide();
            cmbRecibidaMod.Hide();
            btnModificarM.Hide();
           
            ShowMaestras();
            
        }

        private void btnMModificarM_Click(object sender, EventArgs e)
        {
            lblLegajoMod.Show();
            txtLegajoMod.Show();
            lblNombreMod.Show();
            txtNombreMod.Show();
            lblApellidoMod.Show();
            txtApellidoMod.Show();
            lblTurnoMod.Show();
            cmbTurnoMod.Show();
            lblSalaMod.Show();
            cmbSalaMod.Show();
            lblSueldoMod.Show();
            txtSueldoMod.Show();
            lblEstSueldoMod.Show();
            cmbEstSueldoMod.Show();
            lblRecibidaMod.Show();
            cmbRecibidaMod.Show();
            btnModificarM.Show();

           
            if ((txtModificarM.Text == "") || (txtModificarM2.Text == ""))
            {
                MessageBox.Show("El Nombre o Apellido de la Maestra esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblLegajoMod.Hide();
                txtLegajoMod.Hide();
                lblNombreMod.Hide();
                txtNombreMod.Hide();
                lblApellidoMod.Hide();
                txtApellidoMod.Hide();
                lblTurnoMod.Hide();
                cmbTurnoMod.Hide();
                lblSalaMod.Hide();
                cmbSalaMod.Hide();
                lblSueldoMod.Hide();
                txtSueldoMod.Hide();
                lblEstSueldoMod.Hide();
                cmbEstSueldoMod.Hide();
                lblRecibidaMod.Hide();
                cmbRecibidaMod.Hide();
                btnModificarM.Hide();
            }
        }

        private void btnEliminarM_Click(object sender, EventArgs e)
        {
            FileStream FSMaestras = new FileStream("D:/Maestras.txt", FileMode.Open);
            FileStream FSMAux = new FileStream("D:/MaestrasAux.txt", FileMode.Create);
            StreamReader SRMaestras = new StreamReader(FSMaestras);
            StreamWriter SWMAux = new StreamWriter(FSMAux);
            string[] vectorMaestras;
            string registroMaestras;
            string nombre, apellido;
            while(!(SRMaestras.Peek() == -1))
            {
                registroMaestras = SRMaestras.ReadLine();
                vectorMaestras = registroMaestras.Split(';');
                nombre = vectorMaestras[1];
                apellido = vectorMaestras[2];
                if((nombre != txtEliminar.Text) && (apellido != txtEliminar2.Text))
                {
                    SWMAux.WriteLine(registroMaestras);
                }
                
            }
            SRMaestras.Close();
            SWMAux.Close();
            FSMaestras.Close();
            FSMAux.Close();
            File.Delete("D:/Maestras.txt");
            File.Move("D:/MaestrasAux.txt", "D:/Maestras.txt");
            ShowMaestras();
        }

        private void btnModificarM_Click(object sender, EventArgs e)
        {
            AgregarMaestra aggMaestra = new AgregarMaestra();
            aggMaestra.lblLegajoM.Text = txtLegajoMod.Text;
            aggMaestra.txtNombreM = txtNombreMod;
            aggMaestra.txtApellidoM = txtApellidoMod;
            aggMaestra.cmbTurnoM = cmbTurnoMod;
            aggMaestra.cmbSalaM = cmbSalaMod;
            aggMaestra.txtSueldoM = txtSueldoMod;
            aggMaestra.cmbEstSueldoM = cmbEstSueldoMod;
            aggMaestra.cmbEstSueldoM = cmbRecibidaMod;

            FileStream FSMaestrasM = new FileStream("D:/Maestras.txt", FileMode.Open);
            FileStream FSMAuxM = new FileStream("D:/MaestrasAux.txt", FileMode.Create);
            StreamReader SRMaestrasM = new StreamReader(FSMaestrasM);
            StreamWriter SWMaestrasM = new StreamWriter(FSMAuxM);
            string[] vectorMaestrasM;
            string nombre, apellido;
            string registroMod;
            while(!(SRMaestrasM.Peek() == -1))
            {
                registroMod = SRMaestrasM.ReadLine();
                vectorMaestrasM = registroMod.Split(';');
                nombre = vectorMaestrasM[1];
                apellido = vectorMaestrasM[2];
                if((nombre == txtModificarM.Text) || (apellido == txtModificarM2.Text))
                {
                    registroMod = txtLegajoMod.Text + ";" + txtNombreMod.Text + ";" + txtApellidoMod.Text + ";" + cmbTurnoMod.Text + ";" + cmbSalaMod.Text + ";" + txtSueldoMod.Text + ";" + cmbEstSueldoMod.Text + ";" + cmbRecibidaMod.Text;
                    
                }
                
                
                SWMaestrasM.WriteLine(registroMod);
            }
            SRMaestrasM.Close();
            SWMaestrasM.Close();
            FSMAuxM.Close();
            FSMaestrasM.Close();
            File.Delete("D:/Maestras.txt");
            File.Move("D:/MaestrasAux.txt", "D:/Maestras.txt");
            ShowMaestras();

            lblLegajoMod.Hide();
            txtLegajoMod.Hide();
            lblNombreMod.Hide();
            txtNombreMod.Hide();
            lblApellidoMod.Hide();
            txtApellidoMod.Hide();
            lblTurnoMod.Hide();
            cmbTurnoMod.Hide();
            lblSalaMod.Hide();
            cmbSalaMod.Hide();
            lblSueldoMod.Hide();
            txtSueldoMod.Hide();
            lblEstSueldoMod.Hide();
            cmbEstSueldoMod.Hide();
            lblRecibidaMod.Hide();
            cmbRecibidaMod.Hide();
            btnModificarM.Hide();

        }

        public void ShowMaestras()
        {
            if (File.Exists("D:/Maestras.txt"))
            {

                FileStream FSAdd2 = new FileStream("D:/Maestras.txt", FileMode.Open);
                StreamReader SRAdd2 = new StreamReader(FSAdd2);
                string[] vectorMaestras;
                string registroMaestras;
                string legajo, nombre, apellido, turno, sala, sueldo, estSueldo, recibida;
                lstMaestras.Items.Clear();
                while (!(SRAdd2.Peek() == -1))
                {
                    registroMaestras = SRAdd2.ReadLine();
                    vectorMaestras = registroMaestras.Split(';');
                    legajo = vectorMaestras[0];
                    nombre = vectorMaestras[1];
                    apellido = vectorMaestras[2];
                    turno = vectorMaestras[3];
                    sala = vectorMaestras[4];
                    sueldo = vectorMaestras[5];
                    estSueldo = vectorMaestras[6];
                    recibida = vectorMaestras[7];

                    ListViewItem lsMaestras = new ListViewItem(legajo);
                    lsMaestras.SubItems.Add(nombre);
                    lsMaestras.SubItems.Add(apellido);
                    lsMaestras.SubItems.Add(turno);
                    lsMaestras.SubItems.Add(sala);
                    lsMaestras.SubItems.Add(sueldo);
                    lsMaestras.SubItems.Add(estSueldo);
                    lsMaestras.SubItems.Add(recibida);
                    lstMaestras.Items.Add(lsMaestras);

                    lblCM.Text = lstMaestras.Items.Count.ToString();
                }
                SRAdd2.Close();
                FSAdd2.Close();
            }
        }

        private void cmbSalas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbSalas.SelectedIndex == 0)
            {
                lstMaestras.Show();
                listView1.Hide();
                    
                ShowMaestras();
            }
            else if(cmbSalas.SelectedIndex == 1)
            {
                lstMaestras.Hide();
                listView1.Hide();
            }
        }
    }
}
