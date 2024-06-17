using _02_ByteBank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank {
	public class GerenciadorBonificacao {
		private double _totalBonificacao;

		public void Registrar(Funcionario funcionario) {
			_totalBonificacao += funcionario.GetBonificacao();

		}

		public double GetTotalBonificacao() {
			return _totalBonificacao;
		}
	}
}
