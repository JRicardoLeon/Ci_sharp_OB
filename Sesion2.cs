using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Reto2
    {
        public String ejercicio1()
        {

            Console.WriteLine("Escriba su nombre...!");
            String nombre = Console.ReadLine();

            Console.WriteLine("Escriba su apellido...!");
            String apellido = Console.ReadLine();

            Console.WriteLine("Escriba su edad...!");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Sabes Programar...?");
            String dev = Console.ReadLine();
            String mensaje = ("Hola mi nombre es: " + nombre +" "+ apellido+
                " tengo "+edad+" años" +dev+" "+"se programar");


            return mensaje;
        }
        public String ejercicio2()
        {
            Console.WriteLine("Escriba Cuantas puertas tiene su Carro...!");
            int puertas = int.Parse(Console.ReadLine());

            Console.WriteLine("Escriba Cuantas llantas tiene su Carro...!");
            int llantas = int.Parse(Console.ReadLine());

            Console.WriteLine("Escriba la marca del Carro...!");
            String marca = Console.ReadLine();

            Console.WriteLine("Escriba el codigo ITV vigente de su Carro...!");
            int ivt = int.Parse(Console.ReadLine());


            String carro = ("Mi Carro tiene" + puertas + "y " + llantas +
                " es de marca " + marca + " con ITV vigente" + ivt);
            return carro;
        }

        public void ejercicio3()
        {
            Console.WriteLine("Digite un Numero...!");
            int numero = int.Parse(Console.ReadLine());
                    Console.WriteLine("True True: "+(numero > 0 && numero > 18));
                    Console.WriteLine("True False: " + (numero > 0 && numero < 18));
                    Console.WriteLine("False False: " + (numero > 0 && numero == 18));
            Char caracter = 'a';
            Console.WriteLine(caracter);
        }
    }
}
