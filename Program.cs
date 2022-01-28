using System;
using System.Collections.Generic;

namespace Projeto_Final
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
            Enlatado salsichas = new Enlatado("salsichas", 0.80f);

            listaAVender.addProdutoCongelado("rissois", 0.93f);
            listaAVender.addProdutoCongelado("douradinhos", 0.84f);
            listaAVender.addProdutoCongelado("pescada", 1.21f);
            listaAVender.addProdutoPrateleira("oreo", 1.60f);

            listaStock.addStockCongelado(2,rissois);
            listaStock.addStockCongelado(4,douradinhos);
            listaStock.addStockCongelado(1,pescada);
            listaStock.addStockPrateleira(4, oreo);

            //Compra compra = new();

            //compra.addItemCesto(oreo, 3);

            //Fatura fatura = compra.gerarFatura(listaAVender.produtos);
            //fatura.Gravar(fatura);

            Fatura fatura = Fatura.LerFatura();

            fatura.imprimirFatura();
            /*
            var n = -1;

            while (n != 0)
            {
            Top:
                Console.WriteLine("Menu:\n1- Adicionar Stock\n2- Ver Stock\n3- Fazer Compra\n0- Sair\nOpcao: ");
                n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        //Console.Clear();
                        while (n != 0)
                        {
                            Console.WriteLine("Menu:\n1- Congelados\n2- Prateleira\n3- Enlatados\n0- Sair\nOpcao: ");
                            n = int.Parse(Console.ReadLine());

                            switch (n)
                            {
                                case 1:
                                    //Console.Clear();
                                    Console.WriteLine("Menu:\n1- Rissois\n2- Douradinhos\n3- Pescada\n0- Sair\nOpcao: ");
                                    n = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Quantidade: ");
                                    int quant = int.Parse(Console.ReadLine());
                                    switch (n)
                                    {
                                        case 1:
                                            //Console.Clear();
                                            listaStock.addStockCongelado(quant, rissois);
                                            break;
                                        case 2:
                                            //Console.Clear();
                                            listaStock.addStockCongelado(quant, douradinhos);
                                            break;
                                        case 3:
                                            //Console.Clear();
                                            listaStock.addStockCongelado(quant, pescada);
                                            break;
                                        case 0:
                                            break;
                                    }
                                    break;

                                case 2:
                                    //Console.Clear();
                                    Console.WriteLine("Menu:\n1- Oreo\n2- Oreo\n3- Oreo\n0- Sair\nOpcao: ");
                                    n = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Quantidade: ");
                                    quant = int.Parse(Console.ReadLine());
                                    switch (n)
                                    {
                                        case 1:
                                            //Console.Clear();
                                            listaStock.addStockPrateleira(quant, oreo);
                                            break;
                                        case 2:
                                            //Console.Clear();
                                            listaStock.addStockPrateleira(quant, oreo);
                                            break;
                                        case 3:
                                            //Console.Clear();
                                            listaStock.addStockPrateleira(quant, oreo);
                                            break;
                                        case 0:
                                            break;
                                    }
                                    break;

                                case 3:
                                    //Console.Clear();
                                    Console.WriteLine("Menu:\n1- Salsichas\n2- Salsichas\n3- Salsichas\n0- Voltar\nOpcao: ");
                                    n = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Quantidade: ");
                                    quant = int.Parse(Console.ReadLine());
                                    switch (n)
                                    {
                                        case 1:
                                            //Console.Clear();
                                            listaStock.addStockEnlatado(quant, salsichas);
                                            break;
                                        case 2:
                                            //Console.Clear();
                                            listaStock.addStockEnlatado(quant, salsichas);
                                            break;
                                        case 3:
                                            //Console.Clear();
                                            listaStock.addStockEnlatado(quant, salsichas);
                                            break;
                                        case 0:
                                            break;
                                    }
                                    break;
                                case 0:
                                    break;
                                default:
                                    Console.WriteLine("Opcao Invalida");
                                    break;

                            }
                        }
                        break;

                    case 2:
                        //Console.Clear();
                        listaStock.imprimirStock(listaAVender.produtos);
                        break;

                    case 3:
                        //Console.Clear();
                        Compra compra = new Compra();
                        while (n != 7)
                        {
                            Console.WriteLine("Menu:\n1- Congelados\n2- Prateleira\n3- Enlatados\n6- Imprimir Fatura\n7- Cancelar\nOpcao: ");
                            n = int.Parse(Console.ReadLine());

                            switch (n)
                            {
                                case 1:
                                    //Console.Clear();
                                    Console.WriteLine("Menu:\n1- Rissois\n2- Douradinhos\n3- Pescada\n0- Voltar\nOpcao: ");
                                    n = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Quantidade: ");
                                    int quant = int.Parse(Console.ReadLine());
                                    switch (n)
                                    {
                                        case 1:
                                            //Console.Clear();
                                            compra.addItemCesto(rissois, quant);
                                            break;
                                        case 2:
                                            //Console.Clear();
                                            compra.addItemCesto(douradinhos, quant);
                                            break;
                                        case 3:
                                            //Console.Clear();
                                            compra.addItemCesto(pescada, quant);
                                            break;
                                        case 0:
                                            break;
                                        default:
                                            Console.WriteLine("Opcao Invalida");
                                            break;
                                    }
                                    break;

                                case 2:
                                    //Console.Clear();
                                    Console.WriteLine("Menu:\n1- Oreo\n2- Oreo\n3- Oreo\n0- Voltar\nOpcao: ");
                                    n = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Quantidade: ");
                                    quant = int.Parse(Console.ReadLine());
                                    switch (n)
                                    {
                                        case 1:
                                            //Console.Clear();
                                            compra.addItemCesto(oreo, quant);
                                            break;
                                        case 2:
                                            //Console.Clear();
                                            compra.addItemCesto(oreo, quant);
                                            break;
                                        case 3:
                                            //Console.Clear();
                                            compra.addItemCesto(oreo, quant);
                                            break;
                                        case 0:
                                            break;
                                        default:
                                            Console.WriteLine("Opcao Invalida");
                                            break;
                                    }
                                    break;

                                case 3:
                                    //Console.Clear();
                                    Console.WriteLine("Menu:\n1- Salsichas\n2- Salsichas\n3- Salsichas\n0- Voltar\nOpcao: ");
                                    n = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Quantidade: ");
                                    quant = int.Parse(Console.ReadLine());
                                    switch (n)
                                    {
                                        case 1:
                                            //Console.Clear();
                                            compra.addItemCesto(salsichas, quant);
                                            break;
                                        case 2:
                                            //Console.Clear();
                                            compra.addItemCesto(salsichas, quant);
                                            break;
                                        case 3:
                                            //Console.Clear();
                                            compra.addItemCesto(salsichas, quant);
                                            break;
                                        case 0:
                                            break;
                                        default:
                                            Console.WriteLine("Opcao Invalida");
                                            break;
                                    }
                                    break;

                                case 6:
                                    //Console.Clear();
                                    //compra.iterarFatura();
                                    Fatura fatura = compra.gerarFatura(listaAVender.produtos);
                                    fatura.imprimirFatura();
                                    Console.WriteLine("\n1- Continuar\n0- Sair\nOpcao: ");
                                    n = int.Parse(Console.ReadLine());
                                    switch (n)
                                    {
                                        case 1:
                                            goto Top;
                                        case 0:
                                            return;
                                        default:
                                            Console.WriteLine("Opcao Invalida");
                                            break;
                                    }
                                    break;
                                case 7:
                                    break;
                                default:
                                    Console.WriteLine("Opcao Invalida");
                                    break;
                            }
                        }
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Opcao Invalida");
                        goto Top;
                }
            }*/
        }
    }
}