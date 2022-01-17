using System;
using System.Collections.Generic;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = -1;
            ListaProdutos listaAVender = new ListaProdutos();
            ListaStock listaStock = new ListaStock();

            Congelado rissois = new Congelado("rissois", 0.93f);
            Congelado douradinhos = new Congelado("douradinhos", 0.84f);
            Congelado pescada = new Congelado("pescada", 1.21f);
            Prateleira oreo = new Prateleira("oreo", 1.60f);

            listaAVender.addProdutoCongelado(rissois);
            listaAVender.addProdutoCongelado(douradinhos);
            listaAVender.addProdutoCongelado(pescada);
            listaAVender.addProdutoPrateleira(oreo);

            listaStock.addStockCongelado(2,rissois);
            listaStock.addStockCongelado(4,douradinhos);
            listaStock.addStockCongelado(1,pescada);
            listaStock.addStockPrateleira(4, oreo);

            Compra compra = new Compra();

            //compra.addItemCesto(oreo, 3);
            compra.itens.Add(oreo.nome, 3);
            compra.itens.Add(douradinhos.nome, 2);
            compra.itens.Add(rissois.nome, 1);
            /*foreach (KeyValuePair<string,int> item in compra.itens)
            {
                Console.WriteLine("nome: " + item.Key + " | quant: " + item.Value);
                Console.WriteLine("x");
            }*/

            Fatura fatura = compra.gerarFatura(listaAVender.produtos);
            fatura.imprimirFatura();

            /*while (n != 0)
            {
                Console.WriteLine("Menu:\n1- Adicionar Stock\n2- Ver Stock\n3- imprimirFaturaLimpar Stock\n0- Sair");
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
                                        listaStock.addStockCongelado(quant, rissois);
                                        break;
                                    case 2:
                                        listaStock.addStockCongelado(quant, douradinhos);
                                        break;
                                    case 3:
                                        listaStock.addStockCongelado(quant, pescada);
                                        break;
                                }
                                break;
                        }
                        break;
                    case 2:
                        listaStock.imprimirStock(listaAVender.produtos);
                        break;
                    case 3:
                }
            }*/
        }
    }
}