namespace Coworking_f
{
    partial class Inicio
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
            txtContraseñaCliente = new TextBox();
            lblContraseñaCliente = new Label();
            txtCorreoCliente = new TextBox();
            lblCorreoCliente = new Label();
            btnRegistro = new Button();
            btnContinuar = new Button();
            menuStrip1 = new MenuStrip();
            aunNoTienesToolStripMenuItem = new ToolStripMenuItem();
            crearPerfilToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            groupBox1 = new GroupBox();
            txtCorreoAdmin = new TextBox();
            lblIDAdmin = new Label();
            txtIDAdmin = new TextBox();
            lblContraseñaAdmin = new Label();
            txtContraseñaAdmin = new TextBox();
            lblCorreoAdmin = new Label();
            groupBox2 = new GroupBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtContraseñaCliente
            // 
            txtContraseñaCliente.Location = new Point(27, 164);
            txtContraseñaCliente.Name = "txtContraseñaCliente";
            txtContraseñaCliente.Size = new Size(125, 27);
            txtContraseñaCliente.TabIndex = 3;
            // 
            // lblContraseñaCliente
            // 
            lblContraseñaCliente.AutoSize = true;
            lblContraseñaCliente.ForeColor = SystemColors.ActiveCaptionText;
            lblContraseñaCliente.Location = new Point(27, 123);
            lblContraseñaCliente.Name = "lblContraseñaCliente";
            lblContraseñaCliente.Size = new Size(83, 20);
            lblContraseñaCliente.TabIndex = 2;
            lblContraseñaCliente.Text = "Contraseña";
            // 
            // txtCorreoCliente
            // 
            txtCorreoCliente.Location = new Point(27, 66);
            txtCorreoCliente.Name = "txtCorreoCliente";
            txtCorreoCliente.Size = new Size(125, 27);
            txtCorreoCliente.TabIndex = 1;
            // 
            // lblCorreoCliente
            // 
            lblCorreoCliente.AutoSize = true;
            lblCorreoCliente.ForeColor = SystemColors.ActiveCaptionText;
            lblCorreoCliente.Location = new Point(27, 23);
            lblCorreoCliente.Name = "lblCorreoCliente";
            lblCorreoCliente.Size = new Size(54, 20);
            lblCorreoCliente.TabIndex = 0;
            lblCorreoCliente.Text = "Correo";
            // 
            // btnRegistro
            // 
            btnRegistro.Location = new Point(778, 31);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(10, 10);
            btnRegistro.TabIndex = 2;
            btnRegistro.Text = "Registrarse";
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // btnContinuar
            // 
            btnContinuar.ForeColor = SystemColors.ActiveCaptionText;
            btnContinuar.Location = new Point(290, 384);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(150, 66);
            btnContinuar.TabIndex = 3;
            btnContinuar.Text = "Continuar";
            btnContinuar.UseVisualStyleBackColor = true;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aunNoTienesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(805, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // aunNoTienesToolStripMenuItem
            // 
            aunNoTienesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearPerfilToolStripMenuItem });
            aunNoTienesToolStripMenuItem.Name = "aunNoTienesToolStripMenuItem";
            aunNoTienesToolStripMenuItem.Size = new Size(190, 24);
            aunNoTienesToolStripMenuItem.Text = " ¿Aun no tienes un perfil?";
            // 
            // crearPerfilToolStripMenuItem
            // 
            crearPerfilToolStripMenuItem.Name = "crearPerfilToolStripMenuItem";
            crearPerfilToolStripMenuItem.Size = new Size(164, 26);
            crearPerfilToolStripMenuItem.Text = "Crear Perfil";
            crearPerfilToolStripMenuItem.Click += crearPerfilToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LogoHerramientas;
            pictureBox1.Location = new Point(665, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ReformaFondo;
            pictureBox2.Location = new Point(4, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(796, 483);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.ReformaFondo1;
            groupBox1.Controls.Add(lblCorreoAdmin);
            groupBox1.Controls.Add(txtCorreoAdmin);
            groupBox1.Controls.Add(txtContraseñaAdmin);
            groupBox1.Controls.Add(lblIDAdmin);
            groupBox1.Controls.Add(txtIDAdmin);
            groupBox1.Controls.Add(lblContraseñaAdmin);
            groupBox1.Location = new Point(399, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(203, 283);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Administrador";
            // 
            // txtCorreoAdmin
            // 
            txtCorreoAdmin.Location = new Point(33, 66);
            txtCorreoAdmin.Name = "txtCorreoAdmin";
            txtCorreoAdmin.Size = new Size(125, 27);
            txtCorreoAdmin.TabIndex = 1;
            // 
            // lblIDAdmin
            // 
            lblIDAdmin.AutoSize = true;
            lblIDAdmin.ForeColor = SystemColors.ActiveCaptionText;
            lblIDAdmin.Location = new Point(33, 113);
            lblIDAdmin.Name = "lblIDAdmin";
            lblIDAdmin.Size = new Size(24, 20);
            lblIDAdmin.TabIndex = 2;
            lblIDAdmin.Text = "ID";
            // 
            // txtIDAdmin
            // 
            txtIDAdmin.Location = new Point(33, 145);
            txtIDAdmin.Name = "txtIDAdmin";
            txtIDAdmin.Size = new Size(125, 27);
            txtIDAdmin.TabIndex = 3;
            // 
            // lblContraseñaAdmin
            // 
            lblContraseñaAdmin.AutoSize = true;
            lblContraseñaAdmin.ForeColor = SystemColors.ActiveCaptionText;
            lblContraseñaAdmin.Location = new Point(33, 190);
            lblContraseñaAdmin.Name = "lblContraseñaAdmin";
            lblContraseñaAdmin.Size = new Size(83, 20);
            lblContraseñaAdmin.TabIndex = 4;
            lblContraseñaAdmin.Text = "Contraseña";
            // 
            // txtContraseñaAdmin
            // 
            txtContraseñaAdmin.Location = new Point(33, 235);
            txtContraseñaAdmin.Name = "txtContraseñaAdmin";
            txtContraseñaAdmin.Size = new Size(125, 27);
            txtContraseñaAdmin.TabIndex = 5;
            // 
            // lblCorreoAdmin
            // 
            lblCorreoAdmin.AutoSize = true;
            lblCorreoAdmin.ForeColor = SystemColors.ActiveCaptionText;
            lblCorreoAdmin.Location = new Point(33, 30);
            lblCorreoAdmin.Name = "lblCorreoAdmin";
            lblCorreoAdmin.Size = new Size(54, 20);
            lblCorreoAdmin.TabIndex = 0;
            lblCorreoAdmin.Text = "Correo";
            // 
            // groupBox2
            // 
            groupBox2.BackgroundImage = Properties.Resources.ReformaFondo;
            groupBox2.Controls.Add(lblCorreoCliente);
            groupBox2.Controls.Add(txtCorreoCliente);
            groupBox2.Controls.Add(txtContraseñaCliente);
            groupBox2.Controls.Add(lblContraseñaCliente);
            groupBox2.Location = new Point(114, 73);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(206, 283);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cliente";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 518);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(btnContinuar);
            Controls.Add(btnRegistro);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox2);
            ForeColor = SystemColors.ButtonShadow;
            Name = "Inicio";
            Text = "Inicio";
            Load += Inicio_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtContraseñaCliente;
        private Label lblContraseñaCliente;
        private TextBox txtCorreoCliente;
        private Label lblCorreoCliente;
        private Button btnRegistro;
        private Button btnContinuar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aunNoTienesToolStripMenuItem;
        private ToolStripMenuItem crearPerfilToolStripMenuItem;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private GroupBox groupBox1;
        private Label lblCorreoAdmin;
        private TextBox txtCorreoAdmin;
        private TextBox txtContraseñaAdmin;
        private Label lblIDAdmin;
        private TextBox txtIDAdmin;
        private Label lblContraseñaAdmin;
        private GroupBox groupBox2;
    }
}