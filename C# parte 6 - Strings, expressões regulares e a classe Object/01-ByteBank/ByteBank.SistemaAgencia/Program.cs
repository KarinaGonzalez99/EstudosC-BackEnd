using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

// humanizer nao estava indo pois a minha versão é a 4.8 e não

namespace ByteBank.SistemaAgencia {
	internal class Program {
		static void Main(string[] args) {
			string url = "pagina?argumentos";
			// agora temos dois parametros
			string url2 = "pagina?moedaOrigem=real&moedaDestino=dolar";

			// TESTANDO IS NULL OR EMPTY
			// vazia
			string urlEmpty = "";
			// nulo
			string urlNull = null;
			Console.WriteLine($"(T)Essa url é vazia? {string.IsNullOrEmpty(urlEmpty)}");
			Console.WriteLine($"(T)Essa url é nula? {string.IsNullOrEmpty(urlNull)}");
			Console.WriteLine($"(F)Essa url é nula ou vazia? {string.IsNullOrEmpty(url)}");
			Console.WriteLine();

			// TESTANDO O INDEX OF
			string palavra = "moedaDestino=real";
			int indice = palavra.IndexOf("real");
			Console.WriteLine($"O indice da palavra real é: {indice}");
			Console.WriteLine($"O valor a partir do indice 13 é: {palavra.Substring(13)}");
			Console.WriteLine();

			// TESTANDO O LENGTH
			string palavra2 = "moedaOrigem=real&moedaDestino=dolar";
			string nomeArgumento = "moedaDestino";
			int indice2 = palavra2.IndexOf(nomeArgumento);

			Console.WriteLine($"A string que queremos: {palavra2.Substring(indice2)}");
			Console.WriteLine($"A string a partir de onde queremos é: {palavra2.Substring(indice2 + nomeArgumento.Length + 1)}");
			Console.WriteLine();

			// Vamos verificar dentro da string de url, qual o indice da interrogração
			int indiceInterrogacao = url.IndexOf('?');
			Console.WriteLine($"O indice do ? é: {indiceInterrogacao}");
			Console.WriteLine($"A url padrão/inicial de teste é: {url}");

			// Essa maneira não da certo, pq string é imutavel, pra isso funcionar teria que}
			// criar uma nova variavel, e ai sim armazenar o novo valor
			// url.Substring(6);
			// Console.WriteLine(url);
			string argumentos = url.Substring(6);
			Console.WriteLine($"O valor depois do ? da url é: {argumentos}");
			Console.WriteLine();

			// TESTANDO METODO DA CLASSE EXTRATOR VALOR DE ARGUMENTO URL
			//string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar";
			//ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);
			//// se escolhermos a moeda origem ele pega tudo dps do & então pra isso devemos usar o remove
			//string valor = extratorDeValores.GetValor("moedaDestino");
			//Console.WriteLine($"O valor de moedaDestino, utilizando o método da classe é: {valor}");
			//Console.WriteLine();
			// TESTANDO O METODO REMOVE: e ^^^^
			string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar";
			ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);
			string valor = extratorDeValores.GetValor("moedaDestino");
			string valorMoedaOrigem = extratorDeValores.GetValor("moedaOrigem");
			Console.WriteLine("Valor de moedaDestino: " + valor);
			Console.WriteLine("Valor de moedaOrigem: " + valorMoedaOrigem);
			Console.WriteLine();

			// Exceção de alteração de string é quando usamos o +=
			// por baixo dos panos, ele cria uma variavel temporaria
			// e dps atribui a nossa referencia
			// url += '"sufixo"; === :
			// string temporaria = url + "sufixo"; === :
			// url = temporaria

			// TESTANDO O REPLACE COM O METODO TO LOWER E TO UPPER:
			string mensagemOrigem = "PALAVRA";
			string termoBusca = "ra";
			Console.WriteLine(termoBusca);
			termoBusca = termoBusca.Replace('r', 'R');
			Console.WriteLine(termoBusca);
			termoBusca = termoBusca.Replace('a', 'A');
			Console.WriteLine(termoBusca);

			string termoBusca2 = "ra";
			Console.WriteLine(termoBusca2);
			Console.WriteLine(termoBusca2.ToUpper());
			Console.WriteLine(termoBusca2.ToLower());
			Console.WriteLine(mensagemOrigem.ToLower());
			Console.WriteLine();

			// TESTANDO O STARTS WITH/ENDS WITH E CONTAINS:
			string urlTeste = "https://www.bytebank.com/cambio";
			Console.WriteLine($"A url inicia com https://www.bytebank.com? {urlTeste.StartsWith("https://www.bytebank.com")}");
			Console.WriteLine($"A url termina com cambio? {urlTeste.EndsWith("cambio")}");
			Console.WriteLine($"A url contem bytebank? {urlTeste.Contains("bytebank")}");
			Console.WriteLine();

			// UTILIZANDO REGEX (REGULAR EXPRESSIONS):
			// criaremos o padrão - mas ele ta mto grande iremos simplificar
			//string padrao = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
			//string padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
			//string padrao = "[0-9]{4,5}[-][0-9]{4}";// 4,5 se dá caso seja um numero de celular
			//string padrao = "[0-9]{4,5}-{0,1}[0-9]{4}";// 0,1 se da caso tenha -
			string padrao = "[0-9]{4,5}-?[0-9]{4}";// ? substitui o 0,1
			string textoDeTeste = "Meu nome é Karina, me ligue em 94002-8922";
			// removi o - pra ver se passa no padrão
			string textoDeTeste2 = "Meu nome é Karina, me ligue em 40028922";

			// is match pra ver se o padrão bate com o que temos
			Console.WriteLine($"Está de acordo com o padrão is match? {Regex.IsMatch(textoDeTeste, padrao)}");
			Console.WriteLine($"Está de acordo com o padrão is match? {Regex.IsMatch(textoDeTeste2, padrao)}");

			// match, define as propriedades do texto que encontramos
			Match resultado = Regex.Match(textoDeTeste, padrao);
			Console.WriteLine($"O resultado do match é: {resultado.Value}");
			Console.WriteLine();

			// TESTANDO METODO EQUALS:
			Cliente carlos = new Cliente();
			carlos.Nome = "Carlos";

			Cliente carlos2 = new Cliente();
			carlos.Nome = "Carlos";

			// não sao iguais
			//if(carlos == carlos2) {
			//	Console.WriteLine("São iguais!");
			//} else { 
			//Console.WriteLine("Não são iguais!");
			//}

			// em clientes definimos:
			// public override bool Equals(object obj) {
			// Cliente outroCliente = obj as Cliente;
			//return
			//Nome == outroCliente.Nome
			//}

			if (carlos.Equals(carlos2)) {
				Console.WriteLine("São iguais!");
			}
			else {
				Console.WriteLine("Não são iguais!");
			}

		}
	}
}
