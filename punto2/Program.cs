using System;

namespace punto2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int opcion;
            float resultado;

            do
            {
                Menu();
                opcion = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese un operando \n");
                float a = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese un operando\n");
                float b = float.Parse(Console.ReadLine());
                resultado = Calculadora(a, b, opcion);

                Console.WriteLine("El resultado es : \n" + resultado);

                Console.WriteLine("Desea Realizar otra operacion? \n Ingrese (1) si desea continar \n(2) Para terminar");
                opcion = int.Parse(Console.ReadLine());
            } while (opcion != 2);
            
        }
        public static float Calculadora(float a, float b , int opc)
        {
            float res = 0;
            switch (opc)
            {
                case 1:
                    res = a + b;
                    break;
                case 2:
                    res = a - b;
                    break;
                case 3:
                    res = a * b;
                    break;
                case 4:
                    res = a / b;
                    break;
                default:
                    Console.WriteLine("No existe esa opcion ingresada");
                    break;
            }
            return (res);

        }
        public static void Menu()
        {
            Console.WriteLine("| === Calculadora === |");
            Console.WriteLine("1- Sumar 2 numeros.");
            Console.WriteLine("2- Restar 2 numeros.");
            Console.WriteLine("3- Producto entre 2 numeros.");
            Console.WriteLine("4- Division entre 2 numeros.");
            Console.WriteLine("Seleccione una opcion: ");
        }
    }
}
