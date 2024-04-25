using _02_ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank.Funcionarios {
	public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel {
		public string Senha { get; set; }
		public FuncionarioAutenticavel(string cpf, double salario) : base(cpf, salario) {

		}

		public bool Autenticar(string senha) {
			return this.Senha == senha;
		}


	}
}
