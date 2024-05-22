using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking_f.Clases
{
    internal class clsDatosRegistro
    {
        //Declaracion de Variables
        private int Identificacion;
        private string Nombre;
        private string Apellido;
        private string Contraseña;
        private string Correo;
        private int RoleID;


        //Constructor de la clase
        public clsDatosRegistro(int identificacion, string nombre, string apellido, string contraseña, string correo, int roleID)
        {
            Identificacion1 = identificacion;
            Nombre1 = nombre;
            Apellido1 = apellido;
            Contraseña1 = contraseña;
            Correo1 = correo;
            RoleID1 = roleID;
        }
        //Segundo constructor 
        public clsDatosRegistro() { }

        //Generacion de metodos get y set de las variables


        public int Identificacion1 { get => Identificacion; set => Identificacion = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellido1 { get => Apellido; set => Apellido = value; }
        public string Contraseña1 { get => Contraseña; set => Contraseña = value; }
        public string Correo1 { get => Correo; set => Correo = value; }
        public int RoleID1 { get => RoleID; set => RoleID = value; }

    }
}
