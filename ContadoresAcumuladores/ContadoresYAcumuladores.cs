using System;

namespace ContadoresAcumuladores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("// CONTADORES Y ACUMULADORES //");
            Console.WriteLine(" ");

            int n = 0, n2 = 0;

            Console.Write("Ingrese un numero para iniciar: ");
            n = Convert.ToInt32(Console.ReadLine());
            n2 = n-1;

            for(int i = 0; i < n3; i++)
            {
                for(int j = 0; j < n2; j++)
                {
                    Console.Write($"{n-j} \t");
                }
                Console.WriteLine(" ");
                n2--;
            }
            
            

        }
    }
}
