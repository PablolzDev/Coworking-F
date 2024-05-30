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

namespace Coworking_f
{
    public partial class SeleccionReservas : Form
    {
        public SeleccionReservas()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsAgregar agregarEspacio = new clsAgregar();

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
    }
}
