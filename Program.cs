using System;

namespace Projeto_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = -1;
            ListaProdutos listaAVender = new ListaProdutos();
            ListaStock listaStock = new ListaStock();

            Congelado rissois = new Congelado("rissois", 0.73f);
            Congelado douradinhos = new Congelado("douradinhos", 1.2f);
            Congelado pescada = new Congelado("pescada", 2.30f);
            Prateleira oreo = new Prateleira("oreo", 1.20f);

            listaStock.adicionarStockCongelado(rissois);
            listaStock.adicionarStockCongelado(douradinhos);
            listaStock.adicionarStockCongelado(pescada);
            listaStock.adicionarStockPrateleira(oreo);

            listaAVender.listaProdutos.Add(rissois);
            listaAVender.listaProdutos.Add(douradinhos);
            listaAVender.listaProdutos.Add(pescada);
            listaAVender.listaProdutos.Add(rissois);
            listaAVender.listaProdutos.Add(douradinhos);
            listaAVender.listaProdutos.Add(pescada);
            listaAVender.listaProdutos.Add(rissois);
            listaAVender.listaProdutos.Add(douradinhos);
            listaAVender.listaProdutos.Add(pescada);
            listaAVender.listaProdutos.Add(oreo);

            listaAVender.imprimirProdutos();
            listaStock.imprimirStock();
            /* while (n != 0)
             {

                Console.WriteLine("Menu:\n1- Adicionar Stock\n2- Ver Stock\n3- Limpar Stock\n0- Sair");
                 n = int.Parse(Console.ReadLine());

                 switch (n)
                 {
                     case 1:
                         Console.WriteLine("Menu:\n1- Congelados\n2- Prateleira\n3- Enlatados\n0- Sair");
                         n = int.Parse(Console.ReadLine());
                         switch (n)
                         {
                             case 1:
                                 Console.WriteLine("Menu:\n1- Rissois\n2- Douradinhos\n3- Pescada\n0- Sair");
                                 n = int.Parse(Console.ReadLine());
                                 Console.WriteLine("Quantidade: ");
                                 int quant = int.Parse(Console.ReadLine());
                                 switch (n)
                                 {
                                     case 1:
                                         listaStock.adicionarStock(quant, rissois);
                                         //listaStock.lerStock();
                                         break;
                                 }
                                 break;
                         }
                         break;

                     case 2:
                         listaStock.lerStock();
                         break;
                 
        }}*/
    }
        }
    }