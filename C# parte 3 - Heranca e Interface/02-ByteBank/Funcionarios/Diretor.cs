using _02_ByteBank.Funcionarios;
using _02_ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank {
	public class Diretor : FuncionarioAutenticavel { // ele vai herdar funcionario e autenticavel
		// metodo pra obrigatoriedade do cpf registrado, além do que a base faz
		public Diretor(string cpf) : base(cpf, 5000) {
			Console.WriteLine("CRIANDO DIRETOR");
		}

		// metodo aumentar salario DIRETOR
		public override void AumentarSalario() {
			Salario *= 1.15;
		}

		// metodo de bonificar versão diretor que usa a base + bonificação propria sobreescrevendo a do funcionario
		public override double GetBonificacao() {
			return Salario * 0.5; //atualizar diretor
		}
	}
}
