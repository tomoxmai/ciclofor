using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nu, me, be;
            Console.WriteLine("Imprimir valores");
            Console.WriteLine("Insertar el primer valor: ");
            nu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insertar el segundo valor : ");
            me = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("saltos de: ");
            be = Convert.ToInt32(Console.ReadLine());
            if (nu>be)
            {
                for (int i = nu; i> me; i -= be)
                {
                    Console.WriteLine("i = " + i);
                }
            }
            else
            {
                for (int i = nu; i < me; i +=be)
                {
                    Console.WriteLine("i = " + i);
                }
            }
        }
    }
}
