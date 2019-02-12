using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversiones_de_tipo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            decimal x = 12.2m;
            bool bandera = true;
            string cadena = string.Empty;
            DateTime fecha = DateTime.MinValue;
            /* i = (int)x;*/ // El valor de X lo convierte a la variable I sin la parte decimal
            /*i = Convert.ToInt32(x);*/
            i = Convert.ToInt32(bandera);
            Console.WriteLine("El valor de i es: {0}", i);
            Console.WriteLine("El valor de x es: {0:C}", x);
            Console.WriteLine("El valor de bandera es: " + bandera.ToString());
            Console.WriteLine("El valor de cadena es: " + cadena);
            Console.WriteLine("el valor de fecha es: " + fecha.ToShortDateString());
            Console.ReadKey();

        }
    }
}
