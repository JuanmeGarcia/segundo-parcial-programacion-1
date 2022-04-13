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
    public partial class SalasFrm : Form
    {
        public SalasFrm()
        {
            InitializeComponent();
        }



        private void Salas_Load(object sender, EventArgs e)
        {
            lstLactariosS.Show();
            lstDeamb1S.Hide();
            lstDeamb2S.Hide();
            lstSala2S.Hide();
            lstSala3S.Hide();

            lblCCLac.Hide();
            lblCounter.Hide();
            lblCCD1.Hide();
            lblCounterD1.Hide();
            lblCCD2.Hide();
            lblCounterD2.Hide();
            lblCCS2.Hide();
            lblCounterS2.Hide();
            lblCCS3.Hide();
            lblCounterS3.Hide();
        }



        private void btnHome1_Click(object sender, EventArgs e)
        {
            MainForm home = new MainForm();
            home.Show();
            this.Close();

        }


        private void btnCheckk_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbSalas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSalas.SelectedIndex == 0)
            {
                lstLactariosS.Show();
                lstDeamb1S.Hide();
                lstDeamb2S.Hide();
                lstSala2S.Hide();
                lstSala3S.Hide();

                lblCCLac.Show();
                lblCounter.Show();
                lblCCD1.Hide();
                lblCounterD1.Hide();
                lblCCD2.Hide();
                lblCounterD2.Hide();
                lblCCS2.Hide();
                lblCounterS2.Hide();
                lblCCS3.Hide();
                lblCounterS3.Hide();

                ShowLactarios();
            }
            else if (cmbSalas.SelectedIndex == 1)
            {
                lstLactariosS.Hide();
                lstDeamb1S.Show();
                lstDeamb2S.Hide();
                lstSala2S.Hide();
                lstSala3S.Hide();

                lblCCLac.Hide();
                lblCounter.Hide();
                lblCCD1.Show();
                lblCounterD1.Show();
                lblCCD2.Hide();
                lblCounterD2.Hide();
                lblCCS2.Hide();
                lblCounterS2.Hide();
                lblCCS3.Hide();
                lblCounterS3.Hide();

                ShowDeambuladores1();
            }
            else if (cmbSalas.SelectedIndex == 2)
            {
                lstLactariosS.Hide();
                lstDeamb1S.Hide();
                lstDeamb2S.Show();
                lstSala2S.Hide();
                lstSala3S.Hide();

                lblCCLac.Hide();
                lblCounter.Hide();
                lblCCD1.Hide();
                lblCounterD1.Hide();
                lblCCD2.Show();
                lblCounterD2.Show();
                lblCCS2.Hide();
                lblCounterS2.Hide();
                lblCCS3.Hide();
                lblCounterS3.Hide();

                ShowDeambuladores2();
            }
            else if (cmbSalas.SelectedIndex == 3)
            {
                lstLactariosS.Hide();
                lstDeamb1S.Hide();
                lstDeamb2S.Hide();
                lstSala2S.Show();
                lstSala3S.Hide();

                lblCCLac.Hide();
                lblCounter.Hide();
                lblCCD1.Hide();
                lblCounterD1.Hide();
                lblCCD2.Hide();
                lblCounterD2.Hide();
                lblCCS2.Show();
                lblCounterS2.Show();
                lblCCS3.Hide();
                lblCounterS3.Hide();

                ShowSala2();
            }
            else if (cmbSalas.SelectedIndex == 4)
            {
                lstLactariosS.Hide();
                lstDeamb1S.Hide();
                lstDeamb2S.Hide();
                lstSala2S.Hide();
                lstSala3S.Show();

                lblCCLac.Hide();
                lblCounter.Hide();
                lblCCD1.Hide();
                lblCounterD1.Hide();
                lblCCD2.Hide();
                lblCounterD2.Hide();
                lblCCS2.Hide();
                lblCounterS2.Hide();
                lblCCS3.Show();
                lblCounterS3.Show();

                ShowSala3();
            }
        }

        

        void ShowLactarios()
        {
            if (File.Exists("D:/Lactarios.txt"))
            {
                FileStream FSLac = new FileStream("D:/Lactarios.txt", FileMode.Open);
                StreamReader SRLac = new StreamReader(FSLac);
                string[] vectorLac;
                string registroLac;
                string legajo, nombre, apellido, años, meses, sexo, turno, comedor, hermanos, cuota;
                lstLactariosS.Items.Clear();
                while(!(SRLac.Peek()== -1))
                {
                    registroLac = SRLac.ReadLine();
                    vectorLac = registroLac.Split(';');
                    legajo = vectorLac[0];
                    nombre = vectorLac[1];
                    apellido = vectorLac[2];
                    años = vectorLac[3];
                    meses = vectorLac[4];
                    sexo = vectorLac[5];
                    turno = vectorLac[6];
                    comedor = vectorLac[7];
                    hermanos = vectorLac[8];
                    cuota = vectorLac[9];

                    ListViewItem lsLac = new ListViewItem(legajo);
                    lsLac.SubItems.Add(nombre);
                    lsLac.SubItems.Add(apellido);
                    lsLac.SubItems.Add(años);
                    lsLac.SubItems.Add(meses);
                    lsLac.SubItems.Add(sexo);
                    lsLac.SubItems.Add(turno);
                    lsLac.SubItems.Add(comedor);
                    lsLac.SubItems.Add(hermanos);
                    lsLac.SubItems.Add(cuota);
                    lstLactariosS.Items.Add(lsLac);

                    lblCounter.Text = lstLactariosS.Items.Count.ToString();
                    
                    
                    
                }
                SRLac.Close();
                FSLac.Close();
            }
        }

        void ShowDeambuladores1()
        {
            if (File.Exists("D:/Deambuladores 1.txt"))
            {
                FileStream FSD1 = new FileStream("D:/Deambuladores 1.txt", FileMode.Open);
                StreamReader SRD1 = new StreamReader(FSD1);
                string[] vectorD1;
                string registroD1;
                string legajo, nombre, apellido, años, meses, sexo, turno, comedor, hermanos, cuota;
                lstDeamb1S.Items.Clear();
                while (!(SRD1.Peek() == -1))
                {
                    registroD1 = SRD1.ReadLine();
                    vectorD1 = registroD1.Split(';');
                    legajo = vectorD1[0];
                    nombre = vectorD1[1];
                    apellido = vectorD1[2];
                    años = vectorD1[3];
                    meses = vectorD1[4];
                    sexo = vectorD1[5];
                    turno = vectorD1[6];
                    comedor = vectorD1[7];
                    hermanos = vectorD1[8];
                    cuota = vectorD1[9];

                    ListViewItem lsD1 = new ListViewItem(legajo);
                    lsD1.SubItems.Add(nombre);
                    lsD1.SubItems.Add(apellido);
                    lsD1.SubItems.Add(años);
                    lsD1.SubItems.Add(meses);
                    lsD1.SubItems.Add(sexo);
                    lsD1.SubItems.Add(turno);
                    lsD1.SubItems.Add(comedor);
                    lsD1.SubItems.Add(hermanos);
                    lsD1.SubItems.Add(cuota);
                    lstDeamb1S.Items.Add(lsD1);

                    lblCounterD1.Text = lstDeamb1S.Items.Count.ToString();
                }
                SRD1.Close();
                FSD1.Close();
            }
        }

        void ShowDeambuladores2()
        {
            if (File.Exists("D:/Deambuladores 2.txt"))
            {
                FileStream FSD2 = new FileStream("D:/Deambuladores 2.txt", FileMode.Open);
                StreamReader SRD2 = new StreamReader(FSD2);
                string[] vectorD2;
                string registroD2;
                string legajo, nombre, apellido, años, meses, sexo, turno, comedor, hermanos, cuota;
                lstDeamb2S.Items.Clear();
                while (!(SRD2.Peek() == -1))
                {
                    registroD2 = SRD2.ReadLine();
                    vectorD2 = registroD2.Split(';');
                    legajo = vectorD2[0];
                    nombre = vectorD2[1];
                    apellido = vectorD2[2];
                    años = vectorD2[3];
                    meses = vectorD2[4];
                    sexo = vectorD2[5];
                    turno = vectorD2[6];
                    comedor = vectorD2[7];
                    hermanos = vectorD2[8];
                    cuota = vectorD2[9];

                    ListViewItem lsD2 = new ListViewItem(legajo);
                    lsD2.SubItems.Add(nombre);
                    lsD2.SubItems.Add(apellido);
                    lsD2.SubItems.Add(años);
                    lsD2.SubItems.Add(meses);
                    lsD2.SubItems.Add(sexo);
                    lsD2.SubItems.Add(turno);
                    lsD2.SubItems.Add(comedor);
                    lsD2.SubItems.Add(hermanos);
                    lsD2.SubItems.Add(cuota);
                    lstDeamb2S.Items.Add(lsD2);

                    lblCounterD2.Text = lstDeamb2S.Items.Count.ToString();
                }
                SRD2.Close();
                FSD2.Close();
            }
        }

        void ShowSala2()
        {
            if (File.Exists("D:/SalaDe2.txt"))
            {
                FileStream FSS2 = new FileStream("D:/SalaDe2.txt", FileMode.Open);
                StreamReader SRS2 = new StreamReader(FSS2);
                string[] vectorS2;
                string registroS2;
                string legajo, nombre, apellido, años, meses, sexo, turno, comedor, hermanos, cuota;
                lstSala2S.Items.Clear();
                while (!(SRS2.Peek() == -1))
                {
                    registroS2 = SRS2.ReadLine();
                    vectorS2 = registroS2.Split(';');
                    legajo = vectorS2[0];
                    nombre = vectorS2[1];
                    apellido = vectorS2[2];
                    años = vectorS2[3];
                    meses = vectorS2[4];
                    sexo = vectorS2[5];
                    turno = vectorS2[6];
                    comedor = vectorS2[7];
                    hermanos = vectorS2[8];
                    cuota = vectorS2[9];

                    ListViewItem lsS2 = new ListViewItem(legajo);
                    lsS2.SubItems.Add(nombre);
                    lsS2.SubItems.Add(apellido);
                    lsS2.SubItems.Add(años);
                    lsS2.SubItems.Add(meses);
                    lsS2.SubItems.Add(sexo);
                    lsS2.SubItems.Add(turno);
                    lsS2.SubItems.Add(comedor);
                    lsS2.SubItems.Add(hermanos);
                    lsS2.SubItems.Add(cuota);
                    lstSala2S.Items.Add(lsS2);

                    lblCounterS2.Text = lstSala2S.Items.Count.ToString();
                }
                SRS2.Close();
                FSS2.Close();
            }
        }

        void ShowSala3()
        {
            if (File.Exists("D:/SalaDe3.txt"))
            {
                FileStream FSS3 = new FileStream("D:/SalaDe3.txt", FileMode.Open);
                StreamReader SRS3 = new StreamReader(FSS3);
                string[] vectorS3;
                string registroS3;
                string legajo, nombre, apellido, años, meses, sexo, turno, comedor, hermanos, cuota;
                lstSala3S.Items.Clear();
                while (!(SRS3.Peek() == -1))
                {
                    registroS3 = SRS3.ReadLine();
                    vectorS3 = registroS3.Split(';');
                    legajo = vectorS3[0];
                    nombre = vectorS3[1];
                    apellido = vectorS3[2];
                    años = vectorS3[3];
                    meses = vectorS3[4];
                    sexo = vectorS3[5];
                    turno = vectorS3[6];
                    comedor = vectorS3[7];
                    hermanos = vectorS3[8];
                    cuota = vectorS3[9];

                    ListViewItem lsS3 = new ListViewItem(legajo);
                    lsS3.SubItems.Add(nombre);
                    lsS3.SubItems.Add(apellido);
                    lsS3.SubItems.Add(años);
                    lsS3.SubItems.Add(meses);
                    lsS3.SubItems.Add(sexo);
                    lsS3.SubItems.Add(turno);
                    lsS3.SubItems.Add(comedor);
                    lsS3.SubItems.Add(hermanos);
                    lsS3.SubItems.Add(cuota);
                    lstSala3S.Items.Add(lsS3);

                    lblCounterS3.Text = lstSala3S.Items.Count.ToString();
                }
                SRS3.Close();
                FSS3.Close();
            }
        }

        private void lblCounterS3_Click(object sender, EventArgs e)
        {

        }
    }
}
