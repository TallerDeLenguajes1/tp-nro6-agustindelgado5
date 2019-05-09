using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, opc = 0;
            //float resultado = 0;
            double resultado, num3;
            while (opc != 5)
            {
                Menu();
                Console.WriteLine("Ingrese cual opcion desea usar: ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        num1 = numPedido();
                        num2 = numPedido();
                        resultado = Suma(num1, num2);
                        Console.WriteLine("El resultado es: " + resultado + ".");
                        break;
                    case 2:
                        num1 = numPedido();
                        num2 = numPedido();
                        resultado = Producto(num1, num2);
                        Console.WriteLine("El resultado es: " + resultado + ".");
                        break;
                    case 3:
                        num1 = numPedido();
                        num2 = numPedido();
                        resultado = Resta(num1, num2);
                        Console.WriteLine("El resultado es: " + resultado + ".");
                        break;
                    case 4:
                        num1 = numPedido();
                        num2 = numPedido();
                        resultado = Division(num1, num2);
                        Console.WriteLine("El resultado es: " + resultado + ".");
                        break;
                    case 5:
                        num1 = numPedido();
                        resultado = Math.Abs(num1);
                        Console.WriteLine("El resultado es: " + resultado + ".");
                        break;
                    case 6:
                        num3 = numPedido();
                        resultado = Math.Pow(num3,2);
                        Console.WriteLine("El resultado es: " + resultado + ".");
                        break;
                    case 7:
                        num1 = numPedido();
                        resultado = Math.Sqrt(num1);
                        Console.WriteLine("El resultado es: " + resultado + ".");
                        break;
                    case 8:
                        num1 = numPedido();
                        resultado = Math.Sin(num1);
                        Console.WriteLine("El resultado es: " + resultado + ".");
                        break;
                    case 9:
                        num1 = numPedido();
                        resultado = Math.Cos(num1);
                        Console.WriteLine("El resultado es: " + resultado + ".");
                        break;
                    case 10:
                        num1 = numPedido();
                        resultado = Math.Truncate(num1);
                        Console.WriteLine("El resultado es: " + resultado + ".");
                        break;
                    default:
                        Console.WriteLine("Salida");
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
            Console.WriteLine("5 - valor absoluto.");
            Console.WriteLine("6 - cuadrado.");
            Console.WriteLine("7 - raiz cuadrada.");
            Console.WriteLine("8 - Seno.");
            Console.WriteLine("9 - coseno.");
            Console.WriteLine("10 - parte entera de un decimal.");
            Console.WriteLine("0 - Salir.");
        }

        static int numPedido()
        {
            int num;
            Console.WriteLine("Ingrese el numero:");
            num = int.Parse(Console.ReadLine());
            return num;
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
