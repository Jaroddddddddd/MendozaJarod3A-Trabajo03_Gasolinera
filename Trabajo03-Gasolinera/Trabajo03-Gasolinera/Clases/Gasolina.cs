using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo03_Gasolinera.Clases
{
    class Gasolina
    {

        double subtotal = 0;
        double iva = 0;
        double total = 0;
       
       public  double CalcularSubtotal(double precio, float cantidad)
        {
             subtotal = cantidad * precio;
            return subtotal;
        }
        public double ivaa(double subtotal)
        {
            iva = subtotal * 12 / 100;
            return iva;

        }
        public double Total(double subtotal, double iva)
        {
            total = subtotal + iva;
            return total;

        }
      

        private byte tipogasolina;

        public byte Tipogasolina
        {
            get { return tipogasolina; }
            set { tipogasolina = value; }
        }
     

    }
}
