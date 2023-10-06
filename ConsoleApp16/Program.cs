using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer número: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            float num2 = float.Parse(Console.ReadLine());

            float num3 = num1 / num2;

            float num4 = (int)num3 * num2;
            float residuo = 0;
            while (num4 < num1)
            {
                residuo++;
                num4++;
            }

            Console.WriteLine("El residuo es: "+ residuo);
            
            Console.ReadLine();
        }
    }
}
