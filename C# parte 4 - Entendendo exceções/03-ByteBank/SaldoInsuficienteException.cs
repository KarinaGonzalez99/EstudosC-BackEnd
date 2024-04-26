using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank {
	public class SaldoInsuficienteException : OperacaoFinanceiraException {

		public double Saldo { get; }
		public double ValorSaque { get; }

		public SaldoInsuficienteException() {

		}
		public SaldoInsuficienteException(double saldo, double valorSaque) : this ($"Tentantiva de saque do valor de {valorSaque} em uma conta com saldo de {saldo}") { // usaremos pra passarmos erros mais ricos
			Saldo = saldo;
			ValorSaque = valorSaque;
		}


		public SaldoInsuficienteException(string mensagem) : base(mensagem) {
		}

		public SaldoInsuficienteException(string mensagem, Exception excecaoInterna) : base(mensagem, excecaoInterna) { 
		}
	}
}
