using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ByteBank {
	public class Cliente {
		public string Nome { get; set; }
		public string Cpf { get; set; }
		public string Profissao { get; set; }
		public Endereco Endereco { get; set; } = new Endereco();
	}

	public class Endereco {
		public string EnderecoCompleto { get; set; }
		public int Numero { get; set; }
	}
}
