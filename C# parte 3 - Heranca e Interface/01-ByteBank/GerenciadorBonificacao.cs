using _01_ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank {
	// a ideia é poder mexer nas bonificações em um local separado
	public class GerenciadorBonificacao {
		private double _totalBonificacao;

		public void Registrar(Funcionario funcionario) {
			_totalBonificacao += funcionario.GetBonificacao();

		}

		// por conta da herança, não precisamos mais definir o diretor porque ele é um funcionario
		//public void Registrar(Diretor diretor) { //em C# podemos usar o mesmo nome nos metodos
		//	_totalBonificacao += diretor.GetBonificacao(); // o problema que entra naquele caso de pra cada um criado precisa adicionar ele...

		//}

		public double GetTotalBonificacao() {
			return _totalBonificacao;
		}
	}
}
