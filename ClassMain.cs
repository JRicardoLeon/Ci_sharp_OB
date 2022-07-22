using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    class OB_Ci_Sharp
    {
        static void Main(string[] args)
        {

            Reto2 x = new Reto2();
            Console.WriteLine(x.ejercicio1());
        }
        static void ejercicio2()
        {
           Console.WriteLine("Escriba su nombre...!");
            String nombre = Console.ReadLine();

            Console.WriteLine("Hola mi nombre es: " + nombre);

            // EJERCICIO 2
            String hora = DateTime.Now.ToString("hh:mm:ss");

            Console.WriteLine("La hora del sistema actual es: " + hora);
           
            Console.WriteLine("soy un metodo");
        }
        
    }
}
