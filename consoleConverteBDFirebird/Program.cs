using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleConverteBDFirebird
{
    class Program
    {
        static void Main(string[] args)
        {
            // Contexto do banco de dados SQL Server
            // mapeado para a classe Produto
            Contexto contexto = new Contexto();

            // classe que acessa a base Firebird
            AcessaBDFirebird bancoFB = new AcessaBDFirebird();

            // recebe os registro do banco Firebird
            var produtos = bancoFB.Consultar();

            foreach (var produto in produtos)
            {
                // Adiciona os produtos na base SQL Server
                contexto.produtos.Add(produto);
                contexto.SaveChanges();
            }                        

            Console.ReadLine();
        }
    }
}
