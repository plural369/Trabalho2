using System;
using System.Collections.Generic;

namespace Extrabalho3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<dados> fornecedor = new List<dados>();
            string continuar;

            continuar = "S";
            // alimentando a lista
            while (continuar.ToUpper() == "S")
            {
                var item = new dados();
                Console.WriteLine("Digite o Codigo: ");
                item.Codigo = Console.ReadLine();

                Console.WriteLine("Digite seu nome: ");
                item.Nome = Console.ReadLine();

                Console.WriteLine("Digite seu endereço: ");
                item.Endereco = Console.ReadLine();

                Console.WriteLine("Digite seu telefone: ");
                item.Telefone = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite seu CNPJ: ");
                item.CNPJ = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite seu CEP: ");
                item.CEP = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o Bairro onde mora: ");
                item.Bairro = Console.ReadLine();

                Console.WriteLine("Digite a Cidade onde mora: ");
                item.Cidade = Console.ReadLine();

                Console.WriteLine("Digite o Estado: ");
                item.Estado = Console.ReadLine();

                Console.WriteLine("Digite o Celular: ");
                item.Celular = Convert.ToInt32(Console.ReadLine());

                fornecedor.Add(item);

                Console.WriteLine("Digite S para continuar ou N para sair: ");
                continuar = Console.ReadLine();
            }
            //Sem ordenar
            Console.WriteLine("Sem ordenar:");
            apresenta(fornecedor);
            //Ordenado
            fornecedor.Sort();
            Console.WriteLine("Ordenando por nome:");
            apresenta(fornecedor);

        }

        private static void apresenta(List<dados> fornecedor) 
        {
            foreach (var item in fornecedor)
            {
                Console.WriteLine("\n\n***********************");
                Console.WriteLine("CNPJ: " + item.CNPJ);
                Console.WriteLine("Nome: " + item.Nome);
                Console.WriteLine("Telefone: " + item.Telefone);
                Console.WriteLine("Celular: " + item.Celular);
                Console.WriteLine("Bairro: " + item.Bairro);
                Console.WriteLine("Cidade: " + item.Cidade);
                Console.WriteLine("Estado: " + item.Estado);
                Console.WriteLine("Endereço: " + item.Endereco);
                Console.WriteLine("CEP: " + item.CEP);
                Console.WriteLine("Código: " + item.Codigo);
                Console.WriteLine("****************************");
            }
        }
    }
}
