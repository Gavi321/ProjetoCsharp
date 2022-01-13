using System;

namespace Projeto_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = -1;
            ListaCongelado listaAVender = new ListaCongelado();
            ListaStock listaStock = new ListaStock();

            Congelado rissois = new Congelado("rissois");
            Congelado douradinhos = new Congelado("douradinhos");
            Congelado pescada = new Congelado("pescada");

            listaAVender.listaProdutos.Add(rissois);
            listaAVender.listaProdutos.Add(douradinhos);
            listaAVender.listaProdutos.Add(pescada);

            listaStock.stock.Add(rissois);
            listaStock.stock.Add(douradinhos);
            listaStock.stock.Add(pescada);
            listaStock.stock.Add(rissois);
            listaStock.stock.Add(douradinhos);
            listaStock.stock.Add(pescada);

            while (n != 0)
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
                }
            }
            }
        }
    }