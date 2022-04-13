
namespace Segundo_Parcial_Programacion
{
    partial class Inscripcion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.btnHomeI = new System.Windows.Forms.Button();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblStarting = new System.Windows.Forms.Label();
            this.lblNombreI = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellidoI = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblEdadI = new System.Windows.Forms.Label();
            this.lblSexoI = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.lblTurnoI = new System.Windows.Forms.Label();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.btnInscribirse = new System.Windows.Forms.Button();
            this.lblHnos = new System.Windows.Forms.Label();
            this.cmbAños = new System.Windows.Forms.ComboBox();
            this.cmbMeses = new System.Windows.Forms.ComboBox();
            this.lblAños = new System.Windows.Forms.Label();
            this.lblMeses = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.lblComedor = new System.Windows.Forms.Label();
            this.gpbHermanos = new System.Windows.Forms.GroupBox();
            this.rdbHermanosNo = new System.Windows.Forms.RadioButton();
            this.rdbHermanosSi = new System.Windows.Forms.RadioButton();
            this.gpbComedor = new System.Windows.Forms.GroupBox();
            this.rdbComedorNo = new System.Windows.Forms.RadioButton();
            this.rdbComedorSi = new System.Windows.Forms.RadioButton();
            this.PanelMenu.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpbHermanos.SuspendLayout();
            this.gpbComedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.PanelMenu.Controls.Add(this.btnHomeI);
            this.PanelMenu.Controls.Add(this.PanelLogo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(177, 761);
            this.PanelMenu.TabIndex = 2;
            // 
            // btnHomeI
            // 
            this.btnHomeI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnHomeI.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHomeI.Location = new System.Drawing.Point(12, 688);
            this.btnHomeI.Name = "btnHomeI";
            this.btnHomeI.Size = new System.Drawing.Size(148, 58);
            this.btnHomeI.TabIndex = 18;
            this.btnHomeI.Text = "Home";
            this.btnHomeI.UseVisualStyleBackColor = false;
            this.btnHomeI.Click += new System.EventHandler(this.btnHomeI_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.Controls.Add(this.pictureBox1);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(177, 140);
            this.PanelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Segundo_Parcial_Programacion.Properties.Resources.Logo_Escuela;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblStarting
            // 
            this.lblStarting.AutoSize = true;
            this.lblStarting.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStarting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.lblStarting.Location = new System.Drawing.Point(286, 24);
            this.lblStarting.Name = "lblStarting";
            this.lblStarting.Size = new System.Drawing.Size(405, 45);
            this.lblStarting.TabIndex = 3;
            this.lblStarting.Text = "Jardín de Infantes System";
            // 
            // lblNombreI
            // 
            this.lblNombreI.AutoSize = true;
            this.lblNombreI.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.lblNombreI.Location = new System.Drawing.Point(207, 85);
            this.lblNombreI.Name = "lblNombreI";
            this.lblNombreI.Size = new System.Drawing.Size(98, 30);
            this.lblNombreI.TabIndex = 4;
            this.lblNombreI.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(212, 130);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(243, 34);
            this.txtNombre.TabIndex = 5;
            // 
            // lblApellidoI
            // 
            this.lblApellidoI.AutoSize = true;
            this.lblApellidoI.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.lblApellidoI.Location = new System.Drawing.Point(499, 85);
            this.lblApellidoI.Name = "lblApellidoI";
            this.lblApellidoI.Size = new System.Drawing.Size(99, 30);
            this.lblApellidoI.TabIndex = 6;
            this.lblApellidoI.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(504, 130);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(243, 34);
            this.txtApellido.TabIndex = 7;
            // 
            // lblEdadI
            // 
            this.lblEdadI.AutoSize = true;
            this.lblEdadI.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdadI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.lblEdadI.Location = new System.Drawing.Point(207, 190);
            this.lblEdadI.Name = "lblEdadI";
            this.lblEdadI.Size = new System.Drawing.Size(65, 30);
            this.lblEdadI.TabIndex = 8;
            this.lblEdadI.Text = "Edad";
            // 
            // lblSexoI
            // 
            this.lblSexoI.AutoSize = true;
            this.lblSexoI.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexoI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.lblSexoI.Location = new System.Drawing.Point(499, 190);
            this.lblSexoI.Name = "lblSexoI";
            this.lblSexoI.Size = new System.Drawing.Size(62, 30);
            this.lblSexoI.TabIndex = 10;
            this.lblSexoI.Text = "Sexo";
            // 
            // cmbSexo
            // 
            this.cmbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbSexo.Location = new System.Drawing.Point(504, 236);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(243, 37);
            this.cmbSexo.TabIndex = 11;
            // 
            // lblTurnoI
            // 
            this.lblTurnoI.AutoSize = true;
            this.lblTurnoI.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnoI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.lblTurnoI.Location = new System.Drawing.Point(207, 324);
            this.lblTurnoI.Name = "lblTurnoI";
            this.lblTurnoI.Size = new System.Drawing.Size(72, 30);
            this.lblTurnoI.TabIndex = 12;
            this.lblTurnoI.Text = "Turno";
            // 
            // cmbTurno
            // 
            this.cmbTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Items.AddRange(new object[] {
            "Mañana",
            "Tarde",
            "Doble "});
            this.cmbTurno.Location = new System.Drawing.Point(212, 368);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(243, 37);
            this.cmbTurno.TabIndex = 13;
            this.cmbTurno.SelectedIndexChanged += new System.EventHandler(this.cmbTurno_SelectedIndexChanged);
            // 
            // btnInscribirse
            // 
            this.btnInscribirse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnInscribirse.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInscribirse.Location = new System.Drawing.Point(454, 688);
            this.btnInscribirse.Name = "btnInscribirse";
            this.btnInscribirse.Size = new System.Drawing.Size(171, 64);
            this.btnInscribirse.TabIndex = 17;
            this.btnInscribirse.Text = "Inscribir";
            this.btnInscribirse.UseVisualStyleBackColor = false;
            this.btnInscribirse.Click += new System.EventHandler(this.btnInscribirse_Click);
            // 
            // lblHnos
            // 
            this.lblHnos.AutoSize = true;
            this.lblHnos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHnos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.lblHnos.Location = new System.Drawing.Point(470, 324);
            this.lblHnos.Name = "lblHnos";
            this.lblHnos.Size = new System.Drawing.Size(299, 25);
            this.lblHnos.TabIndex = 18;
            this.lblHnos.Text = "Tiene hnos en el establecimiento?";
            // 
            // cmbAños
            // 
            this.cmbAños.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAños.FormattingEnabled = true;
            this.cmbAños.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cmbAños.Location = new System.Drawing.Point(212, 236);
            this.cmbAños.Name = "cmbAños";
            this.cmbAños.Size = new System.Drawing.Size(93, 37);
            this.cmbAños.TabIndex = 19;
            // 
            // cmbMeses
            // 
            this.cmbMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMeses.FormattingEnabled = true;
            this.cmbMeses.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.cmbMeses.Location = new System.Drawing.Point(321, 236);
            this.cmbMeses.Name = "cmbMeses";
            this.cmbMeses.Size = new System.Drawing.Size(93, 37);
            this.cmbMeses.TabIndex = 20;
            // 
            // lblAños
            // 
            this.lblAños.AutoSize = true;
            this.lblAños.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAños.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.lblAños.Location = new System.Drawing.Point(214, 276);
            this.lblAños.Name = "lblAños";
            this.lblAños.Size = new System.Drawing.Size(55, 25);
            this.lblAños.TabIndex = 21;
            this.lblAños.Text = "Años";
            // 
            // lblMeses
            // 
            this.lblMeses.AutoSize = true;
            this.lblMeses.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.lblMeses.Location = new System.Drawing.Point(318, 276);
            this.lblMeses.Name = "lblMeses";
            this.lblMeses.Size = new System.Drawing.Size(65, 25);
            this.lblMeses.TabIndex = 22;
            this.lblMeses.Text = "Meses";
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegajo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.lblLegajo.Location = new System.Drawing.Point(207, 36);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(26, 30);
            this.lblLegajo.TabIndex = 23;
            this.lblLegajo.Text = "1";
            // 
            // lblComedor
            // 
            this.lblComedor.AutoSize = true;
            this.lblComedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.lblComedor.Location = new System.Drawing.Point(207, 466);
            this.lblComedor.Name = "lblComedor";
            this.lblComedor.Size = new System.Drawing.Size(140, 25);
            this.lblComedor.TabIndex = 26;
            this.lblComedor.Text = "Irá a Comedor?";
            // 
            // gpbHermanos
            // 
            this.gpbHermanos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.gpbHermanos.Controls.Add(this.rdbHermanosNo);
            this.gpbHermanos.Controls.Add(this.rdbHermanosSi);
            this.gpbHermanos.Location = new System.Drawing.Point(593, 368);
            this.gpbHermanos.Name = "gpbHermanos";
            this.gpbHermanos.Size = new System.Drawing.Size(200, 132);
            this.gpbHermanos.TabIndex = 27;
            this.gpbHermanos.TabStop = false;
            // 
            // rdbHermanosNo
            // 
            this.rdbHermanosNo.AutoSize = true;
            this.rdbHermanosNo.ForeColor = System.Drawing.Color.Gainsboro;
            this.rdbHermanosNo.Location = new System.Drawing.Point(6, 80);
            this.rdbHermanosNo.Name = "rdbHermanosNo";
            this.rdbHermanosNo.Size = new System.Drawing.Size(54, 24);
            this.rdbHermanosNo.TabIndex = 1;
            this.rdbHermanosNo.TabStop = true;
            this.rdbHermanosNo.Text = "No";
            this.rdbHermanosNo.UseVisualStyleBackColor = true;
            // 
            // rdbHermanosSi
            // 
            this.rdbHermanosSi.AutoSize = true;
            this.rdbHermanosSi.ForeColor = System.Drawing.Color.Gainsboro;
            this.rdbHermanosSi.Location = new System.Drawing.Point(6, 25);
            this.rdbHermanosSi.Name = "rdbHermanosSi";
            this.rdbHermanosSi.Size = new System.Drawing.Size(48, 24);
            this.rdbHermanosSi.TabIndex = 0;
            this.rdbHermanosSi.TabStop = true;
            this.rdbHermanosSi.Text = "Si";
            this.rdbHermanosSi.UseVisualStyleBackColor = true;
            this.rdbHermanosSi.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // gpbComedor
            // 
            this.gpbComedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.gpbComedor.Controls.Add(this.rdbComedorNo);
            this.gpbComedor.Controls.Add(this.rdbComedorSi);
            this.gpbComedor.Location = new System.Drawing.Point(262, 517);
            this.gpbComedor.Name = "gpbComedor";
            this.gpbComedor.Size = new System.Drawing.Size(200, 123);
            this.gpbComedor.TabIndex = 28;
            this.gpbComedor.TabStop = false;
            // 
            // rdbComedorNo
            // 
            this.rdbComedorNo.AutoSize = true;
            this.rdbComedorNo.ForeColor = System.Drawing.Color.Gainsboro;
            this.rdbComedorNo.Location = new System.Drawing.Point(16, 76);
            this.rdbComedorNo.Name = "rdbComedorNo";
            this.rdbComedorNo.Size = new System.Drawing.Size(54, 24);
            this.rdbComedorNo.TabIndex = 3;
            this.rdbComedorNo.TabStop = true;
            this.rdbComedorNo.Text = "No";
            this.rdbComedorNo.UseVisualStyleBackColor = true;
            // 
            // rdbComedorSi
            // 
            this.rdbComedorSi.AutoSize = true;
            this.rdbComedorSi.ForeColor = System.Drawing.Color.Gainsboro;
            this.rdbComedorSi.Location = new System.Drawing.Point(16, 25);
            this.rdbComedorSi.Name = "rdbComedorSi";
            this.rdbComedorSi.Size = new System.Drawing.Size(48, 24);
            this.rdbComedorSi.TabIndex = 2;
            this.rdbComedorSi.TabStop = true;
            this.rdbComedorSi.Text = "Si";
            this.rdbComedorSi.UseVisualStyleBackColor = true;
            // 
            // Inscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 761);
            this.Controls.Add(this.gpbComedor);
            this.Controls.Add(this.gpbHermanos);
            this.Controls.Add(this.lblComedor);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.lblMeses);
            this.Controls.Add(this.lblAños);
            this.Controls.Add(this.cmbMeses);
            this.Controls.Add(this.cmbAños);
            this.Controls.Add(this.lblHnos);
            this.Controls.Add(this.btnInscribirse);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.lblTurnoI);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.lblSexoI);
            this.Controls.Add(this.lblEdadI);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellidoI);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombreI);
            this.Controls.Add(this.lblStarting);
            this.Controls.Add(this.PanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inscripcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscripcion";
            this.Load += new System.EventHandler(this.Inscripcion_Load);
            this.PanelMenu.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpbHermanos.ResumeLayout(false);
            this.gpbHermanos.PerformLayout();
            this.gpbComedor.ResumeLayout(false);
            this.gpbComedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblStarting;
        private System.Windows.Forms.Label lblNombreI;
        private System.Windows.Forms.Label lblApellidoI;
        private System.Windows.Forms.Label lblEdadI;
        private System.Windows.Forms.Label lblSexoI;
        private System.Windows.Forms.Label lblTurnoI;
        private System.Windows.Forms.Button btnInscribirse;
        private System.Windows.Forms.Button btnHomeI;
        private System.Windows.Forms.Label lblHnos;
        private System.Windows.Forms.Label lblAños;
        private System.Windows.Forms.Label lblMeses;
        private System.Windows.Forms.Label lblComedor;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtApellido;
        public System.Windows.Forms.ComboBox cmbSexo;
        public System.Windows.Forms.ComboBox cmbTurno;
        public System.Windows.Forms.ComboBox cmbAños;
        public System.Windows.Forms.ComboBox cmbMeses;
        public System.Windows.Forms.Label lblLegajo;
        public System.Windows.Forms.GroupBox gpbHermanos;
        public System.Windows.Forms.RadioButton rdbHermanosNo;
        public System.Windows.Forms.RadioButton rdbHermanosSi;
        public System.Windows.Forms.GroupBox gpbComedor;
        public System.Windows.Forms.RadioButton rdbComedorNo;
        public System.Windows.Forms.RadioButton rdbComedorSi;
    }
}