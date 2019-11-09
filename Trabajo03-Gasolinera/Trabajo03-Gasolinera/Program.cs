using System;
using Trabajo03_Gasolinera.Clases;
namespace Trabajo03_Gasolinera
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente cliente = new Cliente();
            Gasolina gasolina = new Gasolina();

            Console.WriteLine("Ingrese su identificacion:");
            cliente.Identificacion = Console.ReadLine();
            Console.WriteLine("Ingrese sus apellidos:");
            cliente.Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese sus nombres:");
            cliente.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su dirección:");
            cliente.Direccion = Console.ReadLine();
            Console.WriteLine("Seleccione el tipo de Gasolina");
            Console.WriteLine("(1) Extra");
            Console.WriteLine("(2) Super");
            gasolina.Tipogasolina = byte.Parse(Console.ReadLine());
            string tipo;
           
            double precio;
            if (gasolina.Tipogasolina==1)
            {
                tipo = "Extra";
                
                precio = 1.5;
            }
            else
            {
                tipo = "Super";
               
                precio = 2;
            }
            Console.WriteLine("Ingrese la cantidad de galones: ");
            float cantidad = float.Parse(Console.ReadLine());


            Console.WriteLine("Identificación:      " + cliente.Identificacion);
            Console.WriteLine("Apelidos:            " + cliente.Apellido);
            Console.WriteLine("Nombre:              " + cliente.Nombre);
            Console.WriteLine("Dirección:           " + cliente.Direccion);
            Console.WriteLine("Tipo de Gasolina:    " + tipo);
            Console.WriteLine("Cantidad de galones: " + cantidad);
            Console.WriteLine("Precio:              " + precio);

          double subtotal=  gasolina.CalcularSubtotal(precio, cantidad);
            Console.WriteLine("Subtotal:            " + subtotal);
           double iva= gasolina.ivaa(subtotal);
            Console.WriteLine("Iva:                 " +iva);
           Console.WriteLine("Total:               " + gasolina.Total(subtotal, iva));
        
        }
    }
}
