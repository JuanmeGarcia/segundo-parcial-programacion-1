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
    public partial class Alumnos : Form
    {
        public Alumnos()
        {
            InitializeComponent();
        }

        private void btnHome1_Click(object sender, EventArgs e)
        {
            MainForm home = new MainForm();
            home.Show();
            this.Close();
        }



        private void Alumnos_Load(object sender, EventArgs e)
        {
            lstLactarios.Show();
            lstDeamb1.Hide();
            lstDeamb2.Hide();
            lstSala2.Hide();
            lstSala3.Hide();

            lblLegajoAl.Hide();
            txtLegajoAl.Hide();
            lblNombreAl.Hide();
            txtNombreAl.Hide();
            lblApellidoAl.Hide();
            txtApellidoAl.Hide();
            lblAñosAl.Hide();
            cmbAñosAl.Hide();
            lblMesesAl.Hide();
            cmbMesesAl.Hide();
            lblSexoAl.Hide();
            cmbSexoAl.Hide();
            lblTurnoAl.Hide();
            cmbTurnoAl.Hide();
            
            lblComedorAl.Hide();
            gpbComedorAl.Hide();
            lblHermanosAl.Hide();
            gpbHermanosAl.Hide();
            btnModificarLac.Hide();

            btnEliminarLac.Hide();
            btnEliminarD1.Hide();
            btnEliminarD2.Hide();
            btnEliminarS2.Hide();
            btnEliminarS3.Hide();

            btnModificarLac.Hide();
            btnModificarD1.Hide();
            btnModificarD2.Hide();
            btnModificarS2.Hide();
            btnModificarS3.Hide();

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


        private void btnMModificarAl_Click_1(object sender, EventArgs e)
        {
            lblLegajoAl.Show();
            txtLegajoAl.Show();
            lblNombreAl.Show();
            txtNombreAl.Show();
            lblApellidoAl.Show();
            txtApellidoAl.Show();
            lblAñosAl.Show();
            cmbAñosAl.Show();
            lblMesesAl.Show();
            cmbMesesAl.Show();
            lblSexoAl.Show();
            cmbSexoAl.Show();
            lblTurnoAl.Show();
            cmbTurnoAl.Show();
            
            lblComedorAl.Show();
            gpbComedorAl.Show();
            lblHermanosAl.Show();
            gpbHermanosAl.Show();
            btnModificarLac.Show();
        }

        private void cmbSalas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSalas.SelectedIndex == 0)
            {
                lstLactarios.Show();
                lstDeamb1.Hide();
                lstDeamb2.Hide();
                lstSala2.Hide();
                lstSala3.Hide();

                btnEliminarLac.Show();
                btnEliminarD1.Hide();
                btnEliminarD2.Hide();
                btnEliminarS2.Hide();
                btnEliminarS3.Hide();

                btnModificarLac.Show();
                btnModificarD1.Hide();
                btnModificarD2.Hide();
                btnModificarS2.Hide();
                btnModificarS3.Hide();

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

                ShowLactariosAl();
            }
            else if (cmbSalas.SelectedIndex == 1)
            {
                lstLactarios.Hide();
                lstDeamb1.Show();
                lstDeamb2.Hide();
                lstSala2.Hide();
                lstSala3.Hide();

                btnEliminarLac.Hide();
                btnEliminarD1.Show();
                btnEliminarD2.Hide();
                btnEliminarS2.Hide();
                btnEliminarS3.Hide();

                btnModificarLac.Hide();
                btnModificarD1.Show();
                btnModificarD2.Hide();
                btnModificarS2.Hide();
                btnModificarS3.Hide();

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

                ShowDeambuladores1Al();
            }

            else if (cmbSalas.SelectedIndex == 2) 
            { 
            
                lstLactarios.Hide();
                lstDeamb1.Hide();
                lstDeamb2.Show();
                lstSala2.Hide();
                lstSala3.Hide();

                btnEliminarLac.Hide();
                btnEliminarD1.Hide();
                btnEliminarD2.Show();
                btnEliminarS2.Hide();
                btnEliminarS3.Hide();

                btnModificarLac.Hide();
                btnModificarD1.Hide();
                btnModificarD2.Show();
                btnModificarS2.Hide();
                btnModificarS3.Hide();

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

                ShowDeambuladores2Al();
            }

            else if (cmbSalas.SelectedIndex == 3)
            {
                lstLactarios.Hide();
                lstDeamb1.Hide();
                lstDeamb2.Hide();
                lstSala2.Show();
                lstSala3.Hide();

                btnEliminarLac.Hide();
                btnEliminarD1.Hide();
                btnEliminarD2.Hide();
                btnEliminarS2.Show();
                btnEliminarS3.Hide();

                btnModificarLac.Hide();
                btnModificarD1.Hide();
                btnModificarD2.Hide();
                btnModificarS2.Show();
                btnModificarS3.Hide();

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

                ShowSala2Al();
            }

            else if (cmbSalas.SelectedIndex == 4)
            {
                lstLactarios.Hide();
                lstDeamb1.Hide();
                lstDeamb2.Hide();
                lstSala2.Hide();
                lstSala3.Show();

                btnEliminarLac.Hide();
                btnEliminarD1.Hide();
                btnEliminarD2.Hide();
                btnEliminarS2.Hide();
                btnEliminarS3.Show();

                btnModificarLac.Hide();
                btnModificarD1.Hide();
                btnModificarD2.Hide();
                btnModificarS2.Hide();
                btnModificarS3.Show();

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

                ShowSala3Al();
            }
        }

        void ShowLactariosAl()
        {
            if (File.Exists("D:/Lactarios.txt"))
            {
                FileStream FSLac = new FileStream("D:/Lactarios.txt", FileMode.Open);
                StreamReader SRLac = new StreamReader(FSLac);
                string[] vectorLac;
                string registroLac;
                string legajo, nombre, apellido, años, meses, sexo, turno, comedor, hermanos, cuota;
                lstLactarios.Items.Clear();
                while (!(SRLac.Peek() == -1))
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
                    lstLactarios.Items.Add(lsLac);

                    lblCounter.Text = lstLactarios.Items.Count.ToString();
                }
                SRLac.Close();
                FSLac.Close();
            }
        }

        void ShowDeambuladores1Al()
        {
            if (File.Exists("D:/Deambuladores 1.txt"))
            {
                FileStream FSD1 = new FileStream("D:/Deambuladores 1.txt", FileMode.Open);
                StreamReader SRD1 = new StreamReader(FSD1);
                string[] vectorD1;
                string registroD1;
                string legajo, nombre, apellido, años, meses, sexo, turno, comedor, hermanos, cuota;
                lstDeamb1.Items.Clear();
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
                    lstDeamb1.Items.Add(lsD1);

                    lblCounterD1.Text = lstDeamb1.Items.Count.ToString();
                }
                SRD1.Close();
                FSD1.Close();
            }
        }

        void ShowDeambuladores2Al()
        {
            if (File.Exists("D:/Deambuladores 2.txt"))
            {
                FileStream FSD2 = new FileStream("D:/Deambuladores 2.txt", FileMode.Open);
                StreamReader SRD2 = new StreamReader(FSD2);
                string[] vectorD2;
                string registroD2;
                string legajo, nombre, apellido, años, meses, sexo, turno, comedor, hermanos, cuota;
                lstDeamb2.Items.Clear();
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
                    lstDeamb2.Items.Add(lsD2);

                    lblCounterD2.Text = lstDeamb2.Items.Count.ToString();
                }
                SRD2.Close();
                FSD2.Close();
            }
        }

        void ShowSala2Al()
        {
            if (File.Exists("D:/SalaDe2.txt"))
            {
                FileStream FSS2 = new FileStream("D:/SalaDe2.txt", FileMode.Open);
                StreamReader SRS2 = new StreamReader(FSS2);
                string[] vectorS2;
                string registroS2;
                string legajo, nombre, apellido, años, meses, sexo, turno, comedor, hermanos, cuota;
                lstSala2.Items.Clear();
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
                    lstSala2.Items.Add(lsS2);

                    lblCounterS2.Text = lstSala2.Items.Count.ToString();
                }
                SRS2.Close();
                FSS2.Close();
            }
        }

        void ShowSala3Al()
        {
            if (File.Exists("D:/SalaDe3.txt"))
            {
                FileStream FSS3 = new FileStream("D:/SalaDe3.txt", FileMode.Open);
                StreamReader SRS3 = new StreamReader(FSS3);
                string[] vectorS3;
                string registroS3;
                string legajo, nombre, apellido, años, meses, sexo, turno, comedor, hermanos, cuota;
                lstSala3.Items.Clear();
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
                    lstSala3.Items.Add(lsS3);

                    lblCounterS3.Text = lstSala3.Items.Count.ToString();
                }
                SRS3.Close();
                FSS3.Close();
            }
        }

        private void btnEliminarLac_Click(object sender, EventArgs e)
        {
            FileStream FSLac1 = new FileStream("D:/Lactarios.txt", FileMode.Open);
            FileStream FSLac1Aux = new FileStream("D:/LactariosAux.txt", FileMode.Create);
            StreamReader SRLac1 = new StreamReader(FSLac1);
            StreamWriter SWLac1Aux = new StreamWriter(FSLac1Aux);
            string[] vectorLac1;
            string registroLac1;
            string nombre, apellido;
            while (!(SRLac1.Peek() == -1))
            {
                registroLac1 = SRLac1.ReadLine();
                vectorLac1 = registroLac1.Split(';');
                nombre = vectorLac1[1];
                apellido = vectorLac1[2];
                if ((nombre != txtEliminar.Text) && (apellido != txtEliminar2.Text))
                {
                    SWLac1Aux.WriteLine(registroLac1);
                }

            }
            SRLac1.Close();
            SWLac1Aux.Close();
            FSLac1.Close();
            FSLac1Aux.Close();
            File.Delete("D:/Lactarios.txt");
            File.Move("D:/LactariosAux.txt", "D:/Lactarios.txt");
            ShowLactariosAl();
        }

        private void btnEliminarD1_Click(object sender, EventArgs e)
        {
            FileStream FSD11 = new FileStream("D:/Deambuladores 1.txt", FileMode.Open);
            FileStream FSD1Aux = new FileStream("D:/Deambuladores1Aux.txt", FileMode.Create);
            StreamReader SRD11 = new StreamReader(FSD11);
            StreamWriter SWD1Aux = new StreamWriter(FSD1Aux);
            string[] vectorD11;
            string registroD11;
            string nombre, apellido;
            while (!(SRD11.Peek() == -1))
            {
                registroD11 = SRD11.ReadLine();
                vectorD11 = registroD11.Split(';');
                nombre = vectorD11[1];
                apellido = vectorD11[2];
                if ((nombre != txtEliminar.Text) && (apellido != txtEliminar2.Text))
                {
                    SWD1Aux.WriteLine(registroD11);
                }

            }
            SRD11.Close();
            SWD1Aux.Close();
            FSD11.Close();
            FSD1Aux.Close();
            File.Delete("D:/Deambuladores 1.txt");
            File.Move("D:/Deambuladores1Aux.txt", "D:/Deambuladores 1.txt");
            ShowDeambuladores1Al();
        }

        private void btnEliminarD2_Click(object sender, EventArgs e)
        {
            FileStream FSD21 = new FileStream("D:/Deambuladores 2.txt", FileMode.Open);
            FileStream FSD2Aux = new FileStream("D:/Deambuladores2Aux.txt", FileMode.Create);
            StreamReader SRD21 = new StreamReader(FSD21);
            StreamWriter SWD2Aux = new StreamWriter(FSD2Aux);
            string[] vectorD21;
            string registroD21;
            string nombre, apellido;
            while (!(SRD21.Peek() == -1))
            {
                registroD21 = SRD21.ReadLine();
                vectorD21 = registroD21.Split(';');
                nombre = vectorD21[1];
                apellido = vectorD21[2];
                if ((nombre != txtEliminar.Text) && (apellido != txtEliminar2.Text))
                {
                    SWD2Aux.WriteLine(registroD21);
                }

            }
            SRD21.Close();
            SWD2Aux.Close();
            FSD21.Close();
            FSD2Aux.Close();
            File.Delete("D:/Deambuladores 2.txt");
            File.Move("D:/Deambuladores2Aux.txt", "D:/Deambuladores 2.txt");
            ShowDeambuladores2Al();
        }

        private void btnEliminarS2_Click(object sender, EventArgs e)
        {
            FileStream FSS11 = new FileStream("D:/SalaDe2.txt", FileMode.Open);
            FileStream FSS1Aux = new FileStream("D:/SalaDe2Aux.txt", FileMode.Create);
            StreamReader SRS11 = new StreamReader(FSS11);
            StreamWriter SWS1Aux = new StreamWriter(FSS1Aux);
            string[] vectorS11;
            string registroS11;
            string nombre, apellido;
            while (!(SRS11.Peek() == -1))
            {
                registroS11 = SRS11.ReadLine();
                vectorS11 = registroS11.Split(';');
                nombre = vectorS11[1];
                apellido = vectorS11[2];
                if ((nombre != txtEliminar.Text) && (apellido != txtEliminar2.Text))
                {
                    SWS1Aux.WriteLine(registroS11);
                }

            }
            SRS11.Close();
            SWS1Aux.Close();
            FSS11.Close();
            FSS1Aux.Close();
            File.Delete("D:/SalaDe2.txt");
            File.Move("D:/SalaDe2Aux.txt", "D:/SalaDe2.txt");
            ShowSala2Al();
        }

        private void btnEliminarS3_Click(object sender, EventArgs e)
        {
            FileStream FSS31 = new FileStream("D:/SalaDe3.txt", FileMode.Open);
            FileStream FSS3Aux = new FileStream("D:/SalaDe3Aux.txt", FileMode.Create);
            StreamReader SRS31 = new StreamReader(FSS31);
            StreamWriter SWS3Aux = new StreamWriter(FSS3Aux);
            string[] vectorS31;
            string registroS31;
            string nombre, apellido;
            while (!(SRS31.Peek() == -1))
            {
                registroS31 = SRS31.ReadLine();
                vectorS31 = registroS31.Split(';');
                nombre = vectorS31[1];
                apellido = vectorS31[2];
                if ((nombre != txtEliminar.Text) && (apellido != txtEliminar2.Text))
                {
                    SWS3Aux.WriteLine(registroS31);
                }

            }
            SRS31.Close();
            SWS3Aux.Close();
            FSS31.Close();
            FSS3Aux.Close();
            File.Delete("D:/SalaDe3.txt");
            File.Move("D:/SalaDe3Aux.txt", "D:/SalaDe3.txt");
            ShowSala3Al();
        }

        private void btnModificarLac_Click(object sender, EventArgs e)
        {
            Inscripcion insAl = new Inscripcion();
            insAl.lblLegajo.Text = txtLegajoAl.Text;
            insAl.txtNombre = txtNombreAl;
            insAl.txtApellido = txtApellidoAl;
            insAl.cmbAños = cmbAñosAl;
            insAl.cmbMeses = cmbMesesAl;
            insAl.cmbSexo = cmbSexoAl;
            insAl.cmbTurno = cmbTurnoAl;
            insAl.rdbComedorNo = rdbComedorNoAl;
            insAl.rdbComedorSi = rdbComedorSiAl;
            insAl.rdbHermanosNo = rdbHermanosNoAl;
            insAl.rdbHermanosSi = rdbHermanosSiAl;

            FileStream FSLacM = new FileStream("D:/Lactarios.txt", FileMode.Open);
            FileStream FSLacAuxM = new FileStream("D:/LactariosAux.txt", FileMode.Create);
            StreamReader SRLacM = new StreamReader(FSLacM);
            StreamWriter SWLacM = new StreamWriter(FSLacAuxM);
            string[] vectorLacM;
            string nombre, apellido;
            string registroLacMod;
            while (!(SRLacM.Peek() == -1))
            {
                registroLacMod = SRLacM.ReadLine();
                vectorLacM = registroLacMod.Split(';');
                nombre = vectorLacM[1];
                apellido = vectorLacM[2];
                if ((nombre == txtModificarM.Text) || (apellido == txtModificarM2.Text))
                {
                    registroLacMod = txtLegajoAl.Text + ";" + txtNombreAl.Text + ";" + txtApellidoAl.Text + ";" + cmbAñosAl.Text + ";" + cmbMesesAl.Text + ";" + cmbSexoAl.Text + ";" + cmbTurnoAl.Text + ";" + rdbComedorNoAl.Text + ";" + rdbHermanosNoAl.Text + ";" + "Pagada";

                }
                

                SWLacM.WriteLine(registroLacMod);
            }
            SRLacM.Close();
            SWLacM.Close();
            FSLacAuxM.Close();
            FSLacM.Close();
            File.Delete("D:/Lactarios.txt");
            File.Move("D:/LactariosAux.txt", "D:/Lactarios.txt");
            ShowLactariosAl();

            lblLegajoAl.Hide();
            txtLegajoAl.Hide();
            lblNombreAl.Hide();
            txtNombreAl.Hide();
            lblApellidoAl.Hide();
            txtApellidoAl.Hide();
            lblAñosAl.Hide();
            cmbAñosAl.Hide();
            lblMesesAl.Hide();
            cmbMesesAl.Hide();
            lblSexoAl.Hide();
            cmbSexoAl.Hide();
            lblTurnoAl.Hide();
            cmbTurnoAl.Hide();

            lblComedorAl.Hide();
            gpbComedorAl.Hide();
            lblHermanosAl.Hide();
            gpbHermanosAl.Hide();
            btnModificarLac.Hide();
        }

        private void btnModificarD1_Click(object sender, EventArgs e)
        {
            Inscripcion insAl = new Inscripcion();
            insAl.lblLegajo.Text = txtLegajoAl.Text;
            insAl.txtNombre = txtNombreAl;
            insAl.txtApellido = txtApellidoAl;
            insAl.cmbAños = cmbAñosAl;
            insAl.cmbMeses = cmbMesesAl;
            insAl.cmbSexo = cmbSexoAl;
            insAl.cmbTurno = cmbTurnoAl;
            insAl.rdbComedorNo = rdbComedorNoAl;
            insAl.rdbComedorSi = rdbComedorSiAl;
            insAl.rdbHermanosNo = rdbHermanosNoAl;
            insAl.rdbHermanosSi = rdbHermanosSiAl;

            FileStream FSD1M = new FileStream("D:/Deambuladores 1.txt", FileMode.Open);
            FileStream FSD1AuxM = new FileStream("D:/Deambuladores1Aux.txt", FileMode.Create);
            StreamReader SRD1M = new StreamReader(FSD1M);
            StreamWriter SWD1M = new StreamWriter(FSD1AuxM);
            string[] vectorD1M;
            string nombre, apellido;
            string registroD1Mod;
            while (!(SRD1M.Peek() == -1))
            {
                registroD1Mod = SRD1M.ReadLine();
                vectorD1M = registroD1Mod.Split(';');
                nombre = vectorD1M[1];
                apellido = vectorD1M[2];
                if ((nombre == txtModificarM.Text) || (apellido == txtModificarM2.Text))
                {
                    registroD1Mod = txtLegajoAl.Text + ";" + txtNombreAl.Text + ";" + txtApellidoAl.Text + ";" + cmbAñosAl.Text + ";" + cmbMesesAl.Text + ";" + cmbSexoAl.Text + ";" + cmbTurnoAl.Text + ";" + rdbComedorNoAl.Text + ";" + rdbHermanosNoAl.Text + ";" + "Pagada";

                }
                

                SWD1M.WriteLine(registroD1Mod);
            }
            SRD1M.Close();
            SWD1M.Close();
            FSD1AuxM.Close();
            FSD1M.Close();
            File.Delete("D:/Deambuladores 1.txt");
            File.Move("D:/Deambuladores1Aux.txt", "D:/Deambuladores 1.txt");
            ShowDeambuladores1Al();

            lblLegajoAl.Hide();
            txtLegajoAl.Hide();
            lblNombreAl.Hide();
            txtNombreAl.Hide();
            lblApellidoAl.Hide();
            txtApellidoAl.Hide();
            lblAñosAl.Hide();
            cmbAñosAl.Hide();
            lblMesesAl.Hide();
            cmbMesesAl.Hide();
            lblSexoAl.Hide();
            cmbSexoAl.Hide();
            lblTurnoAl.Hide();
            cmbTurnoAl.Hide();

            lblComedorAl.Hide();
            gpbComedorAl.Hide();
            lblHermanosAl.Hide();
            gpbHermanosAl.Hide();
            btnModificarLac.Hide();
        }

        private void btnModificarD2_Click(object sender, EventArgs e)
        {
            Inscripcion insAl = new Inscripcion();
            insAl.lblLegajo.Text = txtLegajoAl.Text;
            insAl.txtNombre = txtNombreAl;
            insAl.txtApellido = txtApellidoAl;
            insAl.cmbAños = cmbAñosAl;
            insAl.cmbMeses = cmbMesesAl;
            insAl.cmbSexo = cmbSexoAl;
            insAl.cmbTurno = cmbTurnoAl;
            insAl.rdbComedorNo = rdbComedorNoAl;
            insAl.rdbComedorSi = rdbComedorSiAl;
            insAl.rdbHermanosNo = rdbHermanosNoAl;
            insAl.rdbHermanosSi = rdbHermanosSiAl;

            FileStream FSD2M = new FileStream("D:/Deambuladores 2.txt", FileMode.Open);
            FileStream FSD2AuxM = new FileStream("D:/Deambuladores2Aux.txt", FileMode.Create);
            StreamReader SRD2M = new StreamReader(FSD2M);
            StreamWriter SWD2M = new StreamWriter(FSD2AuxM);
            string[] vectorD2M;
            string nombre, apellido;
            string registroD2Mod;
            while (!(SRD2M.Peek() == -1))
            {
                registroD2Mod = SRD2M.ReadLine();
                vectorD2M = registroD2Mod.Split(';');
                nombre = vectorD2M[1];
                apellido = vectorD2M[2];
                if ((nombre == txtModificarM.Text) || (apellido == txtModificarM2.Text))
                {
                    registroD2Mod = txtLegajoAl.Text + ";" + txtNombreAl.Text + ";" + txtApellidoAl.Text + ";" + cmbAñosAl.Text + ";" + cmbMesesAl.Text + ";" + cmbSexoAl.Text + ";" + cmbTurnoAl.Text + ";" + rdbComedorNoAl.Text + ";" + rdbHermanosNoAl.Text + ";" + "Pagada";

                }
                

                SWD2M.WriteLine(registroD2Mod);
            }
            SRD2M.Close();
            SWD2M.Close();
            FSD2AuxM.Close();
            FSD2M.Close();
            File.Delete("D:/Deambuladores 2.txt");
            File.Move("D:/Deambuladores2Aux.txt", "D:/Deambuladores 2.txt");
            ShowDeambuladores2Al();

            lblLegajoAl.Hide();
            txtLegajoAl.Hide();
            lblNombreAl.Hide();
            txtNombreAl.Hide();
            lblApellidoAl.Hide();
            txtApellidoAl.Hide();
            lblAñosAl.Hide();
            cmbAñosAl.Hide();
            lblMesesAl.Hide();
            cmbMesesAl.Hide();
            lblSexoAl.Hide();
            cmbSexoAl.Hide();
            lblTurnoAl.Hide();
            cmbTurnoAl.Hide();

            lblComedorAl.Hide();
            gpbComedorAl.Hide();
            lblHermanosAl.Hide();
            gpbHermanosAl.Hide();
            btnModificarLac.Hide();
        }

        private void btnModificarS2_Click(object sender, EventArgs e)
        {
            Inscripcion insAl = new Inscripcion();
            insAl.lblLegajo.Text = txtLegajoAl.Text;
            insAl.txtNombre = txtNombreAl;
            insAl.txtApellido = txtApellidoAl;
            insAl.cmbAños = cmbAñosAl;
            insAl.cmbMeses = cmbMesesAl;
            insAl.cmbSexo = cmbSexoAl;
            insAl.cmbTurno = cmbTurnoAl;
            insAl.rdbComedorNo = rdbComedorNoAl;
            insAl.rdbComedorSi = rdbComedorSiAl;
            insAl.rdbHermanosNo = rdbHermanosNoAl;
            insAl.rdbHermanosSi = rdbHermanosSiAl;

            FileStream FSS2M = new FileStream("D:/SalaDe2.txt", FileMode.Open);
            FileStream FSS2AuxM = new FileStream("D:/SalaDe2Aux.txt", FileMode.Create);
            StreamReader SRS2M = new StreamReader(FSS2M);
            StreamWriter SWS2M = new StreamWriter(FSS2AuxM);
            string[] vectorS2M;
            string nombre, apellido;
            string registroS2Mod;
            while (!(SRS2M.Peek() == -1))
            {
                registroS2Mod = SRS2M.ReadLine();
                vectorS2M = registroS2Mod.Split(';');
                nombre = vectorS2M[1];
                apellido = vectorS2M[2];
                if ((nombre == txtModificarM.Text) || (apellido == txtModificarM2.Text))
                {
                    registroS2Mod = txtLegajoAl.Text + ";" + txtNombreAl.Text + ";" + txtApellidoAl.Text + ";" + cmbAñosAl.Text + ";" + cmbMesesAl.Text + ";" + cmbSexoAl.Text + ";" + cmbTurnoAl.Text + ";" + rdbComedorNoAl.Text + ";" + rdbHermanosNoAl.Text + ";" + "Pagada";

                }
                

                SWS2M.WriteLine(registroS2Mod);
            }
            SRS2M.Close();
            SWS2M.Close();
            FSS2AuxM.Close();
            FSS2M.Close();
            File.Delete("D:/SalaDe2.txt");
            File.Move("D:/SalaDe2Aux.txt", "D:/SalaDe2.txt");
            ShowSala2Al();

            lblLegajoAl.Hide();
            txtLegajoAl.Hide();
            lblNombreAl.Hide();
            txtNombreAl.Hide();
            lblApellidoAl.Hide();
            txtApellidoAl.Hide();
            lblAñosAl.Hide();
            cmbAñosAl.Hide();
            lblMesesAl.Hide();
            cmbMesesAl.Hide();
            lblSexoAl.Hide();
            cmbSexoAl.Hide();
            lblTurnoAl.Hide();
            cmbTurnoAl.Hide();

            lblComedorAl.Hide();
            gpbComedorAl.Hide();
            lblHermanosAl.Hide();
            gpbHermanosAl.Hide();
            btnModificarLac.Hide();
        }

        private void btnModificarS3_Click(object sender, EventArgs e)
        {
            Inscripcion insAl = new Inscripcion();
            insAl.lblLegajo.Text = txtLegajoAl.Text;
            insAl.txtNombre = txtNombreAl;
            insAl.txtApellido = txtApellidoAl;
            insAl.cmbAños = cmbAñosAl;
            insAl.cmbMeses = cmbMesesAl;
            insAl.cmbSexo = cmbSexoAl;
            insAl.cmbTurno = cmbTurnoAl;
            insAl.rdbComedorNo = rdbComedorNoAl;
            insAl.rdbComedorSi = rdbComedorSiAl;
            insAl.rdbHermanosNo = rdbHermanosNoAl;
            insAl.rdbHermanosSi = rdbHermanosSiAl;

            FileStream FSS3M = new FileStream("D:/SalaDe3.txt", FileMode.Open);
            FileStream FSS3AuxM = new FileStream("D:/SalaDe3Aux.txt", FileMode.Create);
            StreamReader SRS3M = new StreamReader(FSS3M);
            StreamWriter SWS3M = new StreamWriter(FSS3AuxM);
            string[] vectorS3M;
            string nombre, apellido;
            string registroS3Mod;
            while (!(SRS3M.Peek() == -1))
            {
                registroS3Mod = SRS3M.ReadLine();
                vectorS3M = registroS3Mod.Split(';');
                nombre = vectorS3M[1];
                apellido = vectorS3M[2];
                if ((nombre == txtModificarM.Text) || (apellido == txtModificarM2.Text))
                {
                    registroS3Mod = txtLegajoAl.Text + ";" + txtNombreAl.Text + ";" + txtApellidoAl.Text + ";" + cmbAñosAl.Text + ";" + cmbMesesAl.Text + ";" + cmbSexoAl.Text + ";" + cmbTurnoAl.Text + ";" + rdbComedorNoAl.Text + ";" + rdbHermanosNoAl.Text + ";" + "Pagada";

                }
                else if ((nombre != txtModificarM.Text) || (apellido != txtModificarM2.Text))
                {
                    MessageBox.Show("El Nombre o Apellido del Chico es incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                SWS3M.WriteLine(registroS3Mod);
            }
            SRS3M.Close();
            SWS3M.Close();
            FSS3AuxM.Close();
            FSS3M.Close();
            File.Delete("D:/SalaDe3.txt");
            File.Move("D:/SalaDe3Aux.txt", "D:/SalaDe3.txt");
            ShowSala3Al();

            lblLegajoAl.Hide();
            txtLegajoAl.Hide();
            lblNombreAl.Hide();
            txtNombreAl.Hide();
            lblApellidoAl.Hide();
            txtApellidoAl.Hide();
            lblAñosAl.Hide();
            cmbAñosAl.Hide();
            lblMesesAl.Hide();
            cmbMesesAl.Hide();
            lblSexoAl.Hide();
            cmbSexoAl.Hide();
            lblTurnoAl.Hide();
            cmbTurnoAl.Hide();

            lblComedorAl.Hide();
            gpbComedorAl.Hide();
            lblHermanosAl.Hide();
            gpbHermanosAl.Hide();
            btnModificarLac.Hide();
        }
    }
}

