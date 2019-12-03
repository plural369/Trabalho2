using System;
using System.Collections.Generic;

namespace Extrabalho2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<cadastro> produto = new List<cadastro>();

            int menu = 0, escolha = 0;
            string continuar = "S";
            string nome, fornecedor, modelo, codigo;
            double preço = 0;
            

            while (menu != 3)
            {
                Console.WriteLine("Digite:\n 1 = INCLUIR\n 2 = CONSULTAR\n 3 = SAIR ");
                menu = Convert.ToInt32(Console.ReadLine());
                continuar = "S";
                if (menu == 1)
                {
                    //Incluindo os valores
                    while (continuar.ToUpper() == "S")
                    {
                        var lista = new cadastro();

                        Console.WriteLine("Digite o Código do produto: ");
                        lista.Codigo = Console.ReadLine();

                        Console.WriteLine("Digite o Nome do produto: ");
                        lista.Nome = Console.ReadLine();

                        Console.WriteLine("Digite a data de validade do produto: ");
                        lista.Validade = Convert.ToDateTime(Console.ReadLine());

                        Console.WriteLine("Digite o Tamanho do produto: ");
                        lista.Tamanho = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Digite a cor do produto: ");
                        lista.Cor = Console.ReadLine();

                        Console.WriteLine("Digite o Fornecedor: ");
                        lista.Fornecedor = Console.ReadLine();

                        Console.WriteLine("Digite o Peso: ");
                        lista.Peso = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Digite a Medida: ");
                        lista.Medida = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Digite o Preço: ");
                        lista.Preço = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Digite o Modelo: ");
                        lista.Modelo = Console.ReadLine();

                        produto.Add(lista);

                        Console.WriteLine("Digite S para continuar ou N para sair.");
                        continuar = Console.ReadLine();

                    }
                }
                else if (menu == 2)
                {
                    Console.WriteLine("Digite para consultar pelo:\n 1 = Nome\n 2 = Código\n 3 = Fornecedor\n 4 = Preço\n 5 = Modelo");
                    escolha = Convert.ToInt32(Console.ReadLine());
                    var lista = new cadastro();
                    if (escolha == 1)
                    {

                        Console.WriteLine("Digite o nome que deseja encontrar: ");
                        nome = Console.ReadLine();
                        foreach (var item in produto)
                        {
                            if (nome == lista.Nome)
                            {
                                Console.WriteLine("\n\n**********************");
                                Console.WriteLine("Nome: " + item.Nome);
                                Console.WriteLine("Nome: " + item.Codigo);
                                Console.WriteLine("Nome: " + item.Cor);
                                Console.WriteLine("Nome: " + item.Validade);
                                Console.WriteLine("Nome: " + item.Preço);
                                Console.WriteLine("Nome: " + item.Fornecedor);
                                Console.WriteLine("Nome: " + item.Modelo);
                                Console.WriteLine("Nome: " + item.Medida);
                                Console.WriteLine("Nome: " + item.Tamanho);
                                Console.WriteLine("Nome: " + item.Peso);
                                Console.WriteLine("******************************");
                            }
                        
                            else
                            {
                                Console.WriteLine("Nome Não encontrado");
                            }
                        }
                    }
                    else if (escolha == 2)
                    {
                        Console.WriteLine("Digite o Código que deseja encontrar: ");
                        codigo = Console.ReadLine();
                        foreach (var item in produto)
                        {
                            if (codigo == item.Codigo)
                            {
                                Console.WriteLine("\n\n**********************");
                                Console.WriteLine("Nome: " + item.Nome);
                                Console.WriteLine("Nome: " + item.Codigo);
                                Console.WriteLine("Nome: " + item.Cor);
                                Console.WriteLine("Nome: " + item.Validade);
                                Console.WriteLine("Nome: " + item.Preço);
                                Console.WriteLine("Nome: " + item.Fornecedor);
                                Console.WriteLine("Nome: " + item.Modelo);
                                Console.WriteLine("Nome: " + item.Medida);
                                Console.WriteLine("Nome: " + item.Tamanho);
                                Console.WriteLine("Nome: " + item.Peso);
                                Console.WriteLine("******************************");
                            }
                        
                            else
                            {
                                Console.WriteLine("Código Não encontrado");
                            }
                        }
                    }
                    else if (escolha == 3)
                    {
                        Console.WriteLine("Digite o fornecedor que deseja encontrar: ");
                        fornecedor = Console.ReadLine();
                        foreach (var item in produto)
                        {
                            if (fornecedor == item.Fornecedor)
                            {
                                Console.WriteLine("\n\n**********************");
                                Console.WriteLine("Nome: " + item.Nome);
                                Console.WriteLine("Nome: " + item.Codigo);
                                Console.WriteLine("Nome: " + item.Cor);
                                Console.WriteLine("Nome: " + item.Validade);
                                Console.WriteLine("Nome: " + item.Preço);
                                Console.WriteLine("Nome: " + item.Fornecedor);
                                Console.WriteLine("Nome: " + item.Modelo);
                                Console.WriteLine("Nome: " + item.Medida);
                                Console.WriteLine("Nome: " + item.Tamanho);
                                Console.WriteLine("Nome: " + item.Peso);
                                Console.WriteLine("******************************");
                            }
                        
                            else
                            {
                                Console.WriteLine("Fornecedor Não encontrado");
                            }
                        }
                    }
                    else if (escolha == 4)
                    {
                        Console.WriteLine("Digite o preço que deseja encontrar: ");
                        preço = Convert.ToDouble(Console.ReadLine());
                        foreach (var item in produto)
                        {
                            if (preço == item.Preço)
                            {
                                Console.WriteLine("\n\n**********************");
                                Console.WriteLine("Nome: " + item.Nome);
                                Console.WriteLine("Nome: " + item.Codigo);
                                Console.WriteLine("Nome: " + item.Cor);
                                Console.WriteLine("Nome: " + item.Validade);
                                Console.WriteLine("Nome: " + item.Preço);
                                Console.WriteLine("Nome: " + item.Fornecedor);
                                Console.WriteLine("Nome: " + item.Modelo);
                                Console.WriteLine("Nome: " + item.Medida);
                                Console.WriteLine("Nome: " + item.Tamanho);
                                Console.WriteLine("Nome: " + item.Peso);
                                Console.WriteLine("******************************");
                            }
                        
                            else
                            {
                                Console.WriteLine("Preço Não encontrado");
                            }
                        }
                    }
                    else if (escolha == 5)
                    {
                        Console.WriteLine("Digite o fornecedor que deseja encontrar: ");
                        modelo = Console.ReadLine();
                        foreach (var item in produto)
                        {
                            if (modelo == item.Modelo)
                            {
                                Console.WriteLine("\n\n**********************");
                                Console.WriteLine("Nome: " + item.Nome);
                                Console.WriteLine("Nome: " + item.Codigo);
                                Console.WriteLine("Nome: " + item.Cor);
                                Console.WriteLine("Nome: " + item.Validade);
                                Console.WriteLine("Nome: " + item.Preço);
                                Console.WriteLine("Nome: " + item.Fornecedor);
                                Console.WriteLine("Nome: " + item.Modelo);
                                Console.WriteLine("Nome: " + item.Medida);
                                Console.WriteLine("Nome: " + item.Tamanho);
                                Console.WriteLine("Nome: " + item.Peso);
                                Console.WriteLine("******************************");
                            }
                        
                            else
                            {
                                Console.WriteLine("Modelo Não encontrado");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Operação inválida ou Não tem nada na lista.");
                    }
                }
                else if (menu == 3)
                {

                    Console.WriteLine("Dados da lista:");
                    foreach (var item in produto)
                    {
                        Console.WriteLine("\n\n**********************");
                        Console.WriteLine("Nome: " + item.Nome);
                        Console.WriteLine("Nome: " + item.Codigo);
                        Console.WriteLine("Nome: " + item.Cor);
                        Console.WriteLine("Nome: " + item.Validade);
                        Console.WriteLine("Nome: " + item.Preço);
                        Console.WriteLine("Nome: " + item.Fornecedor);
                        Console.WriteLine("Nome: " + item.Modelo);
                        Console.WriteLine("Nome: " + item.Medida);
                        Console.WriteLine("Nome: " + item.Tamanho);
                        Console.WriteLine("Nome: " + item.Peso);
                        Console.WriteLine("******************************");
                    }
                }
                else
                {
                    Console.WriteLine("Operação inválida.");
                }
            }
        }
    }
}
