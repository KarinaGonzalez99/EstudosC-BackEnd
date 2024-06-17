using _01_DesingPatterns2.Cap1;
using _01_DesingPatterns2.Cap2;
using _01_DesingPatterns2.Cap3;
using _01_DesingPatterns2.Cap4;
using _01_DesingPatterns2.Cap5;
using _01_DesingPatterns2.Cap6;
using _01_DesingPatterns2.Cap7;
using _01_DesingPatterns2.Cap8;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _01_DesingPatterns2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// PARTE 1:
			//IDbConnection conexao = new ConnectionFactory().GetConnection();
			// executar uma query dentro do banco de dados
			//IDbCommand cmd = conexao.CreateCommand();
			//cmd.CommandText = "select * from tabela";

			// ---------------------------------------------- | | ---------------------------------------------------

			// PARTE 2:
			//NotasMusicais notas = new NotasMusicais();
			//IList<INota> musica = new List<INota>()
			//{
			// mta frequencia de Fa, vc acaba gastando 3 espaço ao inves de reaproveitar
			//	notas.Pega("do"),
			//	notas.Pega("re"),
			//	notas.Pega("mi"),
			//	notas.Pega("fa"),
			//	notas.Pega("fa"),
			//	notas.Pega("fa"),
			//};
			//Piano piano = new Piano();
			//piano.Toca(musica);

			// ---------------------------------------------- | | ---------------------------------------------------

			// PARTE 3:
			//Historico historico = new Historico();
			//Contrato contratinho = new Contrato(DateTime.Now, "Karina", TipoContrato.Novo);
			//historico.Adiciona(contratinho.SalvaEstado());
			//contratinho.Avanca();
			//historico.Adiciona(contratinho.SalvaEstado());
			//contratinho.Avanca();
			//historico.Adiciona(contratinho.SalvaEstado());

			//         Console.WriteLine(historico.Pega(2).Contrato.Tipo);

			// ---------------------------------------------- | | ---------------------------------------------------

			// PARTE 4:
			//IExpressao esquerda = new Soma(new Numero(1), new Numero(10));
			//IExpressao direita = new Subtracao(new Numero(20), new Numero(10));

			//IExpressao soma = new Soma(esquerda, direita);

			//Console.WriteLine(soma.Avalia());

			// a maneira de cima já exist o metodo dentro do C#

			//Expression soma = Expression.Add(Expression.Constant(10), Expression.Constant(100));
			//Func<int> funcao = Expression.Lambda<Func<int>>(soma).Compile();
			//Console.WriteLine(funcao());

			// ---------------------------------------------- | | ---------------------------------------------------

			// PARTE 5:
			//IExpressao esquerda = new Soma(new Numero(1), new Numero(10));
			//IExpressao direita = new Subtracao(new Numero(20), new Numero(10));

			//IExpressao soma = new Soma(esquerda, direita);

			//Console.WriteLine(soma.Avalia());
			//Impressora impressora = new Impressora();
			//soma.Aceita(impressora);

			// ---------------------------------------------- | | ---------------------------------------------------

			// PARTE 6:
			//IMensagem mensagem = new MensagemAdministrativa("Victor");
			//IEnviador enviador = new EnviaPorEmail();
			//mensagem.Enviador = enviador;
			//mensagem.Envia();

			// ---------------------------------------------- | | ---------------------------------------------------

			// PARTE 7:
			//FilaDeTrabalho fila = new FilaDeTrabalho();
			//Pedido pedido1 = new Pedido("Mauricio", 100.0);
			//Pedido pedido2 = new Pedido("Marcelo", 200.0);
			//fila.Adiciona(new PagaPedido(pedido1));
			//fila.Adiciona(new PagaPedido(pedido2));

			//fila.Adiciona(new FinalizaPedido(pedido1));
			//fila.Processa();

			// ---------------------------------------------- | | ---------------------------------------------------
			// PARTE 8:
			Cliente cliente = new Cliente();
			cliente.Nome = "Karina";
			cliente.Endereco = "Rua Vergueiro";
			cliente.DataDeNascimento = DateTime.Now;
			//transformar em xml
			string xml= new GeradorDeXML().GeraXML(cliente);
            Console.WriteLine(xml);
        }
	}
}
