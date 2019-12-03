using System;

namespace Ex1trabalho
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[2, 2];
            int linha = 0, coluna = 0,maior = 0,menor = 0, soma = 0;
            double media = 0;
            //alimentando o array 
            for (linha = 0; linha < 2 ; linha++)
            {
                for (coluna = 0; coluna < 2; coluna++)
                {
                    Console.WriteLine("Digite a sua média: ");
                    array[linha, coluna] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //Calculando a média final, procurando o maior e o menor numero
            for (linha = 0; linha < 2; linha++)
            {
                for (coluna = 0; coluna < 2; coluna++)
                {
                    soma += array[linha, coluna];

                    if (maior == 0)
                    {
                        maior = array[linha, coluna];
                    }
                    else if (maior < array[linha,coluna])
                    {
                        maior = array[linha, coluna];
                    }

                    if (menor == 0)
                    {
                        menor = array[linha, coluna];
                    }
                    else if (menor > array[linha, coluna])
                    {
                        menor = array[linha, coluna];
                    }
                }
            }
            media = soma / 10;
            Console.WriteLine("Média Geral: " + media);
            Console.WriteLine("O maior valor é: " + maior);
            Console.WriteLine("O menor valor é: " + menor);
        }
    }
}
