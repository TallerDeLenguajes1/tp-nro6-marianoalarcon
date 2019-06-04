using System;

namespace TP6_consola
{
    class Program
    {
        static void Main(string[] args)
        {   

          
            Console.WriteLine("Ingrese un numero : ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("NUmero Invertido: " + invertir(N));
            Console.ReadKey();

        }



        public static int invertir(int N)
        {
            
            //int[] arre;
            if (N <= 0)
            {
                return N;
            }
            else
            {
                int aux  = 0;
                while( N > 0)
                {
                    int resto = (N % 10);
                    
                    //Console.WriteLine(resto);
                    
                    aux = (aux * 10) + resto ;

                    N = (N / 10);
                }
                return aux;
            }
        }

    }
}
