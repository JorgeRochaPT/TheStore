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
    }

