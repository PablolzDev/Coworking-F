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
        //Metodo para insertar informacion a la base de datos
        public static int InsertarDatos(clsDatosRegistro add)
        {
            int retorno = 0;
            using (var conexion = conexionBD.crearConexion()) // Crear una nueva conexión a la base de datos y asegurarse de que se cierre correctamente
            {
                if (conexion.State != System.Data.ConnectionState.Open) //Verifica si la BD se conecto
                {
                    conexion.Open();
                }

                var consulta = "INSERT INTO Users (UserID, Name, LastName, Password, Email, RoleID) " +
                               "VALUES (@UserID, @Name, @LastName, @Password, @Email, 2)"; //El 2 al final es el uso de los roles para indicar que su rol es user

                // Asignar los valores de los parámetros de la consulta
                var comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@UserID", add.Identificacion1);
                comando.Parameters.AddWithValue("@Name", add.Nombre1); // Asumiendo que add.Nombre1 contiene el valor para el campo "Name"
                comando.Parameters.AddWithValue("@LastName", add.Apellido1);
                comando.Parameters.AddWithValue("@Password", add.Contraseña1);
                comando.Parameters.AddWithValue("@Email", add.Correo1);
                comando.Parameters.AddWithValue("@RoleID", add.RoleID1);

                retorno = comando.ExecuteNonQuery(); // Ejecutar la consulta de inserción y almacenar el resultado
            }

            return retorno;  // Devolver el resultado de la inserción
        }

        //Metodo para insertar un espacio a la base de datos

    }
}