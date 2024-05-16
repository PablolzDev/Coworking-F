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
            groupBox2 = new GroupBox();
            lblCorreoCliente = new Label();
            txtCorreoCliente = new TextBox();
            lblContraseñaCliente = new Label();
            txtContraseñaCliente = new TextBox();
            lblCorreoAdmin = new Label();
            txtCorreoAdmin = new TextBox();
            lblIDAdmin = new Label();
            txtIDAdmin = new TextBox();
            lblContraseñaAdmin = new Label();
            txtContraseñaAdmin = new TextBox();
            btnRegistro = new Button();
            btnContinuar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtContraseñaCliente);
            groupBox1.Controls.Add(lblContraseñaCliente);
            groupBox1.Controls.Add(txtCorreoCliente);
            groupBox1.Controls.Add(lblCorreoCliente);
            groupBox1.Location = new Point(143, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(233, 288);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtContraseñaAdmin);
            groupBox2.Controls.Add(lblContraseñaAdmin);
            groupBox2.Controls.Add(txtIDAdmin);
            groupBox2.Controls.Add(lblIDAdmin);
            groupBox2.Controls.Add(txtCorreoAdmin);
            groupBox2.Controls.Add(lblCorreoAdmin);
            groupBox2.Location = new Point(427, 46);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(241, 288);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
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
            // txtCorreoCliente
            // 
            txtCorreoCliente.Location = new Point(48, 69);
            txtCorreoCliente.Name = "txtCorreoCliente";
            txtCorreoCliente.Size = new Size(125, 27);
            txtCorreoCliente.TabIndex = 1;
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
            // txtContraseñaCliente
            // 
            txtContraseñaCliente.Location = new Point(48, 151);
            txtContraseñaCliente.Name = "txtContraseñaCliente";
            txtContraseñaCliente.Size = new Size(125, 27);
            txtContraseñaCliente.TabIndex = 3;
            // 
            // lblCorreoAdmin
            // 
            lblCorreoAdmin.AutoSize = true;
            lblCorreoAdmin.Location = new Point(52, 37);
            lblCorreoAdmin.Name = "lblCorreoAdmin";
            lblCorreoAdmin.Size = new Size(54, 20);
            lblCorreoAdmin.TabIndex = 0;
            lblCorreoAdmin.Text = "Correo";
            // 
            // txtCorreoAdmin
            // 
            txtCorreoAdmin.Location = new Point(52, 69);
            txtCorreoAdmin.Name = "txtCorreoAdmin";
            txtCorreoAdmin.Size = new Size(125, 27);
            txtCorreoAdmin.TabIndex = 1;
            // 
            // lblIDAdmin
            // 
            lblIDAdmin.AutoSize = true;
            lblIDAdmin.Location = new Point(52, 112);
            lblIDAdmin.Name = "lblIDAdmin";
            lblIDAdmin.Size = new Size(24, 20);
            lblIDAdmin.TabIndex = 2;
            lblIDAdmin.Text = "ID";
            // 
            // txtIDAdmin
            // 
            txtIDAdmin.Location = new Point(52, 151);
            txtIDAdmin.Name = "txtIDAdmin";
            txtIDAdmin.Size = new Size(125, 27);
            txtIDAdmin.TabIndex = 3;
            // 
            // lblContraseñaAdmin
            // 
            lblContraseñaAdmin.AutoSize = true;
            lblContraseñaAdmin.Location = new Point(52, 200);
            lblContraseñaAdmin.Name = "lblContraseñaAdmin";
            lblContraseñaAdmin.Size = new Size(83, 20);
            lblContraseñaAdmin.TabIndex = 4;
            lblContraseñaAdmin.Text = "Contraseña";
            // 
            // txtContraseñaAdmin
            // 
            txtContraseñaAdmin.Location = new Point(52, 235);
            txtContraseñaAdmin.Name = "txtContraseñaAdmin";
            txtContraseñaAdmin.Size = new Size(125, 27);
            txtContraseñaAdmin.TabIndex = 5;
            // 
            // btnRegistro
            // 
            btnRegistro.Location = new Point(191, 364);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(125, 38);
            btnRegistro.TabIndex = 2;
            btnRegistro.Text = "Registrarse";
            btnRegistro.UseVisualStyleBackColor = true;
            // 
            // btnContinuar
            // 
            btnContinuar.Location = new Point(479, 364);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(125, 34);
            btnContinuar.TabIndex = 3;
            btnContinuar.Text = "Continuar";
            btnContinuar.UseVisualStyleBackColor = true;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnContinuar);
            Controls.Add(btnRegistro);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Inicio";
            Text = "Inicio";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
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
    }
}