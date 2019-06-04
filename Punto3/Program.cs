using System;

namespace Punto3
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
                if (opcion >4 && opcion <11)
                {
                   Calculadora(0, 0, opcion); //Punto 3
                }
                else
                {
                    Console.WriteLine("Ingrese un operando \n");
                    float a = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese un operando\n");
                    float b = float.Parse(Console.ReadLine());
                    resultado = Calculadora(a, b, opcion);
                    Console.WriteLine("El resultado es : \n" + resultado);
                }
                
               
                

                

                Console.WriteLine("Desea Realizar otra operacion? \n Ingrese (1) si desea continar \n(2) Para terminar");
                opcion = int.Parse(Console.ReadLine());
            } while (opcion != 2);

        }
        public static float Calculadora(float a, float b, int opc)
        {
            float res = 0;
            double r;
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
                case 5:

                    Console.WriteLine("Ingrese un operando para calcular el VA");
                    double w = double.Parse(Console.ReadLine());
                    r = Math.Abs(w);
                    Console.WriteLine("El Valor Absoluto de  " + w + "es:" + r);
                    break;
                case 6:
                    Console.WriteLine("Ingrese un operando para calcular el cuadrado ");
                    w = double.Parse(Console.ReadLine());
                    r = Math.Pow(w, 2);
                    Console.WriteLine("El cuadrado de " + w + "  es: " + r);
                    break;
                case 7:
                    Console.WriteLine("Ingrese un operando para calcular la Raiz");
                    w = double.Parse(Console.ReadLine());
                    r = Math.Sqrt(w);
                    Console.WriteLine("La raiz Cuadrada  de " + w + "  es: " + r);
                    break;
                case 8:
                    Console.WriteLine("Ingrese un operando para calcular el Seno");
                    w = double.Parse(Console.ReadLine());
                    r = Math.Sin(w);
                    Console.WriteLine("El seno de  " + w + "  es: " + r);
                    break;
                case 9:
                    Console.WriteLine("Ingrese un operando para calcular el Coseno");
                    w = double.Parse(Console.ReadLine());
                    r = Math.Cos(w);
                    Console.WriteLine("El coseno   de " + w + "  es: " + r);
                    break;
                case 10:
                    Console.WriteLine("Ingrese un operando para quitarle la parte decimal");
                    float f = float.Parse(Console.ReadLine());
                    Console.WriteLine("Al numero " + f + " se le a quitado la parte decimal, quedando : " + Math.Truncate(f));
                    break;
                case 11:
                    if(a > b)
                    {
                        Console.WriteLine("El nuemero " + a + "es Mayor que el numero " + b);
                    }
                    else
                    {
                        Console.WriteLine("El nuemero " + b + "es Mayor que el numero " + a);
                    }
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
            Console.WriteLine("5- Valor Absoluto de un numero");
            Console.WriteLine("6- El cuadrado de un numero");
            Console.WriteLine("7- La raiz cuadrada de un numero");
            Console.WriteLine("8- El seno de un numero");
            Console.WriteLine("9- El Coseno de un numero");
            Console.WriteLine("10- Parte entera de un numero Decimal");
            Console.WriteLine("Seleccione una opcion: ");
        }
    }
}
