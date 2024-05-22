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
            dataGridView1.Location = new Point(197, 64);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(391, 200);
            dataGridView1.TabIndex = 0;
            // 
            // clmUbicacion
            // 
            clmUbicacion.HeaderText = "Ubicacion";
            clmUbicacion.MinimumWidth = 6;
            clmUbicacion.Name = "clmUbicacion";
            clmUbicacion.Width = 125;
            // 
            // clmFecha
            // 
            clmFecha.HeaderText = "Fecha";
            clmFecha.MinimumWidth = 6;
            clmFecha.Name = "clmFecha";
            clmFecha.Width = 125;
            // 
            // clmTipoDeLugar
            // 
            clmTipoDeLugar.HeaderText = "Tipo de lugar";
            clmTipoDeLugar.MinimumWidth = 6;
            clmTipoDeLugar.Name = "clmTipoDeLugar";
            clmTipoDeLugar.Width = 125;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(26, 64);
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
            btnReservar.Location = new Point(502, 332);
            btnReservar.Margin = new Padding(3, 4, 3, 4);
            btnReservar.Name = "btnReservar";
            btnReservar.Size = new Size(86, 31);
            btnReservar.TabIndex = 2;
            btnReservar.Text = "Reservar";
            btnReservar.UseVisualStyleBackColor = true;
            // 
            // btnHistorial
            // 
            btnHistorial.Location = new Point(26, 180);
            btnHistorial.Margin = new Padding(3, 4, 3, 4);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(86, 31);
            btnHistorial.TabIndex = 3;
            btnHistorial.Text = "Historial";
            btnHistorial.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(26, 141);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 31);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(26, 103);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(86, 31);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // SeleccionReservas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 451);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnHistorial);
            Controls.Add(btnReservar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridView1);
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