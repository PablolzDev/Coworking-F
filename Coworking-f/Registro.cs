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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            conexionBD.crearConexion();
            MessageBox.Show("La conexion es exitosa");
        }

        private void btnCrearPerfilCliente_Click(object sender, EventArgs e)
        {
            //Instancia de la clase "DatosRegistro"
            clsDatosRegistro insertar = new clsDatosRegistro();

            //Enviar la informacion a la clase y esa informacion se enviara a la consulta, esta se enviara a la tabla Users
            insertar.Nombre1 = txtNombre.Text;
            insertar.Apellido1 = txtApellido.Text;
            insertar.Identificacion1 = Convert.ToInt32(txtIdentificacion.Text);
            insertar.Correo1 = txtCorreo.Text;
            insertar.Contraseña1 = txtContraseña.Text;

            //Se genera una instancia al metodo enviar, para enviar la informacion a la tabla Users
            int retorno = clsFunciones.InsertarDatos(insertar);

            if (retorno > 0)
            {
                MessageBox.Show("La conexion fue correcta");
            }
            else
            {
                MessageBox.Show("Error");

            }

            this.Close();
        }

        
    }
}
