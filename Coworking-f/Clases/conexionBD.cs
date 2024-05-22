using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Drawing;

namespace Coworking_f.Clases
{
     class conexionBD
    {
        //Metodo para crear la conexion a la Bases de Datos 
        public static MySqlConnection crearConexion()
        {

            //direccion del servidor: 127.0.0.1
            //nombre de la base de datos CoworKing-f
            //ingresar el nombre del usuario del administrador de la base de datos: root
            //ingresar contraseña: en blanco
            MySqlConnection conexion = new MySqlConnection("server = 127.0.0.1;database = coworkingf; Uid=root; pwd=Pablolopez12;");
            conexion.Open();
            return conexion;
        }
    }
}
