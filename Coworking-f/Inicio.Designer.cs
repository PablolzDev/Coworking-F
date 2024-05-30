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
            txtContraseñaAdmin = new TextBox();
            lblContraseñaAdmin = new Label();
            txtIDAdmin = new TextBox();
            lblIDAdmin = new Label();
            txtCorreoAdmin = new TextBox();
            lblCorreoAdmin = new Label();
            btnRegistro = new Button();
            btnContinuar = new Button();
            menuStrip1 = new MenuStrip();
            aunNoTienesToolStripMenuItem = new ToolStripMenuItem();
            crearPerfilToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtContraseñaCliente
            // 
            txtContraseñaCliente.Location = new Point(155, 198);
            txtContraseñaCliente.Name = "txtContraseñaCliente";
            txtContraseñaCliente.Size = new Size(125, 27);
            txtContraseñaCliente.TabIndex = 3;
            // 
            // lblContraseñaCliente
            // 
            lblContraseñaCliente.AutoSize = true;
            lblContraseñaCliente.Location = new Point(155, 159);
            lblContraseñaCliente.Name = "lblContraseñaCliente";
            lblContraseñaCliente.Size = new Size(83, 20);
            lblContraseñaCliente.TabIndex = 2;
            lblContraseñaCliente.Text = "Contraseña";
            // 
            // txtCorreoCliente
            // 
            txtCorreoCliente.Location = new Point(155, 116);
            txtCorreoCliente.Name = "txtCorreoCliente";
            txtCorreoCliente.Size = new Size(125, 27);
            txtCorreoCliente.TabIndex = 1;
            // 
            // lblCorreoCliente
            // 
            lblCorreoCliente.AutoSize = true;
            lblCorreoCliente.Location = new Point(155, 84);
            lblCorreoCliente.Name = "lblCorreoCliente";
            lblCorreoCliente.Size = new Size(54, 20);
            lblCorreoCliente.TabIndex = 0;
            lblCorreoCliente.Text = "Correo";
            // 
            // txtContraseñaAdmin
            // 
            txtContraseñaAdmin.Location = new Point(428, 282);
            txtContraseñaAdmin.Name = "txtContraseñaAdmin";
            txtContraseñaAdmin.Size = new Size(125, 27);
            txtContraseñaAdmin.TabIndex = 5;
            // 
            // lblContraseñaAdmin
            // 
            lblContraseñaAdmin.AutoSize = true;
            lblContraseñaAdmin.Location = new Point(428, 247);
            lblContraseñaAdmin.Name = "lblContraseñaAdmin";
            lblContraseñaAdmin.Size = new Size(83, 20);
            lblContraseñaAdmin.TabIndex = 4;
            lblContraseñaAdmin.Text = "Contraseña";
            // 
            // txtIDAdmin
            // 
            txtIDAdmin.Location = new Point(428, 198);
            txtIDAdmin.Name = "txtIDAdmin";
            txtIDAdmin.Size = new Size(125, 27);
            txtIDAdmin.TabIndex = 3;
            // 
            // lblIDAdmin
            // 
            lblIDAdmin.AutoSize = true;
            lblIDAdmin.Location = new Point(428, 159);
            lblIDAdmin.Name = "lblIDAdmin";
            lblIDAdmin.Size = new Size(24, 20);
            lblIDAdmin.TabIndex = 2;
            lblIDAdmin.Text = "ID";
            // 
            // txtCorreoAdmin
            // 
            txtCorreoAdmin.Location = new Point(428, 116);
            txtCorreoAdmin.Name = "txtCorreoAdmin";
            txtCorreoAdmin.Size = new Size(125, 27);
            txtCorreoAdmin.TabIndex = 1;
            // 
            // lblCorreoAdmin
            // 
            lblCorreoAdmin.AutoSize = true;
            lblCorreoAdmin.Location = new Point(428, 84);
            lblCorreoAdmin.Name = "lblCorreoAdmin";
            lblCorreoAdmin.Size = new Size(54, 20);
            lblCorreoAdmin.TabIndex = 0;
            lblCorreoAdmin.Text = "Correo";
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
            btnContinuar.Location = new Point(418, 395);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(125, 35);
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
            menuStrip1.Size = new Size(800, 28);
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
            pictureBox1.Image = Properties.Resources.LogoProyectoFinal;
            pictureBox1.Location = new Point(665, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 504);
            Controls.Add(txtContraseñaCliente);
            Controls.Add(txtContraseñaAdmin);
            Controls.Add(lblContraseñaCliente);
            Controls.Add(pictureBox1);
            Controls.Add(txtCorreoCliente);
            Controls.Add(lblContraseñaAdmin);
            Controls.Add(lblCorreoCliente);
            Controls.Add(btnContinuar);
            Controls.Add(txtIDAdmin);
            Controls.Add(btnRegistro);
            Controls.Add(lblIDAdmin);
            Controls.Add(txtCorreoAdmin);
            Controls.Add(lblCorreoAdmin);
            Controls.Add(menuStrip1);
            Name = "Inicio";
            Text = "Inicio";
            Load += Inicio_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtContraseñaCliente;
        private Label lblContraseñaCliente;
        private TextBox txtCorreoCliente;
        private Label lblCorreoCliente;
        private Label lblContraseñaAdmin;
        private TextBox txtIDAdmin;
        private Label lblIDAdmin;
        private TextBox txtCorreoAdmin;
        private Label lblCorreoAdmin;
        private TextBox txtContraseñaAdmin;
        private Button btnRegistro;
        private Button btnContinuar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aunNoTienesToolStripMenuItem;
        private ToolStripMenuItem crearPerfilToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}