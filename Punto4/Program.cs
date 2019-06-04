using System;

namespace punto4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una oracion");
            string tex1 = Console.ReadLine();
            Console.WriteLine("La cadena oracion ingresada fue: " + tex1);
            //Longitud Cadena 
            Console.WriteLine("La longitud de la cadena1 ingresada es: " + tex1.Length);
            //Concatenar dos cadenas
            Console.WriteLine("Ingrese una oracion que sera concatenada a la anterior");
            string tex2 = Console.ReadLine();
            Console.WriteLine("Las oraciones concatenadas son: " + string.Concat(tex1, tex2));
            //Recorrer la cadena con ciclo ForEach
            foreach (char car in tex1)
            {
                Console.WriteLine(car);
            }
            // Object obj = new Object();    //CONSULTAR BIEN DE QUE SE TRATA TO STRING() 
            // Console.WriteLine(obj.ToString());
            // methods for ToUpper and Lower
            Console.WriteLine("La oracion 1 en Mayusculas: " + tex1.ToUpper());
            Console.WriteLine("La oracion 1 en Minusculas: " + tex1.ToLower());
            //CALCULADORA 
            Console.WriteLine("Ingrese un numero entero");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero entero");
            int num2 = int.Parse(Console.ReadLine());
            int res = num1 + num2;
            string cadena = res.ToString();
            Console.WriteLine("La suma de " + num1.ToString() +" y " + num2.ToString() + " es : " + cadena);
            //NO le encuentro aplicacion util....

            //SUbcadena 
            Console.WriteLine("Subcadena " + tex1.Substring(0,3));

            //Metodo Split 
           //cadenaSeparar;
            char[] delimitadores = { '.', ',', ';' };
            Console.WriteLine("Ingrese una cadena para separar: ");
            string cadenaSeparar = Console.ReadLine();

            string[] separada = cadenaSeparar.Split(delimitadores);

            foreach (string sep in separada)
            {
                Console.WriteLine(sep);
            }

            Console.ReadKey();

        }

    }
}