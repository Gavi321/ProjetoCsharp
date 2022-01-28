using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final
{
    [Serializable]
    class Fatura
    {
        public Dictionary<string, int> itens;
        public float total;

        public Fatura(Dictionary<string,int> itensComprados, float totalCompra)
        {
            itens = itensComprados;
            total = totalCompra;
        }

        public Fatura(string s) { }
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

        public void Gravar(Fatura fatura)
        {
            string f1 = "faturas.bin";
            BinaryFormatter bf = new BinaryFormatter();
            FileStream f = File.Create(f1);
            bf.Serialize(f, fatura);
            f.Close();
        }

        public static Fatura LerFatura()
        {
            Fatura fatura = new("erro");
            string f1 = "faturas.bin";
            BinaryFormatter bf = new BinaryFormatter();

            if (File.Exists(f1))
            {
                FileStream f = File.OpenRead(f1);
                fatura = bf.Deserialize(f) as Fatura;
                f.Close();
            }
            return fatura;
        }
    }
}
