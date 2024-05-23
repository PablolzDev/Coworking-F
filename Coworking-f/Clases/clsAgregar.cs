using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking_f.Clases
{
    internal class clsAgregar
    {
        //Declaracion de las variables
        private int IDEspacio;
        private string NombreEspacio;
        private string DescripcionEspacio;
        private bool DisponibilidadEspacio;

        //Creacion del constructor de la clase
        public clsAgregar(int iDEspacio, string nombreEspacio, string descripcionEspacio, bool disponibilidadEspacio)
        {
            IDEspacio1 = iDEspacio;
            NombreEspacio1 = nombreEspacio;
            DescripcionEspacio1 = descripcionEspacio;
            DisponibilidadEspacio1 = disponibilidadEspacio;
        }

        public  clsAgregar() { }

        //Generacion de metodos get y set de las variables
        public int IDEspacio1 { get => IDEspacio; set => IDEspacio = value; }
        public string NombreEspacio1 { get => NombreEspacio; set => NombreEspacio = value; }
        public string DescripcionEspacio1 { get => DescripcionEspacio; set => DescripcionEspacio = value; }
        public bool DisponibilidadEspacio1 { get => DisponibilidadEspacio; set => DisponibilidadEspacio = value; }
    }
}
