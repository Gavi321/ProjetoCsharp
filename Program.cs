using System;

namespace Projeto_Final
{
    class Program
    {
        private static object listaStockEnlatados;

        static void Main(string[] args)
        {
            int n = -1;
            ListaCongelado listaAVender = new ListaCongelado();
            ListaStock listaStock = new ListaStock();

            ListaPrateleira listaAVenderPrateleira = new ListaPrateleira();
            ListaStockPrateleira listaStockPrateleira = new ListaStockPrateleira();

            ListaEnlatados listaAVenderEnlatados = new ListaEnlatados();
            ListaStockEnlatados listaStockEnlatados = new ListaStockEnlatados();

            //produtos congelados
            Congelado rissois = new Congelado("rissois");
            Congelado douradinhos = new Congelado("douradinhos");
            Congelado pescada = new Congelado("pescada");

            listaAVender.listaProdutos.Add(rissois);
            listaAVender.listaProdutos.Add(douradinhos);
            listaAVender.listaProdutos.Add(pescada);

            listaStock.stock.Add(rissois);
            listaStock.stock.Add(douradinhos);
            listaStock.stock.Add(pescada);


            //produtos prateleira
            Prateleira massa = new Prateleira("Massa");
            Prateleira arroz = new Prateleira("Arroz");
            Prateleira bananas = new Prateleira("Bananas");

            listaAVenderPrateleira.listaProdutos.Add(massa);
            listaAVenderPrateleira.listaProdutos.Add(arroz);
            listaAVenderPrateleira.listaProdutos.Add(bananas);

            listaStockPrateleira.stock.Add(massa);
            listaStockPrateleira.stock.Add(arroz);
            listaStockPrateleira.stock.Add(bananas);

            //produtos enlatados
            Enlatados frutasenlatadas = new Enlatados("Frutas Enlatadas");
            Enlatados milho = new Enlatados("Milho");
            Enlatados feijao = new Enlatados("Feijão");

            listaAVenderEnlatados.listaProdutos.Add(frutasenlatadas);
            listaAVenderEnlatados.listaProdutos.Add(milho);
            listaAVenderEnlatados.listaProdutos.Add(feijao);

            listaStockEnlatados.stock.Add(frutasenlatadas);
            listaStockEnlatados.stock.Add(milho);
            listaStockEnlatados.stock.Add(feijao);


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
                                int quantCongelados = int.Parse(Console.ReadLine());
                                switch (n)
                                {
                                    case 1:
                                        listaStock.adicionarStock(quantCongelados, rissois);
                                        break;
                                    case 2:
                                        listaStock.adicionarStock(quantCongelados, douradinhos);
                                        break;
                                    case 3:
                                        listaStock.adicionarStock(quantCongelados, pescada);
                                        break;
                                }
                               
                                break;
                            case 2:
                                Console.WriteLine("Menu:\n1- Massa \n2- Arroz \n3- Douradinhos\n0- Sair");
                                n = int.Parse(Console.ReadLine());
                                Console.WriteLine("Quantidade: ");
                                int quantPrateleira = int.Parse(Console.ReadLine());
                                switch (n)
                                {
                                    case 1:
                                        listaStockPrateleira.adicionarStock(quantPrateleira, massa);
                                        break;
                                    case 2:
                                        listaStockPrateleira.adicionarStock(quantPrateleira, arroz);
                                        break;
                                    case 3:
                                        listaStockPrateleira.adicionarStock(quantPrateleira, bananas);
                                        break;
                                }
                                break;
                            case 3:
                                Console.WriteLine("Menu:\n1- Frutas Enlatadas \n2- Milho Enlatado \n3- Feijão Enlatado \n0- Sair");
                                n = int.Parse(Console.ReadLine());
                                Console.WriteLine("Quantidade: ");
                                int quantEnlatados = int.Parse(Console.ReadLine());
                                switch (n)
                                {
                                    case 1:
                                        listaStockEnlatados.adicionarStock(quantEnlatados, frutasenlatadas);
                                        break;
                                    case 2:
                                        listaStockEnlatados.adicionarStock(quantEnlatados, milho);
                                        break;
                                    case 3:
                                        listaStockEnlatados.adicionarStock(quantEnlatados, feijao);
                                        break;
                                }
                                break;
                        }
                        break;
                   
                    case 2:
                        listaStock.lerStock();
                        listaStockPrateleira.lerStock();
                        listaStockEnlatados.lerStock();
                        break;
                }
            }
            }
        }
    }