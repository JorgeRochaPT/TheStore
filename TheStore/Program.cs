using System;

namespace TheStore
{
    class Program
    {
        static void Main(string[] args)
        {
            bool close = false;

            static double pagamento( int codigo_cartao, int total_pontos)
            {
                double total = 0;
                int quantidade;
                double preço;

                Console.WriteLine(" 1) Adicionar produto ao Pagamento");
                Console.WriteLine(" 2) Finalizar pagamento");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Escreva o codigo do artigo");

                        //chamar variavel para saber o preço do artigo (alterar o valor 10 para a chamada da funçao)
                        preço = 10;
                        Console.WriteLine("Quantidade");
                        quantidade = Convert.ToInt32(Console.ReadLine());
                       
                        
                        double pagamento = (quantidade * preço);
                        total = total + pagamento;
                        break;
                    case "2":
                        
                        break;
                }

                
                

                return total;
            }


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
                    case "4":


                        pagamento();

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
