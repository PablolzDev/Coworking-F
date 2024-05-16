namespace Coworking_f
{
    partial class Registro
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblIdentificacion = new Label();
            txtIdentificacion = new TextBox();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            lblContraseña = new Label();
            txtContraseña = new TextBox();
            btnCrearPerfilCliente = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(210, 56);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(210, 89);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 1;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(488, 56);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(488, 89);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 27);
            txtApellido.TabIndex = 3;
            // 
            // lblIdentificacion
            // 
            lblIdentificacion.AutoSize = true;
            lblIdentificacion.Location = new Point(210, 151);
            lblIdentificacion.Name = "lblIdentificacion";
            lblIdentificacion.Size = new Size(99, 20);
            lblIdentificacion.TabIndex = 4;
            lblIdentificacion.Text = "Identificación";
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(210, 178);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(125, 27);
            txtIdentificacion.TabIndex = 5;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(488, 151);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(54, 20);
            lblCorreo.TabIndex = 6;
            lblCorreo.Text = "Correo";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(489, 178);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(125, 27);
            txtCorreo.TabIndex = 7;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(210, 236);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(83, 20);
            lblContraseña.TabIndex = 8;
            lblContraseña.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(210, 268);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(125, 27);
            txtContraseña.TabIndex = 9;
            // 
            // btnCrearPerfilCliente
            // 
            btnCrearPerfilCliente.Location = new Point(348, 342);
            btnCrearPerfilCliente.Name = "btnCrearPerfilCliente";
            btnCrearPerfilCliente.Size = new Size(141, 41);
            btnCrearPerfilCliente.TabIndex = 10;
            btnCrearPerfilCliente.Text = "Crear Perfil";
            btnCrearPerfilCliente.UseVisualStyleBackColor = true;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCrearPerfilCliente);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblApellido);
            Controls.Add(txtContraseña);
            Controls.Add(txtCorreo);
            Controls.Add(lblContraseña);
            Controls.Add(txtApellido);
            Controls.Add(txtIdentificacion);
            Controls.Add(lblCorreo);
            Controls.Add(lblIdentificacion);
            Name = "Registro";
            Text = "Registro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblIdentificacion;
        private TextBox txtIdentificacion;
        private Label lblCorreo;
        private TextBox txtCorreo;
        private Label lblContraseña;
        private TextBox txtContraseña;
        private Button btnCrearPerfilCliente;
    }
}