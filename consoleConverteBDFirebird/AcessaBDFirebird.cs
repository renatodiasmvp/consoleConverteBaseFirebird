using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace consoleConverteBDFirebird
{
    public class AcessaBDFirebird
    {
        static string stringConexao = "User = SYSDBA;Password=masterkey;Database=C:\\SGBR\\Master\\BASESGMASTER.FDB;DataSource=localhost;Port = 3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=15;Pooling=True;MinPoolSize = 0;MaxPoolSize=50;Packet Size=8192;ServerType=0;";

        public FbConnection conexaoFirebird = new FbConnection(stringConexao);

        public void Conectar()
        {
            conexaoFirebird.Open();
        }

        public List<Produto> Consultar()
        {
            string instrucao = "select CONTROLE, PRODUTO, CODBARRAS, UNIDADE, PRECOCUSTO, PERLUCRO, PRECOVENDA, FORNECEDOR, QTDEMINIMA, QTDE, REFERENCIA from TESTOQUE";

            List<Produto> produtos = new List<Produto>();
            Conectar();
            FbCommand comando = new FbCommand(instrucao, conexaoFirebird);
            comando.Transaction = this.conexaoFirebird.BeginTransaction(System.Data.IsolationLevel.RepeatableRead);
            
            FbDataReader leitor = comando.ExecuteReader();
            while (leitor.Read())
            {
                Produto produto = new Produto();
                produto.Id_fiscal = (string)leitor["CONTROLE"];
                produto.Nome = (string)leitor["PRODUTO"];
                produto.Barras = (string)leitor["CODBARRAS"];
                produto.Aplicacao = (string)leitor["REFERENCIA"];
                produto.Localizacao = "";
                produto.NOriginal = "N/C";
                produto.Grupo = "";
                produto.SubGrupo = "";
                produto.Unidade = (string)leitor["UNIDADE"];
                produto.Minimo = (string)leitor["QTDEMINIMA"];
                produto.Custo = (string)leitor["PRECOCUSTO"];
                produto.Venda = (string)leitor["PRECOVENDA"];
                produto.Margem = (string)leitor["PERLUCRO"];
                produto.Suplente1 = "";
                produto.Suplente2 = "";
                produto.Suplente3 = "";
                produto.Suplente4 = "";
                produto.Suplente5 = "";
                produto.Suplente6 = "";
                produto.Fornecedor = "";
                produto.Adicional = "";

                produtos.Add(produto);

            }
            leitor.Close();

            comando.Dispose();

            return produtos;

        }
    }
}
