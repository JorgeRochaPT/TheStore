using System;
using System.Collections.Generic;

namespace TheStore
{
    class Program
    {
        static void Main(string[] args)
        {
            bool close = false;
            List<Cliente> clientes = new();

            double pagamento(int codigo_cartao, int total_pontos)
            {
                double total = 0;
                int quantidade;
                double preço;
                bool finalizar = false;
                do
                {
                    Console.WriteLine(" 1) Adicionar produto ao Pagamento");
                    Console.WriteLine(" 2) Finalizar pagamento\n");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.WriteLine("Escreva o codigo do artigo\n");

                            //chamar variavel para saber o preço do artigo (alterar o valor 10 para a chamada da funçao)
                            preço = 10;
                            Console.WriteLine("Quantidade\n");
                            quantidade = Convert.ToInt32(Console.ReadLine());
                            double pagamento = (quantidade * preço);
                            total = total + pagamento;
                            break;
                        case "2":
                            Console.WriteLine("Total a Pagar -> " + total + " euros\n");

                            if (total >= 50)
                            {
                                total_pontos = total_pontos + 3;
                                Console.WriteLine("Foram adicionados mais 3 pontos ao cartão -> " + codigo_cartao + " tendo o total de " + total_pontos + "\n");

                            }


                            finalizar = true;
                            break;
                    }
                } while (finalizar == false);



                return total;
            }

            //Menu Principal
            do
            {

                Console.WriteLine("Selecione uma opção");
                Console.WriteLine("1) Gerir Artigos");
                Console.WriteLine("2) Gerir Pontos Cliente");
                Console.WriteLine("3) Descarregar Listar de Artigos");
                Console.WriteLine("4) Pagamento");
                Console.WriteLine("5) Fechar");

                Console.Write("\r\nSelecione uma opção: ");


                switch (Console.ReadLine())
                {
                    // Selecionar Gerir Artigos
                    case "1":
                        Console.WriteLine("\r\n1) Adicionar Artigo");
                        Console.WriteLine("2) Eliminar Artigo");
                        Console.WriteLine("3) Listar Artigos");
                        Console.WriteLine("4) Fechar");

                        Console.Write("\r\nSelecione uma opção: ");

                        switch (Console.ReadLine())
                        {
                            case "1":
                                break;
                            case "2":
                                break;
                            case "3":
                                break;
                            case "4":
                                close = true;
                                break;

                        }
                        break;

                    // Selecionar Gerir Pontos Cliente
                    case "2":
                        Console.WriteLine("\r\n1) Criar Cliente");
                        Console.WriteLine("2) Consultar Compras de um Cartão");
                        Console.WriteLine("3) Consultar Saldo e Pontos de um Cartão");
                        Console.WriteLine("4) Fechar");

                        Console.Write("\r\nSelecione uma opção: ");

                        switch (Console.ReadLine())
                        {
                            case "1":
                                //Cliente cliente = new();
                                Cliente cliente = new();
                                Console.WriteLine("Indique o seu nome: ");
                                cliente.Nome = Console.ReadLine();
                                Console.WriteLine("Indique a sua morada: ");
                                cliente.Morada = Console.ReadLine();
                                Console.WriteLine("Indique o seu email: ");
                                cliente.Email = Console.ReadLine();
                                Console.WriteLine("Indique o seu NIF: ");
                                cliente.Nif = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Indique o número de telefone:");
                                cliente.Telefone = Convert.ToInt32(Console.ReadLine());
                                cliente.idcartao = 10;
                                clientes.Add(cliente);



                                break;
                            case "2":
                                break;
                            case "3":
                                break;
                            case "4":
                                close = true;
                                break;

                        }
                        break;
                    case "3":
                        Console.Write("\r\nAinda Sem Ficheiro");
                        break;

                    // Pagamento
                    case "4":


                        pagamento(10, 20);

                        break;
                    case "5":
                        close = true;
                        break;

                }
            } while (close == false);

            Environment.Exit(0);

        }
    }
}
