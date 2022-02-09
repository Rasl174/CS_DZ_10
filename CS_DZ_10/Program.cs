using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string frameWidht = "";
            string name;
            string symbol;
            string emptySymbol = " ";
            int numberAddedSymbols = 4;

            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            Console.Write("Введите символ: ");
            symbol = Console.ReadLine();

            for (int i = 0; i < (name.Length + numberAddedSymbols); i++)
            {
                frameWidht += symbol;
            }

            Console.WriteLine(frameWidht);
            Console.WriteLine(symbol + emptySymbol + name + emptySymbol + symbol);
            Console.WriteLine(frameWidht);
        }
    }
}
