using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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

        public static void Gravar(Fatura fatura)
        {
            string f1 = "faturas.bin";
            BinaryFormatter b = new BinaryFormatter();
            FileStream f = File.Create(f1);
            b.Serialize(f, fatura.listaDeQuadros);
            f.Close();
        }

        public static Museu LerFicheiro()
        {
            Museu result = new Museu("Falhei");
            string nomeDoFicheiro = "Museu.teste";
            BinaryFormatter b = new BinaryFormatter();

            if (File.Exists(nomeDoFicheiro))
            {
                FileStream f = File.OpenRead(nomeDoFicheiro);
                result = b.Deserialize(f) as Museu;
                f.Close();
            }
            return result;
        }
    }
}
