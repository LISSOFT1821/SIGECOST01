using System;

namespace demoTablas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------LICENCIATURA INGENIERIA DE SOFTWARE---------------------");
            Console.WriteLine("---------PROYECTOS PROFESIONALES DE SOFTWARE---------------------");
            Console.WriteLine("---------ACTIVIDAD AG6 ------------------------------------------");
            Console.WriteLine("---------SINCRONIZACION AZURE DEVOPS Y GITHUB--------------------");
            Console.WriteLine("                                                                 ");
            Console.WriteLine("---------EQUIPO 2 -----------------------------------------------");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("\nTabla de multiplicar del {0}", i);
                Console.WriteLine("------------------------------");
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0} * {1} = {2}", i, j, (i * j));
                }
            }
            Console.ReadKey();

        }
    }
}
