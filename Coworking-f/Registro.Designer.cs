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
            lblNombre.Location = new Point(184, 42);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(184, 67);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(110, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(427, 42);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(427, 67);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(110, 23);
            txtApellido.TabIndex = 3;
            // 
            // lblIdentificacion
            // 
            lblIdentificacion.AutoSize = true;
            lblIdentificacion.Location = new Point(184, 113);
            lblIdentificacion.Name = "lblIdentificacion";
            lblIdentificacion.Size = new Size(79, 15);
            lblIdentificacion.TabIndex = 4;
            lblIdentificacion.Text = "Identificación";
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(184, 134);
            txtIdentificacion.Margin = new Padding(3, 2, 3, 2);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(110, 23);
            txtIdentificacion.TabIndex = 5;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(427, 113);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(43, 15);
            lblCorreo.TabIndex = 6;
            lblCorreo.Text = "Correo";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(428, 134);
            txtCorreo.Margin = new Padding(3, 2, 3, 2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(110, 23);
            txtCorreo.TabIndex = 7;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(184, 177);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(67, 15);
            lblContraseña.TabIndex = 8;
            lblContraseña.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(184, 201);
            txtContraseña.Margin = new Padding(3, 2, 3, 2);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(110, 23);
            txtContraseña.TabIndex = 9;
            // 
            // btnCrearPerfilCliente
            // 
            btnCrearPerfilCliente.Location = new Point(304, 264);
            btnCrearPerfilCliente.Margin = new Padding(3, 2, 3, 2);
            btnCrearPerfilCliente.Name = "btnCrearPerfilCliente";
            btnCrearPerfilCliente.Size = new Size(123, 31);
            btnCrearPerfilCliente.TabIndex = 10;
            btnCrearPerfilCliente.Text = "Crear Perfil";
            btnCrearPerfilCliente.UseVisualStyleBackColor = true;
            btnCrearPerfilCliente.Click += btnCrearPerfilCliente_Click;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 362);
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
            Margin = new Padding(3, 2, 3, 2);
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