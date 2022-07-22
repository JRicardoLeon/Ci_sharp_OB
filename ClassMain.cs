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
            /*
             sesion1();
             */

            /*
            Reto2 reto2 = new Reto2();
            Console.WriteLine(reto2.ejercicio1());
            reto2.ejercicio2();
            reto2.ejercicio3();
             */

            /*  
            //Solucion del ejercicio de l session 3...
            Console.WriteLine("Escriba su nombre...!");
            String nombre = Console.ReadLine();
            Console.WriteLine("Escriba su telefono.");
            String telefono = Console.ReadLine();
            Console.WriteLine("Escriba su direccion.");
            String direccion = Console.ReadLine();
            Console.WriteLine("Escriba su Email.");
            String email = Console.ReadLine();
            Console.WriteLine("Es cliente Nuevo (SI) O (NO)");
            String nuevo = Console.ReadLine();
            persona p = new persona(nombre, telefono,direccion,email,nuevo);
            Console.WriteLine("Mi nombre es: " + p.nombre + " con telefono: " +
                p.telefono + ", direccion: " + p.direccion + ", email: " +
                p.emaill + ", soy nuevo: " + p.clienteN);
            */
        }
        static void sesion1()
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
