using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coworking_f.Clases;

namespace Coworking_f
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();

        }
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            //No se usa
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            //Deja pasar al usuario al formulario para seleccionar su espacio
            SeleccionReservas frmSeleccionReservas = new SeleccionReservas();
            frmSeleccionReservas.Show();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            conexionBD.crearConexion();
            groupBox1.Enabled = false;
            btnContinuar.Enabled = false;
        }

        private void ValidarCampos()
        {
            var vr = !string.IsNullOrEmpty(txtCorreoCliente.Text) &&
                !string.IsNullOrEmpty(txtContraseñaCliente.Text);
            btnContinuar.Enabled = true;
        } 


        private void crearPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Manda al usuario al formulario de registro
            Registro frmRegistro = new Registro();
            frmRegistro.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //No se usa
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //No se usa
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //No se usa
        }

        private void txtCorreoCliente_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void txtContraseñaCliente_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }
    }
}
