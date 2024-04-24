using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank {
	// se no futuro eu quiser expandir, por exmeplo o CPF:

	// private string _cpf;

	//          public string CPF {
	//               get{
	//	                   return _cpf;
	//                  }
	//               set {
                           // Escrevo minha logica de validacao de CPF
	//	                   _cpf = value;
	//                    }
	//            }

	public class Cliente { // internal class: private, so pode ser acessada dentro do msm arquivo codigo fonte
		// posso usar prop e tab e vai preenchendo automatico (é um recurso do visual studio)
		public string Nome { get; set; }
		public string CPF { get; set; }
		public string Profissao { get; set; }
		public Endereco Endereco { get; set; } = new Endereco(); // atualizar com o método get e set e ainda manter o new endereço aqui
	}

	public class Endereco {
		public string EnderecoCompleto { get; set; }
		public int Numero { get; set; }
	}
}
