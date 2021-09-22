using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStore
{
    class Cliente
    {
        public Cliente() { }
        public Cliente(string n, string m, string e, int nif, int t)
        {
            Nome = n;
            Morada = m;
            Email = e;
            Nif = nif;
            Telefone = t;
        }

        public string Nome { get; set; }
        public string Morada { get; set; }
        public string Email { get; set; }
        public int Nif { get; set; }
        public int Telefone { get; set; }

        private static int IDcartao = 100;

        public int idcartao
        {
            get { return IDcartao; }
            set { IDcartao = value; }
        }

        //public int IDcartao { get; set; }
        public int Pontos { get; set; }
        public double SaldoTotal { get; set; }

    }
    //class cartao : Cliente
    //{
    //    public cartao() { }
    //    public cartao(string n, string m, string e, int nif, int t, int i, int p, double s) : base(n, m, e, nif, t)
    //    {
    //        IDcartao = i;
    //        Pontos = p;
    //        SaldoTotal = s;
    //        Nome = n;
    //        Morada = m;
    //        Email = e;
    //        Nif = nif;
    //        Telefone = t;
    //    }
    //    private static int IDcartao = 100;

    //    public int idcartao
    //    {
    //        get { return IDcartao; }
    //        set { IDcartao = value; }
    //    }

    //    //public int IDcartao { get; set; }
    //    public int Pontos { get; set; }
    //    public double SaldoTotal { get; set; }






    //}

    //    public void CriarCliente()
    //    {
    //        Console.WriteLine("Indique o seu nome: ");
    //        Cliente.Nome = Console.ReadLine;
    //        Console.WriteLine("Indique a sua morada: ");
    //        Cliente.Morada = Console.ReadLine;
    //        Console.WriteLine("Indique o seu email: ");
    //        Cliente.Email = Console.ReadLine;
    //        Console.WriteLine("Indique o seu NIF: ");
    //        Cliente.Nif = Convert.ToInt32(Console.ReadLine());
    //        Console.WriteLine("Indique o número de telefone:");
    //        Cliente.Telefone = Convert.ToInt32(Console.ReadLine());



    //        Cliente cliente = new();
    //        Console.WriteLine("Escreva um nome");
    //        cliente.Nome = Console.ReadLine();
    //        Console.WriteLine("Escreva idade");
    //        cliente.Idade = Convert.ToInt32(Console.ReadLine());
    //        Console.WriteLine("Escreva morada");
    //        cliente.Morada = Console.ReadLine();
    //        Console.WriteLine("Escreva o numero de telemovel");
    //        cliente.Telemovel = Convert.ToInt32(Console.ReadLine());
    //        lista.Add(cliente);
    //    }



    //    public void CriarCartao()
    //    {
    //        Console.WriteLine("Indique o número de telefone:");
    //        cartao.IDcartao = Convert.ToInt32(Console.ReadLine());
    //        //criar if statement
    //    }



    //    public void ConsultarCompras()
    //    {



    //    }

    //    public void ConsultarSaldo()
    //    {



    //    }

}

