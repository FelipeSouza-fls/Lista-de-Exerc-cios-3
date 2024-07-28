using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string S;

            do
            {
                Console.Write("Digite (F) para Feminino ou (M) para Masculino: ");
                S = Console.ReadLine();

                if (S != "F" && S != "f" && S != "M" && S != "m")

                    Console.WriteLine("digite um valor valido.");
            }
                 while (S != "F" && S != "f" && S != "M" && S != "m");
            {
                Console.WriteLine("O sexo indicado é {0}", S);
            }
        }
    }
}
