using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; //Libreria para MySql

namespace Coworking_f.Clases
{
    internal class clsFunciones
    { 
        //Metodo para insertar informacion a la bd
        public static int InsertarDatos(clsDatosRegistro add)
        {
            int retorno = 0;
            MySqlCommand Comando = new MySqlCommand(string.Format("insert into Users(UserID, Name, LastName, Password, Email, RoleID) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                add.Identificacion1, add.Apellido1, add.Contraseña1, add.Correo1, add.Identificacion1, add.RoleID1), conexionBD.crearConexion());

            retorno = Comando.ExecuteNonQuery();
            return retorno;
        }

    }
}
