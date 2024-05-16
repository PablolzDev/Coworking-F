namespace Coworking_f
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            lblCorreoCliente = new Label();
            txtCorreoCliente = new TextBox();
            lblContraseñaCliente = new Label();
            txtContraseña = new TextBox();
            groupBox2 = new GroupBox();
            lblCorreoAdmin = new Label();
            txtCorreoAdmin = new TextBox();
            lblIdAdmin = new Label();
            txtIDAdmin = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtContraseña);
            groupBox1.Controls.Add(lblContraseñaCliente);
            groupBox1.Controls.Add(txtCorreoCliente);
            groupBox1.Controls.Add(lblCorreoCliente);
            groupBox1.Location = new Point(141, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(247, 281);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cliente";
            // 
            // lblCorreoCliente
            // 
            lblCorreoCliente.AutoSize = true;
            lblCorreoCliente.Location = new Point(55, 63);
            lblCorreoCliente.Name = "lblCorreoCliente";
            lblCorreoCliente.Size = new Size(54, 20);
            lblCorreoCliente.TabIndex = 0;
            lblCorreoCliente.Text = "Correo";
            // 
            // txtCorreoCliente
            // 
            txtCorreoCliente.Location = new Point(58, 100);
            txtCorreoCliente.Name = "txtCorreoCliente";
            txtCorreoCliente.Size = new Size(125, 27);
            txtCorreoCliente.TabIndex = 1;
            // 
            // lblContraseñaCliente
            // 
            lblContraseñaCliente.AutoSize = true;
            lblContraseñaCliente.Location = new Point(61, 162);
            lblContraseñaCliente.Name = "lblContraseñaCliente";
            lblContraseñaCliente.Size = new Size(83, 20);
            lblContraseñaCliente.TabIndex = 2;
            lblContraseñaCliente.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(57, 197);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(125, 27);
            txtContraseña.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtIDAdmin);
            groupBox2.Controls.Add(lblIdAdmin);
            groupBox2.Controls.Add(txtCorreoAdmin);
            groupBox2.Controls.Add(lblCorreoAdmin);
            groupBox2.Location = new Point(418, 52);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(240, 281);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // lblCorreoAdmin
            // 
            lblCorreoAdmin.AutoSize = true;
            lblCorreoAdmin.Location = new Point(36, 41);
            lblCorreoAdmin.Name = "lblCorreoAdmin";
            lblCorreoAdmin.Size = new Size(54, 20);
            lblCorreoAdmin.TabIndex = 0;
            lblCorreoAdmin.Text = "Correo";
            // 
            // txtCorreoAdmin
            // 
            txtCorreoAdmin.Location = new Point(41, 84);
            txtCorreoAdmin.Name = "txtCorreoAdmin";
            txtCorreoAdmin.Size = new Size(125, 27);
            txtCorreoAdmin.TabIndex = 1;
            // 
            // lblIdAdmin
            // 
            lblIdAdmin.AutoSize = true;
            lblIdAdmin.Location = new Point(48, 133);
            lblIdAdmin.Name = "lblIdAdmin";
            lblIdAdmin.Size = new Size(24, 20);
            lblIdAdmin.TabIndex = 2;
            lblIdAdmin.Text = "ID";
            // 
            // txtIDAdmin
            // 
            txtIDAdmin.Location = new Point(49, 159);
            txtIDAdmin.Name = "txtIDAdmin";
            txtIDAdmin.Size = new Size(125, 27);
            txtIDAdmin.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtContraseña;
        private Label lblContraseñaCliente;
        private TextBox txtCorreoCliente;
        private Label lblCorreoCliente;
        private GroupBox groupBox2;
        private TextBox txtIDAdmin;
        private Label lblIdAdmin;
        private TextBox txtCorreoAdmin;
        private Label lblCorreoAdmin;
    }
}
