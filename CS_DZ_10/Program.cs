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

            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            Console.Write("Введите символ: ");
            symbol = Console.ReadLine();

            for (int i = 1; i <= (name.Length + 4); i += 1)
            {
                frameWidht += symbol;
            }

            Console.WriteLine(frameWidht);
            Console.WriteLine(frameWidht [0] + emptySymbol + name + emptySymbol + frameWidht [frameWidht.Length - 1]);
            Console.WriteLine(frameWidht);
        }
    }
}
