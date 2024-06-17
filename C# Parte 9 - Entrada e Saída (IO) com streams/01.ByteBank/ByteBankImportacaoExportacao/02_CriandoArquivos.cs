using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao {
	partial class Program {
		static void CriarArquivo() {
			var caminhoNovoArquivo = "contasExportadas.csv";

			// create pra criar arquivo
			using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create)) {
				var contaComoString = "456,78945,4785.50,Gustavo Santos";
				// pra fazer de string pra bytes é inverso tbm(urf 8 é o mais utilizado)
				var encoding = Encoding.UTF8;

				var bytes = encoding.GetBytes(contaComoString);

				fluxoDeArquivo.Write(bytes, 0, bytes.Length);
			}
		}

		// criando um metodo pra nao preceisarmops lidar diretamente com bytes no momento da criação do arquivo, ou seja, estamos substituindo ele no programs, e não precisamos lidar com bytes e propriedades
		static void CriarArquivoComWriter() {
			var caminhoNovoArquivo = "contasExportadas.csv";
			// o createnew ele ve se tem arquivo igual, se tiver ele apaga e cria um caminho novo em cima dele
			using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.CreateNew))
			// criando pra podermos escrever, não precisamos usar o encoding.utf8, pq ele tem o padrão, coloquei pra poder me lembrar
			using (var escritor = new StreamWriter(fluxoDeArquivo, Encoding.UTF8)) {
				escritor.Write("456,65465,456.0,Pedro");
			}
		}


		static void TestaEscrita() {
			var caminhoArquivo = "teste.txt";

			using (var fluxoDeArquivo = new FileStream(caminhoArquivo, FileMode.Create))
			using (var escritor = new StreamWriter(fluxoDeArquivo)) {
				for (int i = 0; i < 100; i++) {
					escritor.WriteLine($"Linha {i}");

					// porém eu descobri que se não usar o flush e nem o readline, o conteudo é despejado e de forma automatica com todo tamanho que colocarmos
					escritor.Flush(); // desepja o buffer para o stream

					Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter p adicionar mais uma!");
					Console.ReadLine();
				}
			}
		}
	}
}
