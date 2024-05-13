using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// pra usar o FileStream usamos o:
using System.IO; // IO = Input e Output


namespace ByteBankImportacaoExportacao {
	partial class Program {
		static void Main(string[] args) {

			//LidandoComFileStreamDiretamente();
			//CriarArquivoComWriter();
			//TestaEscrita();
			//EscritaBinaria();
			//LeituraBinaria();
			UsarStreamDeEntrada();
			Console.ReadLine();
		}

		static void EscreverBuffer(byte[] buffer) {
			// decodificando os bytes em um texto, sem isso tonhamos varios numeros jogados na tela, e com isso acgora conseguimos ver os itens de dentro do arquivo
			var utf8 = Encoding.Default; // é o padrao do sistema operacional(deafult)
										 // a partir dessa decodificação eu quero que ela seja uma string
			var texto = utf8.GetString(buffer);
			Console.Write(texto);

			//
			//foreach (var meuByte in buffer)
			//{
			// pra vermos tudo numa linha se não nosso terminal vai ter mtaaaasss linhas(write)
			//    Console.Write(meuByte);
			//    Console.Write(" ");
			//}
		}

		static void BackupDoEstudoAnterior() {

			//var textoComQuebraDeLinha = "Minha primeira linha \n (usamos \\n), PRA IR PRA OUTRA LINHA) \n minha terceira linha \nminha quarta linha";
			//Console.WriteLine(textoComQuebraDeLinha);
			//Console.ReadLine();



			// devemos colocar onde temos o executavel, pois é onde a aplicacao busca(bin ---> debug)
			var enderecoDoArquivo = "contas.txt";
			// criar um fluxo que vai possibilitar que acesse esse arquivo e vá percorrer os bytes que percorrem ele
			/*var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);*/ // FileMode: estamos indicando o modo de abrir e olhar o que tem 

			// por baixo dos panos ele ta executando o close.
			// using serve pra garantir q os recursos n gerenciados sejam liberados de forma adequada, mesmo com ocorrencia de exceções.
			// esse método é mais usado com objetos que implementam a  interface IDisposable
			using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open)) {
				// o buffer é criado para receber informações temporarias
				var buffer = new byte[1024]; // 1 kb
				var numeroDeBytesLidos = -1; // -1 inicialização segura pra não atrapalhar

				while (numeroDeBytesLidos != 0) {
					// com base naquele arquivo de contas com varias contas, leia do 0 ao 1024
					numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
					EscreverBuffer(buffer);
				}

			}

			// qualquer fluxo de dados stream, vamos ter que usar o método Close, ou podemos usar o metodo using, evitando que caso haja uma exceção ele de close de qualquer forma e não fique travado ^^^^
			// fazemos isso pra depois de executar pelos panos ele fechar e o usuario poder fazer alterações
			// fluxoDoArquivo.Close();
		}

	}
}
