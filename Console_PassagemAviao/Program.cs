using System;

namespace Console_PassagemAviao
{
    class Program
    {
        static void Main(string[] args)
        {

            int i2 = 0;
            string resposta = "s";
            string[] passagens = new string[5];
            int senha;
            bool check = false;
            bool check2 = false;
            string[] nome = new string[5];
            string[] origem = new string[5];
            string[] destino = new string[5];
            string[] data = new string[5];


            while (check == false)
            {
                Console.WriteLine("Insira a senha para entrar no sistema");
                senha = int.Parse(Console.ReadLine());

                if (senha == 123456)
                {
                    while (check2 == false)
                    {

                        Console.WriteLine($"Menu \n Digite 1 para cadastrar uma passagem \n Digite 2 para listar as passagens cadastradas \n Digite 0 para sair");
                        string opcao = Console.ReadLine();


                        if (opcao == "1")
                        {

                            for (var i = 0; i <= 5; i++)
                            {
                                Console.WriteLine($"Menu de Cadastro: \n");
                                Console.WriteLine("Digite o seu Nome Completo");
                                nome[i2] = Console.ReadLine().ToUpper();
                                Console.WriteLine("Digite a Origem do voo");
                                origem[i2] = Console.ReadLine().ToUpper();
                                Console.WriteLine("Digite o destino do voo");
                                destino[i2] = Console.ReadLine().ToUpper();
                                Console.WriteLine("Digite a data do voo -> DD/MM/AAAA");
                                data[i2] = Console.ReadLine().ToUpper();
                                Console.WriteLine("Deseja cadastrar outro passageiro? (S/N)");
                                resposta = Console.ReadLine().ToLower();
                                i2++;
                                Console.WriteLine("PASSAGEM CADASTRADA!");
                                if (resposta == "n")
                                {
                                    break;
                                }
                            }
                        }

                        else if (opcao == "2")
                        {
                            for (var i = 0; i < i2; i++)
                            {
                                Console.WriteLine($"{i + 1}ª Passagem Cadastrada: ");
                                Console.WriteLine(nome[i]);
                                Console.WriteLine(origem[i]);
                                Console.WriteLine(destino[i]);
                                Console.WriteLine(data[i]);
                            }
                        }
                        else if (opcao == "0")
                        {
                            break;
                        }
                        else
                        {
                            check2 = false;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Senha incorreta!! Digite Novamente");
                }
            }
        }
    }
}
