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

        //Constructor de la clase
        public clsDatosRegistro(int identificacion, string nombre, string apellido, string contraseña, string correo)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            Apellido = apellido;
            Contraseña = contraseña;
            Correo = correo;
        }
        //Segundo constructor 
        public clsDatosRegistro() { }

        //Generacion de metodos get y set de las variables

        public int Identificacion1 { get => Identificacion; set => Identificacion = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellido1 { get => Apellido; set => Apellido = value; }
        public string Contraseña1 { get => Contraseña; set => Contraseña = value; }
        public string Correo1 { get => Correo; set => Correo = value; }
    }
}
