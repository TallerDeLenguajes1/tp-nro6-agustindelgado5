using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Ingrese el numero a invertir: ");
            num = int.Parse(Console.ReadLine());
            num = invertir(num);
            Console.WriteLine(num);
            Console.ReadKey();
        }

        static int invertir(int num)
        {
            int numAux = 0;

            if (num > 0)
            {
             while(num>10)
                {
                    numAux = numAux * 10 + num % 10;
                    num /= 10;
                 }
                numAux = numAux * 10 + num;
            }
            else
            {
                Console.WriteLine("El numero no se pudo invertir ya que es menor o igual que 0.");
            }

            return numAux;
        }
    }
}
