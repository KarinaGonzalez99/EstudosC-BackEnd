using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia {
	public class ExtratorValorDeArgumentosURL {

		private readonly string _argumentos;
		public string URL { get; }

		// ctor pra completar
		public ExtratorValorDeArgumentosURL(string url) {
			if (string.IsNullOrEmpty(url)) {
				throw new ArgumentException("O argumento url não pode ser nulo ou vazio", nameof(url));
			}

			int indiceInterrogacao = url.IndexOf('?');
			_argumentos = url.Substring(indiceInterrogacao + 1);

			URL = url;
		}

		public string GetValor(string nomeParametro) {
			nomeParametro = nomeParametro.ToUpper();
			string argumentoEmCaixaAlta = _argumentos.ToUpper();
			// Concatena o nome do parâmetro com o sinal de igual para formar o termo a ser buscado na URL
			string termo = nomeParametro + "=";
			// Encontra o índice onde o termo começa na string de argumentos
			int indiceTermo = argumentoEmCaixaAlta.IndexOf(termo);

			// Se o termo não foi encontrado na string de argumentos, retorna uma string vazia
			if (indiceTermo == -1) {
				return "";
			}

			// Encontra o próximo índice do caractere '&' após o termo na string de argumentos
			int indiceEComercial = argumentoEmCaixaAlta.IndexOf('&', indiceTermo);

			// Se não houver um '&' após o termo, retorna o restante da string de argumentos a partir do índice do termo
			if (indiceEComercial == -1) {
				return argumentoEmCaixaAlta.Substring(indiceTermo + termo.Length);
			}

			// Remove tudo a partir do índice do '&' e, em seguida, retorna a substring entre o índice do termo e o índice do '&'
			return argumentoEmCaixaAlta.Remove(indiceEComercial).Substring(indiceTermo + termo.Length);
		}


	}
}
