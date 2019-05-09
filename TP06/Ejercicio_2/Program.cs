using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, opc=0;
            float resultado=0;

            while (opc != 5)
            {
                Menu();
                Console.WriteLine("Ingrese cual opcion desea usar: ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Ingrese el primer numero:");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero:");
                        num2 = int.Parse(Console.ReadLine());
                        resultado = Suma(num1, num2);
                        Console.WriteLine("El resultado es: " + resultado + ".");
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el primer numero:");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero:");
                        num2 = int.Parse(Console.ReadLine());
                        resultado = Producto(num1, num2);
                        Console.WriteLine("El resultado es: " + resultado + ".");
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el primer numero:");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero:");
                        num2 = int.Parse(Console.ReadLine());
                        resultado = Resta(num1, num2);
                        Console.WriteLine("El resultado es: " + resultado + ".");
                        break;
                    case 4:
                        Console.WriteLine("Ingrese el primer numero:");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero:");
                        num2 = int.Parse(Console.ReadLine());
                        resultado = Division(num1, num2);
                        Console.WriteLine("El resultado es: " + resultado + ".");
                        break;
                    default: Console.WriteLine("Salida");
                        break;
                }
            }
            

        }

        static void Menu()
        {

            Console.WriteLine("|=== Calculadora ===|");
            Console.WriteLine("1 - Suma 2 numeros.");
            Console.WriteLine("2 - Producto entre 2 numeros.");
            Console.WriteLine("3 - Resta entre 2 numeros.");
            Console.WriteLine("4 - Division entre 2 numeros.");
            Console.WriteLine("5 - Salir.");
        }

        static int Suma(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Producto(int num1, int num2)
        {
            return num1 * num2;
        }

        static int Resta(int num1, int num2)
        {
            return num1 - num2;
        }

        static float Division(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
