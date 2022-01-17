using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Fatura
    {
        public Dictionary<string, int> itens;
        public float total;

        public Fatura(Dictionary<string,int> itensComprados, float totalCompra)
        {
            itens = itensComprados;
            total = totalCompra;
        }
        public void imprimirFatura()
        {
            Console.WriteLine("---Fatura---");
            foreach (KeyValuePair<string, int> item in itens)
            {
                Console.WriteLine("" + item.Key + " " + item.Value + " uni.");
                Console.WriteLine("-----------");
            }
            Console.WriteLine("Total: " + total.ToString("n2") + "$");
        }
    }
}
