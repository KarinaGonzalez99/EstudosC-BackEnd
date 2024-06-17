using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank {
	public class Cliente { // internal class: private, so pode ser acessada dentro do msm arquivo codigo fonte
		public string nome;
		public string cpf;
		public string profissao;
		public Endereco endereco = new Endereco(); // iniciando dentro da propria classe
	}

	public class Endereco {
		public string endereco;
		public int numero;
	}
}
