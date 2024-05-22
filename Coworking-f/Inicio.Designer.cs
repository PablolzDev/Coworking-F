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
            groupBox1 = new GroupBox();
            txtContraseñaCliente = new TextBox();
            lblContraseñaCliente = new Label();
            txtCorreoCliente = new TextBox();
            lblCorreoCliente = new Label();
            groupBox2 = new GroupBox();
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
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtContraseñaCliente);
            groupBox1.Controls.Add(lblContraseñaCliente);
            groupBox1.Controls.Add(txtCorreoCliente);
            groupBox1.Controls.Add(lblCorreoCliente);
            groupBox1.Location = new Point(143, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(233, 288);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cliente";
            // 
            // txtContraseñaCliente
            // 
            txtContraseñaCliente.Location = new Point(48, 151);
            txtContraseñaCliente.Name = "txtContraseñaCliente";
            txtContraseñaCliente.Size = new Size(125, 27);
            txtContraseñaCliente.TabIndex = 3;
            // 
            // lblContraseñaCliente
            // 
            lblContraseñaCliente.AutoSize = true;
            lblContraseñaCliente.Location = new Point(48, 112);
            lblContraseñaCliente.Name = "lblContraseñaCliente";
            lblContraseñaCliente.Size = new Size(83, 20);
            lblContraseñaCliente.TabIndex = 2;
            lblContraseñaCliente.Text = "Contraseña";
            // 
            // txtCorreoCliente
            // 
            txtCorreoCliente.Location = new Point(48, 69);
            txtCorreoCliente.Name = "txtCorreoCliente";
            txtCorreoCliente.Size = new Size(125, 27);
            txtCorreoCliente.TabIndex = 1;
            // 
            // lblCorreoCliente
            // 
            lblCorreoCliente.AutoSize = true;
            lblCorreoCliente.Location = new Point(48, 37);
            lblCorreoCliente.Name = "lblCorreoCliente";
            lblCorreoCliente.Size = new Size(54, 20);
            lblCorreoCliente.TabIndex = 0;
            lblCorreoCliente.Text = "Correo";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtContraseñaAdmin);
            groupBox2.Controls.Add(lblContraseñaAdmin);
            groupBox2.Controls.Add(txtIDAdmin);
            groupBox2.Controls.Add(lblIDAdmin);
            groupBox2.Controls.Add(txtCorreoAdmin);
            groupBox2.Controls.Add(lblCorreoAdmin);
            groupBox2.Location = new Point(427, 45);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(241, 288);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Administrador";
            // 
            // txtContraseñaAdmin
            // 
            txtContraseñaAdmin.Location = new Point(53, 235);
            txtContraseñaAdmin.Name = "txtContraseñaAdmin";
            txtContraseñaAdmin.Size = new Size(125, 27);
            txtContraseñaAdmin.TabIndex = 5;
            // 
            // lblContraseñaAdmin
            // 
            lblContraseñaAdmin.AutoSize = true;
            lblContraseñaAdmin.Location = new Point(53, 200);
            lblContraseñaAdmin.Name = "lblContraseñaAdmin";
            lblContraseñaAdmin.Size = new Size(83, 20);
            lblContraseñaAdmin.TabIndex = 4;
            lblContraseñaAdmin.Text = "Contraseña";
            // 
            // txtIDAdmin
            // 
            txtIDAdmin.Location = new Point(53, 151);
            txtIDAdmin.Name = "txtIDAdmin";
            txtIDAdmin.Size = new Size(125, 27);
            txtIDAdmin.TabIndex = 3;
            // 
            // lblIDAdmin
            // 
            lblIDAdmin.AutoSize = true;
            lblIDAdmin.Location = new Point(53, 112);
            lblIDAdmin.Name = "lblIDAdmin";
            lblIDAdmin.Size = new Size(24, 20);
            lblIDAdmin.TabIndex = 2;
            lblIDAdmin.Text = "ID";
            // 
            // txtCorreoAdmin
            // 
            txtCorreoAdmin.Location = new Point(53, 69);
            txtCorreoAdmin.Name = "txtCorreoAdmin";
            txtCorreoAdmin.Size = new Size(125, 27);
            txtCorreoAdmin.TabIndex = 1;
            // 
            // lblCorreoAdmin
            // 
            lblCorreoAdmin.AutoSize = true;
            lblCorreoAdmin.Location = new Point(53, 37);
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
            btnContinuar.Location = new Point(479, 364);
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
            crearPerfilToolStripMenuItem.Size = new Size(224, 26);
            crearPerfilToolStripMenuItem.Text = "Crear Perfil";
            crearPerfilToolStripMenuItem.Click += crearPerfilToolStripMenuItem_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 504);
            Controls.Add(btnContinuar);
            Controls.Add(btnRegistro);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Name = "Inicio";
            Text = "Inicio";
            Load += Inicio_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtContraseñaCliente;
        private Label lblContraseñaCliente;
        private TextBox txtCorreoCliente;
        private Label lblCorreoCliente;
        private GroupBox groupBox2;
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
    }
}