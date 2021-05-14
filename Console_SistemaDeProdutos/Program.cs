using System;

namespace Console_SistemaDeProdutos
{
    class Program
    {
        static int produtos = 0;
        static int tamanhoArray = 5;
        static string resposta = "s";
        static string  s;
        static string  n;
        static string[] nome = new string[tamanhoArray];
        static float[] preco = new float[tamanhoArray];
        static bool[] promocao = new bool[tamanhoArray];
        static int c = 0;
        static void Main(string[] args)
        {
            do
            {
                MostrarMenu();
                string opcao = Console.ReadLine();

                if (produtos > tamanhoArray)
                {
                    tamanhoArray = produtos;
                    nome = new string[tamanhoArray];
                    preco = new float[tamanhoArray];
                    promocao = new bool[tamanhoArray];
                }
                switch (opcao)
                {
                    case "1":
                        do
                        {
                            if (c < tamanhoArray)
                            {
                                Console.WriteLine("Digite o nome do produto: ");
                                nome[c] = Console.ReadLine();

                                Console.WriteLine("Digite o preço do produto: ");
                                preco[c] = float.Parse(Console.ReadLine());

                                Console.WriteLine("O produto esta em promoção? (S/N)");
                                string estaPromocao = Console.ReadLine().ToLower();

                                if (estaPromocao == "s")
                                {
                                    promocao[c] = true;
                                }
                                else
                                {
                                    promocao[c] = false;
                                }
                                Console.WriteLine("Você desja cadastrar outro produto? (S/N)");
                                resposta = Console.ReadLine().ToLower();

                                c++;
                            }
                            else
                            {
                                Console.WriteLine("O limite de produtos foi atingido!");
                                resposta = "n";

                            }
                        } while (resposta == "s");

                        break;
                    case "2":
                    for (var i = 0; i < c; i++)
                    {
                        if (promocao[i] == true)
                        {
                            s = "O produto esta em promoção!";
                        }
                        else
                        {
                            s = "O produto não esta em promoção!";
                        }
                        Console.WriteLine($"{i + 1}º Produto");
                        Console.WriteLine($"Nome: {nome[i]}");
                        Console.WriteLine($"Preço: R${preco[i]}");
                        Console.WriteLine($"Promoção: {s}");
                    }
                        break;
                        case "0":
                        Console.WriteLine("Obrigado por utilizar nosso sistema!");
                        resposta = "s";
                        break;

                    default:
                    Console.WriteLine("Valor Invalido!! Digite um valor válido");
                        break;
                }
            } while (resposta == "n");
        }
        static void MostrarMenu()
        {
            Console.WriteLine("Escolha uma das opções: \n 1 - Cadastar Produto \n 2 - Listar Produtos Cadastrados \n 0 - Sair");

        }
    }
}
