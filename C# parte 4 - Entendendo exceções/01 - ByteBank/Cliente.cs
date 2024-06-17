using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___ByteBank {
	public class Cliente {
		// declara uma variavel privada chamada cpf
		private string _cpf;

		// define nome
		public string Nome { get; set; }

		// armazena o valor do cpf, e valida o cpf
		public string CPF {
			get {
				return _cpf;
			}
			set {
				// Escrevo minha lógica de validação de CPF
				_cpf = value;
			}
		}

		// permite que vc obtenhaou defina a profissao do cliente
		public string Profissao { get; set; }
	}
}
