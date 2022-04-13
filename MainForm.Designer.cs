
namespace Segundo_Parcial_Programacion
{
    partial class MainForm
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
            this.btnLogo = new FontAwesome.Sharp.IconButton();
            this.btnInscribir = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.btnAlumnos = new FontAwesome.Sharp.IconButton();
            this.btnMaestras = new FontAwesome.Sharp.IconButton();
            this.btnSalas = new FontAwesome.Sharp.IconButton();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelTitleBar = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.IconCurrentForm = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelMenu.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentForm)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.PanelMenu.Controls.Add(this.btnLogo);
            this.PanelMenu.Controls.Add(this.btnInscribir);
            this.PanelMenu.Controls.Add(this.btnSalir);
            this.PanelMenu.Controls.Add(this.btnAlumnos);
            this.PanelMenu.Controls.Add(this.btnMaestras);
            this.PanelMenu.Controls.Add(this.btnSalas);
            this.PanelMenu.Controls.Add(this.PanelLogo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(230, 679);
            this.PanelMenu.TabIndex = 1;
            // 
            // btnLogo
            // 
            this.btnLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogo.IconChar = FontAwesome.Sharp.IconChar.School;
            this.btnLogo.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogo.Location = new System.Drawing.Point(12, 486);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(200, 162);
            this.btnLogo.TabIndex = 2;
            this.btnLogo.Text = "Jardin de Infantes System";
            this.btnLogo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogo.UseVisualStyleBackColor = false;
            // 
            // btnInscribir
            // 
            this.btnInscribir.FlatAppearance.BorderSize = 0;
            this.btnInscribir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInscribir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.btnInscribir.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnInscribir.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.btnInscribir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInscribir.IconSize = 32;
            this.btnInscribir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInscribir.Location = new System.Drawing.Point(0, 206);
            this.btnInscribir.Name = "btnInscribir";
            this.btnInscribir.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnInscribir.Size = new System.Drawing.Size(254, 60);
            this.btnInscribir.TabIndex = 1;
            this.btnInscribir.Text = "Inscripción ";
            this.btnInscribir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInscribir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInscribir.UseVisualStyleBackColor = true;
            this.btnInscribir.Click += new System.EventHandler(this.btnInscribir_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnSalir.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 32;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(-3, 406);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSalir.Size = new System.Drawing.Size(254, 60);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir ";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.FlatAppearance.BorderSize = 0;
            this.btnAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlumnos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.btnAlumnos.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnAlumnos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.btnAlumnos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAlumnos.IconSize = 32;
            this.btnAlumnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlumnos.Location = new System.Drawing.Point(0, 274);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAlumnos.Size = new System.Drawing.Size(254, 60);
            this.btnAlumnos.TabIndex = 1;
            this.btnAlumnos.Text = "Alumnos";
            this.btnAlumnos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlumnos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlumnos.UseVisualStyleBackColor = true;
            this.btnAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click);
            // 
            // btnMaestras
            // 
            this.btnMaestras.FlatAppearance.BorderSize = 0;
            this.btnMaestras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaestras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnMaestras.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            this.btnMaestras.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnMaestras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaestras.IconSize = 32;
            this.btnMaestras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaestras.Location = new System.Drawing.Point(-3, 340);
            this.btnMaestras.Name = "btnMaestras";
            this.btnMaestras.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMaestras.Size = new System.Drawing.Size(257, 60);
            this.btnMaestras.TabIndex = 1;
            this.btnMaestras.Text = "Maestras";
            this.btnMaestras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaestras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaestras.UseVisualStyleBackColor = true;
            this.btnMaestras.Click += new System.EventHandler(this.btnMaestras_Click);
            // 
            // btnSalas
            // 
            this.btnSalas.FlatAppearance.BorderSize = 0;
            this.btnSalas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnSalas.IconChar = FontAwesome.Sharp.IconChar.School;
            this.btnSalas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnSalas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalas.IconSize = 32;
            this.btnSalas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalas.Location = new System.Drawing.Point(0, 140);
            this.btnSalas.Name = "btnSalas";
            this.btnSalas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSalas.Size = new System.Drawing.Size(254, 60);
            this.btnSalas.TabIndex = 1;
            this.btnSalas.Text = "Salas";
            this.btnSalas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalas.UseVisualStyleBackColor = true;
            this.btnSalas.Click += new System.EventHandler(this.btnSalas_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.Controls.Add(this.pictureBox1);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(230, 140);
            this.PanelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Segundo_Parcial_Programacion.Properties.Resources.Logo_Escuela;
            this.pictureBox1.Location = new System.Drawing.Point(36, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PanelTitleBar
            // 
            this.PanelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.PanelTitleBar.Controls.Add(this.lblFormTitle);
            this.PanelTitleBar.Controls.Add(this.IconCurrentForm);
            this.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitleBar.Location = new System.Drawing.Point(230, 0);
            this.PanelTitleBar.Name = "PanelTitleBar";
            this.PanelTitleBar.Size = new System.Drawing.Size(662, 87);
            this.PanelTitleBar.TabIndex = 2;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFormTitle.Location = new System.Drawing.Point(61, 26);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(52, 20);
            this.lblFormTitle.TabIndex = 1;
            this.lblFormTitle.Text = "Home";
            // 
            // IconCurrentForm
            // 
            this.IconCurrentForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.IconCurrentForm.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.IconCurrentForm.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconCurrentForm.IconSize = 45;
            this.IconCurrentForm.Location = new System.Drawing.Point(20, 21);
            this.IconCurrentForm.Name = "IconCurrentForm";
            this.IconCurrentForm.Size = new System.Drawing.Size(45, 48);
            this.IconCurrentForm.TabIndex = 0;
            this.IconCurrentForm.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(230, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 592);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Segundo_Parcial_Programacion.Properties.Resources.Logo_Escuela;
            this.pictureBox2.Location = new System.Drawing.Point(155, 176);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(368, 340);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(280, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Jardín de Infantes System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(122, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bienvenido A";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 679);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelTitleBar);
            this.Controls.Add(this.PanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.PanelMenu.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelTitleBar.ResumeLayout(false);
            this.PanelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentForm)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelMenu;
        private FontAwesome.Sharp.IconButton btnInscribir;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnAlumnos;
        private FontAwesome.Sharp.IconButton btnMaestras;
        private FontAwesome.Sharp.IconButton btnSalas;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelTitleBar;
        private System.Windows.Forms.Label lblFormTitle;
        private FontAwesome.Sharp.IconPictureBox IconCurrentForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton btnLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}