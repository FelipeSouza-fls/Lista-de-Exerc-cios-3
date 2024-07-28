using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

          

            
               Console.Write("Digite o primeiro valor: ");
               a = int.Parse(Console.ReadLine());

               do
            {
                Console.Write("Digite o segundo valor: ");
               b = int.Parse(Console.ReadLine());

            }

              while (b <= a);
             Console.WriteLine("O primeiro valor: " + a);
             Console.WriteLine("O segundo valor: " + b);
            
        }
    }
}
