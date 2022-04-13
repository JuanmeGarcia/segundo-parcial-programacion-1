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
    public partial class AgregarMaestra : Form
    {
        public AgregarMaestra()
        {
            InitializeComponent();
        }

        private void btnMaestrasM_Click(object sender, EventArgs e)
        {
            Maestras maestras = new Maestras();
            maestras.Show();
            this.Hide();
        }

        int counterLegajoMaestras;
        private void btnAgregarM_Click(object sender, EventArgs e)
        {
            counterLegajoMaestras++;
            lblLegajoM.Text = counterLegajoMaestras.ToString();
            Maestras maestrasFrm = new Maestras();
            maestrasFrm.lblCM = lblCounterM;

            if(lblCounterM.Text != "7")
            {
                FileStream FSAdd = new FileStream("D:/Maestras.txt", FileMode.Append);
                StreamWriter SWAdd = new StreamWriter(FSAdd);
                string registroMaestras;
                registroMaestras = lblLegajoM.Text + ";" + txtNombreM.Text + ";" + txtApellidoM.Text + ";" + cmbTurnoM.Text + ";" + cmbSalaM.Text + ";" + txtSueldoM.Text + ";" + cmbEstSueldoM.Text + ";" + cmbRecibidaM.Text;
                SWAdd.WriteLine(registroMaestras);
                SWAdd.Close();
                FSAdd.Close();
                //ShowMaestras();
            }
            else if(lblCounterM.Text == "7")
            {
                MessageBox.Show("La cantidad de Maestras esta en su limite", "Cupo Lleno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            



        }

        public void ShowMaestras()
        {
             FileStream FSAdd = new FileStream("D:/Maestras.txt", FileMode.Open);
             StreamReader SRAdd = new StreamReader(FSAdd);
             string[] vectorMaestras;
             string registroMaestras;
             string legajo, nombre, apellido, turno, sala, sueldo, estSueldo, recibida;

             while (!(SRAdd.Peek() == -1))
             {
                 registroMaestras = SRAdd.ReadLine();
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
             }
             SRAdd.Close();
             FSAdd.Close();
        }
    }
}
