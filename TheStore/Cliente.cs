using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStore
{
    class Cliente
    {
        public string Nome { get; set; }

        public string Morada { get; set; }

        public string Email { get; set; }

        public int Nif { get; set; }

        public int Telefone { get; set; }

    }
    class cartao : Cliente
    {

        public int IDcartao { get; set; }

        public int Pontos { get; set; }

        public double SaldoTotal { get; set; }

    }

    public void CriarCliente()
    {
        Console.WriteLine("Indique o seu nome: ");
        Cliente.Nome = Console.ReadLine;
        Console.WriteLine("Indique a sua morada: ");
        Cliente.Morada = Console.ReadLine;
        Console.WriteLine("Indique o seu email: ");
        Cliente.Email = Console.ReadLine;
        Console.WriteLine("Indique o seu NIF: ");
        Cliente.Nif = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Indique o número de telefone:");
        Cliente.Telefone = Convert.ToInt32(Console.ReadLine());
    }



    public void CriarCartao()
    {
        Console.WriteLine("Indique o número de telefone:");
        cartao.IDcartao = Convert.ToInt32(Console.ReadLine())
    //criar if statement
}



    public void ConsultarCompras()
    {



    }

    public void ConsultarSaldo()
    {



    }

}

