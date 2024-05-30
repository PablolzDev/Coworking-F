namespace Coworking_f
{
    partial class SeleccionReservas
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
            dataGridView1 = new DataGridView();
            clmIDEspacio = new DataGridViewTextBoxColumn();
            clmNombreEspacio = new DataGridViewTextBoxColumn();
            clmDescripcionEspacio = new DataGridViewTextBoxColumn();
            btnAgregar = new Button();
            btnReservar = new Button();
            btnHistorial = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            lblIDEspacio = new Label();
            txtIDEspacio = new TextBox();
            lblNombreEspacio = new Label();
            txtNombreEspacio = new TextBox();
            lblDescripcionEspacio = new Label();
            txtDescripcionEspacio = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clmIDEspacio, clmNombreEspacio, clmDescripcionEspacio });
            dataGridView1.Location = new Point(238, 165);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(429, 200);
            dataGridView1.TabIndex = 0;
            // 
            // clmIDEspacio
            // 
            clmIDEspacio.HeaderText = "ID Espacio";
            clmIDEspacio.MinimumWidth = 6;
            clmIDEspacio.Name = "clmIDEspacio";
            clmIDEspacio.Width = 125;
            // 
            // clmNombreEspacio
            // 
            clmNombreEspacio.HeaderText = "Nombre Espacio";
            clmNombreEspacio.MinimumWidth = 6;
            clmNombreEspacio.Name = "clmNombreEspacio";
            clmNombreEspacio.Width = 125;
            // 
            // clmDescripcionEspacio
            // 
            clmDescripcionEspacio.HeaderText = "Descripcion Espacio";
            clmDescripcionEspacio.MinimumWidth = 6;
            clmDescripcionEspacio.Name = "clmDescripcionEspacio";
            clmDescripcionEspacio.Width = 125;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(47, 165);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(86, 31);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnReservar
            // 
            btnReservar.Location = new Point(475, 382);
            btnReservar.Margin = new Padding(3, 4, 3, 4);
            btnReservar.Name = "btnReservar";
            btnReservar.Size = new Size(181, 44);
            btnReservar.TabIndex = 2;
            btnReservar.Text = "Reservar";
            btnReservar.UseVisualStyleBackColor = true;
            // 
            // btnHistorial
            // 
            btnHistorial.Location = new Point(47, 334);
            btnHistorial.Margin = new Padding(3, 4, 3, 4);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(86, 31);
            btnHistorial.TabIndex = 3;
            btnHistorial.Text = "Historial";
            btnHistorial.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(47, 273);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 31);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(47, 218);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(86, 31);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // lblIDEspacio
            // 
            lblIDEspacio.AutoSize = true;
            lblIDEspacio.Location = new Point(79, 44);
            lblIDEspacio.Name = "lblIDEspacio";
            lblIDEspacio.Size = new Size(107, 20);
            lblIDEspacio.TabIndex = 6;
            lblIDEspacio.Text = "ID del espacio:";
            // 
            // txtIDEspacio
            // 
            txtIDEspacio.Location = new Point(221, 41);
            txtIDEspacio.Name = "txtIDEspacio";
            txtIDEspacio.Size = new Size(125, 27);
            txtIDEspacio.TabIndex = 7;
            // 
            // lblNombreEspacio
            // 
            lblNombreEspacio.AutoSize = true;
            lblNombreEspacio.Location = new Point(365, 44);
            lblNombreEspacio.Name = "lblNombreEspacio";
            lblNombreEspacio.Size = new Size(147, 20);
            lblNombreEspacio.TabIndex = 8;
            lblNombreEspacio.Text = "Nombre del espacio:";
            // 
            // txtNombreEspacio
            // 
            txtNombreEspacio.Location = new Point(531, 41);
            txtNombreEspacio.Name = "txtNombreEspacio";
            txtNombreEspacio.Size = new Size(125, 27);
            txtNombreEspacio.TabIndex = 9;
            // 
            // lblDescripcionEspacio
            // 
            lblDescripcionEspacio.AutoSize = true;
            lblDescripcionEspacio.Location = new Point(79, 105);
            lblDescripcionEspacio.Name = "lblDescripcionEspacio";
            lblDescripcionEspacio.Size = new Size(177, 20);
            lblDescripcionEspacio.TabIndex = 10;
            lblDescripcionEspacio.Text = "Descripcion del espcacio:";
            // 
            // txtDescripcionEspacio
            // 
            txtDescripcionEspacio.Location = new Point(300, 98);
            txtDescripcionEspacio.Name = "txtDescripcionEspacio";
            txtDescripcionEspacio.Size = new Size(356, 27);
            txtDescripcionEspacio.TabIndex = 11;
            txtDescripcionEspacio.Text = " ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LogoHerramientas;
            pictureBox1.Location = new Point(668, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ReformaFondo;
            pictureBox2.Location = new Point(9, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(796, 427);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // SeleccionReservas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 451);
            Controls.Add(pictureBox1);
            Controls.Add(txtDescripcionEspacio);
            Controls.Add(lblDescripcionEspacio);
            Controls.Add(txtNombreEspacio);
            Controls.Add(lblNombreEspacio);
            Controls.Add(txtIDEspacio);
            Controls.Add(lblIDEspacio);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnHistorial);
            Controls.Add(btnReservar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox2);
            Name = "SeleccionReservas";
            Text = "SeleccionReservas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAgregar;
        private Button btnReservar;
        private Button btnHistorial;
        private Button btnEliminar;
        private Button btnModificar;
        private Label lblIDEspacio;
        private TextBox txtIDEspacio;
        private Label lblNombreEspacio;
        private TextBox txtNombreEspacio;
        private Label lblDescripcionEspacio;
        private TextBox txtDescripcionEspacio;
        private DataGridViewTextBoxColumn clmIDEspacio;
        private DataGridViewTextBoxColumn clmNombreEspacio;
        private DataGridViewTextBoxColumn clmDescripcionEspacio;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}