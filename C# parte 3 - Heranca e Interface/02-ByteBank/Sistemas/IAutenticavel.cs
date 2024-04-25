using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank.Sistemas {
	public interface IAutenticavel { // tornamos abstrato pra não ser obrigado a puxar o GetBonificacao e AumentarSalario, pra as classes poderem herdar ele e funcionario ele se torna uma interface
									//public Autenticavel(string cpf, double salario) : base(cpf, salario) { // se ele herdar o funcionario ele precisa dessa chamada
									//}

		bool Autenticar(string senha);


	}
}
