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
    public partial class Inscripcion : Form
    {
        public Inscripcion()
        {
            InitializeComponent();
        }

        private void Inscripcion_Load(object sender, EventArgs e)
        {
            gpbComedor.Hide();
            lblComedor.Hide();
        }

        private void btnHomeI_Click(object sender, EventArgs e)
        {
            MainForm home = new MainForm();
            home.Show();
            this.Close();
        }
        int counterLegajo;
        private void btnInscribirse_Click(object sender, EventArgs e)
        {
          
            counterLegajo++;
            lblLegajo.Text = counterLegajo.ToString();
            int años;
            int meses;
            años = int.Parse(cmbAños.Text);
            meses = int.Parse(cmbMeses.Text);


                if (años == 0 && meses <= 9)
                {
                    FileStream FSLac = new FileStream("D:/Lactarios.txt", FileMode.Append);
                    StreamWriter SWLac = new StreamWriter(FSLac);
                    string registroLac;
                    if ((cmbTurno.Text == "Mañana") || (cmbTurno.Text == "Tarde"))
                    {
                        if (rdbHermanosSi.Checked)
                        {
                            registroLac = lblLegajo.Text + ";" + txtNombre.Text + ";" + txtApellido.Text + ";" + cmbAños.Text + ";" + cmbMeses.Text + ";" + cmbSexo.Text + ";" + cmbTurno.Text + ";" + rdbComedorNo.Text + ";" + rdbHermanosSi.Text + ";" + 7200;
                            SWLac.WriteLine(registroLac);
                        }
                        else if (rdbHermanosNo.Checked)
                        {
                            registroLac = lblLegajo.Text + ";" + txtNombre.Text + ";" + txtApellido.Text + ";" + cmbAños.Text + ";" + cmbMeses.Text + ";" + cmbSexo.Text + ";" + cmbTurno.Text + ";" + rdbComedorNo.Text + ";" + rdbHermanosNo.Text + ";" + 12000;
                            SWLac.WriteLine(registroLac);
                        }
                    }
                    else if (cmbTurno.SelectedIndex == 2)
                    {
                        if (rdbHermanosSi.Checked)
                        {
                            if (rdbComedorNo.Checked)
                            {
                                registroLac = lblLegajo.Text + ";" + txtNombre.Text + ";" + txtApellido.Text + ";" + cmbAños.Text + ";" + cmbMeses.Text + ";" + cmbSexo.Text + ";" + cmbTurno.Text + ";" + rdbComedorNo.Text + ";" + rdbHermanosSi.Text + ";" + 12600;
                                SWLac.WriteLine(registroLac);
                            }
                            else if (rdbComedorSi.Checked)
                            {
                                registroLac = lblLegajo.Text + ";" + txtNombre.Text + ";" + txtApellido.Text + ";" + cmbAños.Text + ";" + cmbMeses.Text + ";" + cmbSexo.Text + ";" + cmbTurno.Text + ";" + rdbComedorSi.Text + ";" + rdbHermanosSi.Text + ";" + 15000;
                                SWLac.WriteLine(registroLac);
                            }

                        }
                        else if (rdbHermanosNo.Checked)
                        {
                            if (rdbComedorNo.Checked)
                            {
                                registroLac = lblLegajo.Text + ";" + txtNombre.Text + ";" + txtApellido.Text + ";" + cmbAños.Text + ";" + cmbMeses.Text + ";" + cmbSexo.Text + ";" + cmbTurno.Text + ";" + rdbComedorNo.Text + ";" + rdbHermanosNo.Text + ";" + 21000;
                                SWLac.WriteLine(registroLac);
                            }
                            else if (rdbComedorSi.Checked)
                            {
                                registroLac = lblLegajo.Text + ";" + txtNombre.Text + ";" + txtApellido.Text + ";" + cmbAños.Text + ";" + cmbMeses.Text + ";" + cmbSexo.Text + ";" + cmbTurno.Text + ";" + rdbComedorSi.Text + ";" + rdbHermanosNo.Text + ";" + 25000;
                                SWLac.WriteLine(registroLac);
                            }
                        }
                    }



                    SWLac.Close();
                    FSLac.Close();
                    //Void Listar Lactarios
                }
            
           

            if ((años == 0 && meses > 9) || (años == 1 && meses > 0) && (años == 1 && meses <= 6))
            {
                FileStream FSD1 = new FileStream("D:/Deambuladores 1.txt", FileMode.Append);
                StreamWriter SWD1 = new StreamWriter(FSD1);
                string registroD1;
                if ((cmbTurno.Text == "Mañana") || (cmbTurno.Text == "Tarde"))
                {
                    if (rdbHermanosSi.Checked)
                    {
                        registroD1 = lblLegajo.Text + ";" + txtNombre.Text + ";" + txtApellido.Text + ";" + cmbAños.Text + ";" + cmbMeses.Text + ";" + cmbSexo.Text + ";" + cmbTurno.Text + ";" + rdbComedorNo.Text + ";" + rdbHermanosSi.Text + ";" + 7200;
                        SWD1.WriteLine(registroD1);
                    }
                    else if (rdbHermanosNo.Checked)
                    {
                        registroD1 = lblLegajo.Text + ";" + txtNombre.Text + ";" + txtApellido.Text + ";" + cmbAños.Text + ";" + cmbMeses.Text + ";" + cmbSexo.Text + ";" + cmbTurno.Text + ";" + rdbComedorNo.Text + ";" + rdbHermanosNo.Text + ";" + 12000;
                        SWD1.WriteLine(registroD1);
                    }
                }
                else if (cmbTurno.SelectedIndex == 2)
                {
                    if (rdbHermanosSi.Checked)
                    {
                        if (rdbComedorNo.Checked)
                        {
                            registroD1 = lblLegajo.Text + ";" + txtNombre.Text + ";" + txtApellido.Text + ";" + cmbAños.Text + ";" + cmbMeses.Text + ";" + cmbSexo.Text + ";" + cmbTurno.Text + ";" + rdbComedorNo.Text + ";" + rdbHermanosSi.Text + ";" + 12600;
                            SWD1.WriteLine(registroD1);
                        }
                        else if (rdbComedorSi.Checked)
                        {
                            registroD1 = lblLegajo.Text + ";" + txtNombre.Text + ";" + txtApellido.Text + ";" + cmbAños.Text + ";" + cmbMeses.Text + ";" + cmbSexo.Text + ";" + cmbTurno.Text + ";" + rdbComedorSi.Text + ";" + rdbHermanosSi.Text + ";" + 15000;
                            SWD1.WriteLine(registroD1);
                        }

                    }
                    else if (rdbHermanosNo.Checked)
                    {
                        if (rdbComedorNo.Checked)
                        {
                            registroD1 = lblLegajo.Text + ";" + txtNombre.Text + ";" + txtApellido.Text + ";" + cmbAños.Text + ";" + cmbMeses.Text + ";" + cmbSexo.Text + ";" + cmbTurno.Text + ";" + rdbComedorNo.Text + ";" + rdbHermanosNo.Text + ";" + 21000;
                            SWD1.WriteLine(registroD1);
                        }
                        else if (rdbComedorSi.Checked)
                        {
                            registroD1 = lblLegajo.Text + ";" + txtNombre.Text + ";" + txtApellido.Text + ";" + cmbAños.Text + ";" + cmbMeses.Text + ";" + cmbSexo.Text + ";" + cmbTurno.Text + ";" + rdbComedorSi.Text + ";" + rdbHermanosNo.Text + ";" + 25000;
                            SWD1.WriteLine(registroD1);
                        }
                    }
                }
                SWD1.Close();
                FSD1.Close();
                //Void Listar Deambuladores1
            }

            if ((años == 1 && meses > 6) && (años == 1 && meses <= 11))
            {
                FileStream FSD2 = new FileStream("D:/Deambuladores 2.txt", FileMode.Append);
                StreamWriter SWD2 = new StreamWriter(FSD2);
                string registroD2;
                if ((cmbTurno.Text == "Mañana") || (cmbTurno.Text == "Tarde"))
                {
                    if (rdbHermanosSi.Checked)
                    {
                        registroD2 = lblLegajo.Text + ";" + txtNombre.Text + ";" + txtApellido.Text + ";" + cmbAños.Text + ";" + cmbMeses.Text + ";" + cmbSexo.Text + ";" + cmbTurno.Text + ";" + rdbComedorNo.Text + ";" + rdbHermanosSi.Text + ";" + 7200;
                        SWD2.WriteLine(registroD2);
                    }
                    else if (rdbHermanosNo.Checked)
                    {
                        registroD2 = lblLegajo.Text + ";" + txtNombre.Text + ";" + txtApellido.Text + ";" + cmbAños.Text + ";" + cmbMeses.Text + ";" + cmbSexo.Text + ";" + cmbTurno.Text + ";" + rdbComedorNo.Text + ";" + rdbHermanosNo.Text + ";" + 12000;
                        SWD2.WriteLine(registroD2);
                    }
                }
                else if (cmbTurno.SelectedIndex == 2)
                {
                    if (rdbHermanosSi.Checked)
                    {
                        if (rdbComedorNo.Checked)
                        {
                            registroD2 = lblLegajo.Text + ";" + txtNombre.Text + ";" + txtApellido.Text + ";" + cmbAños.Text + ";" + cmbMeses.Text + ";" + cmbSexo.Text + ";" + cmbTurno.Text + ";" + rdbComedorNo.Text + ";" + rdbHermanosSi.Text + ";" + 12600;
                            SWD2.WriteLine(registroD2);
                        }
                        else if (rdbComedorSi.Checked)
                        {
                            registroD2 = lblLegajo.Text + ";" + txtNombre.Text + ";" + txtApellido.Text + ";" + cmbAños.Text + ";" + cmbMeses.Text + ";" + cmbSexo.Text + ";" + cmbTurno.Text + ";" + rdbComedorSi.Text + ";" + rdbHermanosSi.Text + ";" + 15000;
                            SWD2.WriteLine(registroD2);
                        }

                    }
                    else if (rdbHermanosNo.Checked)
                    {
                        if (rdbComedorNo.Checked)
                        {
                            registroD2 = lblLegajo.Text + ";" + txtNombre.Text + ";" + txtApellido.Text + ";" + cmbAños.Text + ";" + cmbMeses.Text + ";" + cmbSexo.Text + ";" + cmbTurno.Text + ";" + rdbComedorNo.Text + ";" + rdbHermanosNo.Text + ";" + 21000;
                            SWD2.WriteLine(registroD2);
                        }
                        else if (rdbComedorSi.Checked)
                        {
                            registroD2 = lblLegajo.Text + ";" + txtNombre.Text + ";" + txtApellido.Text + ";" + cmbAños.Text + ";" + cmbMeses.Text + ";" + cmbSexo.Text + ";" + cmbTurno.Text + ";" + rdbComedorSi.Text + ";" + rdbHermanosNo.Text + ";" + 25000;
                            SWD2.WriteLine(registroD2);
                        }
                    }
                }
                
                SWD2.Close();
                FSD2.Close();
                //Void Listar Deambuladores2
            }

            if (años == 2 && meses < 11)
            {
                FileStream FSS2 = new FileStream("D:/SalaDe2.txt", FileMode.Append);
                StreamWriter SWS2 = new StreamWriter(FSS2);
                string registroS2;
                if ((cmbTurno.Text == "Mañana") || (cmbTurno.Text == "Tarde"))
                {
                    if (rdbHermanosSi.Checked)
                    {
                        registroS2 = lblLegajo.Text + ";" + txtNombre.Text + ";" + txtApellido.Text + ";" + cmbAños.Text + ";" + cmbMeses.Text + ";" + cmbSexo.Text + ";" + cmbTurno.Text + ";" + rdbComedorNo.Text + ";" + rdbHermanosSi.Text + ";" + 7200;
                        SWS2.WriteLine(registroS2);
                    }
                    else if (rdbHermanosNo.Checked)
                    {
                        registroS2 = lblLegajo.Text + ";" + txtNombre.Text + ";" + txtApellido.Text + ";" + cmbAños.Text + ";" + cmbMeses.Text + ";" + cmbSexo.Text + ";" + cmbTurno.Text + ";" + rdbComedorNo.Text + ";" + rdbHermanosNo.Text + ";" + 12000;
                        SWS2.WriteLine(registroS2);
                    }
                }
                else if (cmbTurno.SelectedIndex == 2)
                {
                    if (rdbHermanosSi.Checked)
                    {
                        if (rdbComedorNo.Checked)
                        {
                            registroS2 = lblLegajo.Text + ";" + txtNombre.Text + ";" + txtApellido.Text + ";" + cmbAños.Text + ";" + cmbMeses.Text + ";" + cmbSexo.Text + ";" + cmbTurno.Text + ";" + rdbComedorNo.Text + ";" + rdbHermanosSi.Text + ";" + 12600;
                            SWS2.WriteLine(registroS2);
                        }
                        else if (rdbComedorSi.Checked)
                        {
                            registroS2 = lblLegajo.Text + ";" + txtNombre.Text + ";" + txtApellido.Text + ";" + cmbAños.Text + ";" + cmbMeses.Text + ";" + cmbSexo.Text + ";" + cmbTurno.Text + ";" + rdbComedorSi.Text + ";" + rdbHermanosSi.Text + ";" + 15000;
                            SWS2.WriteLine(registroS2);
                        }

                    }
                    else if (rdbHermanosNo.Checked)
                    {
                        if (rdbComedorNo.Checked)
                        {
                            registroS2 = lblLegajo.Text + ";" + txtNombre.Text + ";" + txtApellido.Text + ";" + cmbAños.Text + ";" + cmbMeses.Text + ";" + cmbSexo.Text + ";" + cmbTurno.Text + ";" + rdbComedorNo.Text + ";" + rdbHermanosNo.Text + ";" + 21000;
                            SWS2.WriteLine(registroS2);
                        }
                        else if (rdbComedorSi.Checked)
                        {
                            registroS2 = lblLegajo.Text + ";" + txtNombre.Text + ";" + txtApellido.Text + ";" + cmbAños.Text + ";" + cmbMeses.Text + ";" + cmbSexo.Text + ";" + cmbTurno.Text + ";" + rdbComedorSi.Text + ";" + rdbHermanosNo.Text + ";" + 25000;
                            SWS2.WriteLine(registroS2);
                        }
                    }
                }
                
                SWS2.Close();
                FSS2.Close();
                //Void Listar Sala de 2
            }

            if (años == 3 && meses < 11)
            {
                FileStream FSS3 = new FileStream("D:/SalaDe3.txt", FileMode.Append);
                StreamWriter SWS3 = new StreamWriter(FSS3);
                string registroS3;
                if ((cmbTurno.Text == "Mañana") || (cmbTurno.Text == "Tarde"))
                {
                    if (rdbHermanosSi.Checked)
                    {
                        registroS3 = lblLegajo.Text + ";" + txtNombre.Text + ";" + txtApellido.Text + ";" + cmbAños.Text + ";" + cmbMeses.Text + ";" + cmbSexo.Text + ";" + cmbTurno.Text + ";" + rdbComedorNo.Text + ";" + rdbHermanosSi.Text + ";" + 7200;
                        SWS3.WriteLine(registroS3);
                    }
                    else if (rdbHermanosNo.Checked)
                    {
                        registroS3 = lblLegajo.Text + ";" + txtNombre.Text + ";" + txtApellido.Text + ";" + cmbAños.Text + ";" + cmbMeses.Text + ";" + cmbSexo.Text + ";" + cmbTurno.Text + ";" + rdbComedorNo.Text + ";" + rdbHermanosNo.Text + ";" + 12000;
                        SWS3.WriteLine(registroS3);
                    }
                }
                else if (cmbTurno.SelectedIndex == 2)
                {
                    if (rdbHermanosSi.Checked)
                    {
                        if (rdbComedorNo.Checked)
                        {
                            registroS3 = lblLegajo.Text + ";" + txtNombre.Text + ";" + txtApellido.Text + ";" + cmbAños.Text + ";" + cmbMeses.Text + ";" + cmbSexo.Text + ";" + cmbTurno.Text + ";" + rdbComedorNo.Text + ";" + rdbHermanosSi.Text + ";" + 12600;
                            SWS3.WriteLine(registroS3);
                        }
                        else if (rdbComedorSi.Checked)
                        {
                            registroS3 = lblLegajo.Text + ";" + txtNombre.Text + ";" + txtApellido.Text + ";" + cmbAños.Text + ";" + cmbMeses.Text + ";" + cmbSexo.Text + ";" + cmbTurno.Text + ";" + rdbComedorSi.Text + ";" + rdbHermanosSi.Text + ";" + 15000;
                            SWS3.WriteLine(registroS3);
                        }

                    }
                    else if (rdbHermanosNo.Checked)
                    {
                        if (rdbComedorNo.Checked)
                        {
                            registroS3 = lblLegajo.Text + ";" + txtNombre.Text + ";" + txtApellido.Text + ";" + cmbAños.Text + ";" + cmbMeses.Text + ";" + cmbSexo.Text + ";" + cmbTurno.Text + ";" + rdbComedorNo.Text + ";" + rdbHermanosNo.Text + ";" + 21000;
                            SWS3.WriteLine(registroS3);
                        }
                        else if (rdbComedorSi.Checked)
                        {
                            registroS3 = lblLegajo.Text + ";" + txtNombre.Text + ";" + txtApellido.Text + ";" + cmbAños.Text + ";" + cmbMeses.Text + ";" + cmbSexo.Text + ";" + cmbTurno.Text + ";" + rdbComedorSi.Text + ";" + rdbHermanosNo.Text + ";" + 25000;
                            SWS3.WriteLine(registroS3);
                        }
                    }
                }
                
                SWS3.Close();
                FSS3.Close();
                //Void Listar Sala de 3
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmbTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cmbTurno.SelectedIndex == 0) || (cmbTurno.SelectedIndex == 1))
            {
                gpbComedor.Hide();
            }
            else if (cmbTurno.SelectedIndex == 2)
            {
                lblComedor.Show();
                gpbComedor.Show();
            }
        }
    }
}
