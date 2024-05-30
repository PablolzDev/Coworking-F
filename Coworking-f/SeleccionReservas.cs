using Coworking_f.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace Coworking_f
{
    public partial class SeleccionReservas : Form
    {
        public SeleccionReservas()
        {
            InitializeComponent();
        }
        clsFunciones Funcion = new clsFunciones();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Se llama la clase 
            clsAgregar agregarEspacio = new clsAgregar();
            //Manda la informacion del usuario a la clase 
            agregarEspacio.IDEspacio1 = Convert.ToInt32(txtIDEspacio.Text);
            agregarEspacio.NombreEspacio1 = txtNombreEspacio.Text;
            agregarEspacio.DescripcionEspacio1 = txtDescripcionEspacio.Text;

            int retornar = clsFunciones.AgregarEspacio(agregarEspacio);

            dtgGrid.Rows.Add(txtIDEspacio.Text, txtNombreEspacio.Text, txtDescripcionEspacio.Text);

            txtIDEspacio.Clear();
            txtNombreEspacio.Clear();
            txtDescripcionEspacio.Clear();


            if (retornar > 0)
            {
                MessageBox.Show("El espacio se creo correctamente :D");
            }
            else
            {
                MessageBox.Show("EROR");
            }
        }

        private void btnVolverSeleccionReservas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIDEspacio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validacion para que no se ingresen ni letrar, ni signos al espacio del ID
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Felicidades, su espacio fue reservado. :D");

            if (dtgGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgGrid.SelectedRows[0];
                row.ReadOnly = false;
            }
        }
    }
}

