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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(189, 65);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(189, 98);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 1;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(467, 65);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(468, 98);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 27);
            txtApellido.TabIndex = 3;
            // 
            // lblIdentificacion
            // 
            lblIdentificacion.AutoSize = true;
            lblIdentificacion.Location = new Point(189, 160);
            lblIdentificacion.Name = "lblIdentificacion";
            lblIdentificacion.Size = new Size(99, 20);
            lblIdentificacion.TabIndex = 4;
            lblIdentificacion.Text = "Identificación";
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(189, 188);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(125, 27);
            txtIdentificacion.TabIndex = 5;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(467, 160);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(54, 20);
            lblCorreo.TabIndex = 6;
            lblCorreo.Text = "Correo";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(468, 188);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(125, 27);
            txtCorreo.TabIndex = 7;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(189, 245);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(83, 20);
            lblContraseña.TabIndex = 8;
            lblContraseña.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(189, 277);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(125, 27);
            txtContraseña.TabIndex = 9;
            // 
            // btnCrearPerfilCliente
            // 
            btnCrearPerfilCliente.Location = new Point(326, 361);
            btnCrearPerfilCliente.Name = "btnCrearPerfilCliente";
            btnCrearPerfilCliente.Size = new Size(141, 41);
            btnCrearPerfilCliente.TabIndex = 10;
            btnCrearPerfilCliente.Text = "Crear Perfil";
            btnCrearPerfilCliente.UseVisualStyleBackColor = true;
            btnCrearPerfilCliente.Click += btnCrearPerfilCliente_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LogoHerramientas;
            pictureBox1.Location = new Point(665, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ReformaFondo1;
            pictureBox2.Location = new Point(5, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(785, 465);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 483);
            Controls.Add(pictureBox1);
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
            Controls.Add(pictureBox2);
            Name = "Registro";
            Text = "Registro";
            Load += Registro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}