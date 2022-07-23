using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class sesion4
    {
        public void ejercicioWhile()
        {
            Console.WriteLine("Que tabla quiere generar, digite solo el numero");
            int numero = int.Parse(Console.ReadLine());
            int con = 1;
            string tabala = "";
            while (con <= 10)
            {
                tabala += numero + "X" +con+ "="+ con * numero + "\n";
                con++;
            }
            Console.WriteLine(tabala);
        }

        public void ejercicioDoWhile()
        {
            Boolean saber=true;
            Console.WriteLine("Digite un Numero, puede ser positivo o Negativo");
            int n = int.Parse(Console.ReadLine());

            if (n>0){
                Console.WriteLine("El numero "+n+ " Es Positivo");

            }else{
                Console.WriteLine("El numero " + n + " Es Negativo");
                saber = false;
            }
            if (saber)
            {
                do
                {
                    Console.WriteLine("Numero: " + n);
                    n--;

                } while (n != 0);
            }
            else
            {
                do
                {
                    Console.WriteLine("Numero: " + n);
                    n++;

                } while (n != 0);
            }
           
        }

        public void ejercicioFor()
        {
            Console.WriteLine("Digite el ancho");
            int ancho = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el alto");
            int alto = int.Parse(Console.ReadLine());
            Console.WriteLine("Si quiere que la figura se rellene marque el numero ( 1 ) si no, marque ( 2 )");
            int lleno = int.Parse(Console.ReadLine());
            String m = "";
            if (lleno == 1 || lleno ==2)
            {
                for (int i = 1; i <= alto; i++)
                {
                    for (int j = 1; j <= ancho; j++)
                    {
                        if (lleno == 1)
                        {
                            m += "*";
                        }
                        else
                        {
                            if (i == 1 || i == alto)
                            {
                                m += "*";
                            }
                            else
                            {
                                if (j == 1 || j == ancho)
                                {
                                    m += "*";
                                }
                                else
                                {
                                    m += " ";
                                }
                            }
                        }

                    }
                    m += "\n";
                }
            }
            else
            {
                Console.WriteLine("Solo se acepta el numero (1) o (2)");
            }
           
            Console.WriteLine(m+m);
        }

        public void ejercicioFor2()
        {

            Console.WriteLine("Digite el ancho");
            int ancho = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el alto");
            int alto = int.Parse(Console.ReadLine());
            Console.WriteLine("Si quiere que la figura se rellene marque el numero ( 1 ) si no, marque ( 2 )");
            int lleno = int.Parse(Console.ReadLine());
            Console.WriteLine("Cuantas veces quiere que se repita la figura");
            int cantidadReprtidos = int.Parse(Console.ReadLine());
            String m = "";
            if (lleno == 1 || lleno == 2)
            {
                for (int i = 1; i <= alto; i++)
                {
                    for (int j = 1; j <= ancho; j++)
                    {
                        if (lleno == 1)
                        {
                            m += "*";
                        }
                        else
                        {
                            if (i == 1 || i == alto)
                            {
                                m += "*";
                            }
                            else
                            {
                                if (j == 1 || j == ancho)
                                {
                                    m += "*";
                                }
                                else
                                {
                                    m += " ";
                                }
                            }
                        }

                    }
                    m += "\n";
                }
            }
            else
            {
                Console.WriteLine("Solo se acepta el numero (1) o (2)");
            }
            String r = "";
            for (int i = 0; i < cantidadReprtidos; i++)
            {
                r += m;
                
            }
            Console.Write(r);
        }
    }
}
