/*using _05_ByteBank;*/ // Sabe-se que o cliente é uma classe devido a isso.. se nao ficaria _05_ByteBank.Cliente
						// nao precisa mais disso pois já definimos o nome do nosso space, e com isso é o mesmo.

using System;
using System.Security.Policy;

namespace _06_ByteBank {

	public class ContaCorrente {
		//private Cliente _titular; // foi chamado nossa outra classe aqui dentro 

		//public Cliente Titular {
		//	get {
		//		return _titular;
		//	}
		//	set {
		//		_titular = value;
		//	}
		//}

		//------------------------------------------------------ SIMPLIFICANDO:-----------------------------------------------------------------------------\\
		//existem campos qnão vai ter logica mas é interno:
		// vc não vai precisar do campo (private Cliente _titular;)
		// vc não precisar preencher o get nem o set

		public Cliente Titular { get; set; } // isso acontece pq o compilador vai encontrar esses dois campos e vai ver o ; e vai perceber que não tem logica envolvida



		public int agencia;
		public int numero;
		private double _saldo = 1000; // privado pra somente a conta corrente tenha controle dele, so conseguimos auar nele externamente por meio de métodos


		// geralmente é usado o metodo set... ou seja o nome desse metodo seria GetSaldo e o do definir seria SetSaldo
		//public double ObterSaldo() {
		//	return saldo;
		//}

		//public void DefinirSaldo(double valor) { // quando o nome do parametro é o mesmo do método, vc usa o this. pra saber qual é o da classe... opção sua
		//	if (saldo < 0) {
		//		return; // com o void, o return para ai
		//	}
		//	else {
		//		saldo += valor;
		//	}
		//}

		//------------------------------------------------------ SIMPLIFICANDO ESSES DOIS:--------------------------------------------------------------\\

		public double Saldo {
			get {
				return _saldo; // colocamos o _ pra ficar bem claro o que é o campo privado (mais facil pra vermos - convenção)
			}
			set {
				if (value < 0) {
					return;
				}
				else {
					_saldo += value;
				}
			}
		}
		public bool Sacar(double valor) {
			if (_saldo < 100) {
				return false;
			}
			else {
				_saldo -= valor;
				return true;
			}
		}

		// metodo sem retorno
		public void Depositar(double valor) {
			_saldo += valor;
		}

		public bool Transferir(double valor, ContaCorrente contaDestino) {
			if (_saldo < valor) {
				return false;
			}
			else {
				_saldo -= valor;
				contaDestino.Depositar(valor);
				return true;
			}
		}

	}
}