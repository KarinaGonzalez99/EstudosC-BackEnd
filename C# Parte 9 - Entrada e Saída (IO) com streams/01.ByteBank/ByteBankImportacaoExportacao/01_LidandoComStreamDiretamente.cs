using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//criamos para armazenarmos metodos
namespace ByteBankImportacaoExportacao {
	// ele reclama que já tem o program e que isso é uma duplicação (o que não é permitido)
	// nosso interesse é ter uma classe em que possamos distribuir metodos, membros e propriedades em 2 arquivos diferentes
	// a ideia é fazer o computadoe entender que é uma classe so, pra isso usamos o modificador partial
	// ai o computador entenderá que está classe é desenvolvida em uma serie de arquivos separados
	// precisaremos fazer essa indicação em todos os arquivos com o partial, inclusive no program
	partial class Program {
		static void LidandoComFileStreamDiretamente() {
			var enderecoDoArquivo = "contas.txt";

			using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open)) {
				// não quero lidar com bytes diretamente, vamos pegar então uma classe pra fazer essa leitura pra gnt
				var leitor = new StreamReader(fluxoDoArquivo);

				// enquanto não chegar no fim da stream eu quero le
				while (!leitor.EndOfStream) {
					var linha = leitor.ReadLine();

					var contaCorrente = ConverterStringParaContaCorrente(linha);

                    Console.WriteLine($"{contaCorrente.Titular.Nome}: Conta núimero {contaCorrente.Numero}, ag. {contaCorrente.Agencia}. Saldo {contaCorrente.Saldo}");

                    // podemos fazer ele ler até o fim, o ruim de usar ele é que ele sobrecarrega caso seja um arquivo mto grande
                    //var linha = leitor.ReadToEnd();
                    // podemos tbm usar o metodo read, mas ele não devolve a string, então ele retorna int, e sim o byte
                    //var linha = leitor.Read();
                    //Console.WriteLine(linha);
                }
			}


		}

		// vamos pegar essas string e separar elas em cada elemento
		static ContaCorrente ConverterStringParaContaCorrente(string linha) {
			// com basew no arquivo o que divide cada elemento é um espaço
			string[] campos = linha.Split(','); // array de string
			var agencia = campos[0];
			var numero = campos[1];
			// por conta do arquivo estar utilizando . e utilizarmos na verdade virgula ele ignora o ponto e deixa o numero inteiro, não podendo então diferenciar o que é o real e o centavo
			// pra isso vamos substituir o ponto por virgula
			var saldo = campos[2].Replace('.', ',');
			var nomeTitular = campos[3];

			// precisamos transformar o numero string em int, pra isso usamos parse
			var agenciaComoInt = int.Parse(agencia);
			var numeroComoInt = int.Parse(numero);
			var saldoComoDouble = double.Parse(saldo);
			var titular = new Cliente();
			titular.Nome = nomeTitular;

			var resultado = new ContaCorrente(agenciaComoInt, numeroComoInt);
			resultado.Depositar(saldoComoDouble);
			resultado.Titular = titular;

			return resultado;



		}


		static void EscreverBuffer(byte[] buffer, int bytesLidos) {
			var utf8 = Encoding.Default;

			var texto = utf8.GetString(buffer, 0, bytesLidos);
			Console.Write(texto);

			//foreach (var meuByte in buffer)
			//{
			//    Console.Write(meuByte);
			//    Console.Write(" ");
			//}
		}
	}
}