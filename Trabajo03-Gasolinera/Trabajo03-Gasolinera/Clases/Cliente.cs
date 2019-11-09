using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo03_Gasolinera.Clases
{
    class Cliente
    {

        private string identificacion;

        public string Identificacion
        {
            get { return identificacion; }
            set { identificacion = value; }
        }

        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string direccion;

      

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }


    }
}
