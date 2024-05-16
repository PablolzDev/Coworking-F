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
            clmUbicacion = new DataGridViewTextBoxColumn();
            clmFecha = new DataGridViewTextBoxColumn();
            clmTipoDeLugar = new DataGridViewTextBoxColumn();
            btnAgregar = new Button();
            btnReservar = new Button();
            btnHistorial = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clmUbicacion, clmFecha, clmTipoDeLugar });
            dataGridView1.Location = new Point(172, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(342, 150);
            dataGridView1.TabIndex = 0;
            // 
            // clmUbicacion
            // 
            clmUbicacion.HeaderText = "Ubicacion";
            clmUbicacion.Name = "clmUbicacion";
            // 
            // clmFecha
            // 
            clmFecha.HeaderText = "Fecha";
            clmFecha.Name = "clmFecha";
            // 
            // clmTipoDeLugar
            // 
            clmTipoDeLugar.HeaderText = "Tipo de lugar";
            clmTipoDeLugar.Name = "clmTipoDeLugar";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(23, 48);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnReservar
            // 
            btnReservar.Location = new Point(439, 249);
            btnReservar.Name = "btnReservar";
            btnReservar.Size = new Size(75, 23);
            btnReservar.TabIndex = 2;
            btnReservar.Text = "Reservar";
            btnReservar.UseVisualStyleBackColor = true;
            // 
            // btnHistorial
            // 
            btnHistorial.Location = new Point(23, 135);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(75, 23);
            btnHistorial.TabIndex = 3;
            btnHistorial.Text = "Historial";
            btnHistorial.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(23, 106);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(23, 77);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // SeleccionReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 338);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnHistorial);
            Controls.Add(btnReservar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SeleccionReservas";
            Text = "SeleccionReservas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn clmUbicacion;
        private DataGridViewTextBoxColumn clmFecha;
        private DataGridViewTextBoxColumn clmTipoDeLugar;
        private Button btnAgregar;
        private Button btnReservar;
        private Button btnHistorial;
        private Button btnEliminar;
        private Button btnModificar;
    }
}