using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStore
{
    class Artigo
    {
        public int cod_artigo { get; set; }
        public string nome { get; set; }
        public double preco { get; set; }
        public int quantidade { get; set; }

    }
    static void guardarproduto(int cod_artigo, string nome, double preco, int quantidade)
    {
        Console.WriteLine("Insira os dados do produto\n");
        Console.Write("Codigo do produto: ");
        cod_artigo = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nome ");
        nome = Console.ReadLine();
        Console.Write("Preço: ");
        preco = Convert.ToInt32(Console.ReadLine());
        Console.Write("Quantidade: ");
        quantidade = Convert.ToInt32(Console.ReadLine());

    }

    //funcao para guardar produto


    //gravar os dados no ficheiro txt

    string ficheiro = @"produtos.txt";
    StreamWriter sw;
if (File.Exists(ficheiro) == true )
{
    sw = File.AppendText(ficheiro);
}
else
{
    sw = File.CreateText(ficheiro);

}
string linha = num.ToString() + ";" + cod_artigo + ";" + nome;
sw.WriteLine(linha);
sw.Close();


// consultar dados do ficheiro
static void verprodutos()
{
    string ficheiro = @"produtos.txt";
    StreamReader sr;
    if (File.Exists(ficheiro) == true)
    {
        Console.WriteLine("cod_prod\t\nome produto\tttt\t\");
        sr = File.OpenText(ficheiro);
        string linha = "";
        while ((linha = sr.ReadLine()) != null)
        {

        }
    }
    else
    {
        Console.WriteLine("Nao existe nenhum ficheiro");
    }
}

}