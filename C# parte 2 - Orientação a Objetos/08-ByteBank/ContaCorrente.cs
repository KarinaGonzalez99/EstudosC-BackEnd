using System;
using System.Security.Policy;

namespace _08_ByteBank {

	public class ContaCorrente {
		public Cliente Titular { get; set; }

		// por ser publica podem editar externamente, pra isso vamos criar um metodo private, mas eu quero apenas que o metodo set seja privado
		public static int TotalDeContasCriadas { get; private set; } // static significa que ela pertence a classe, ou seja, todos o objetos compartilham essa info

		private int _agencia;
		public int Agencia {
			get {
				return _agencia;
			}
			set {
				if (value <= 0) {
					return;
				}
				_agencia = value; //lembrando que não tem pq por else pq já se subentende que é um else
			}
		}

		public int Numero { get; set; }
		private double _saldo = 1000;

		public double Saldo {
			get {
				return _saldo;
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

		// aqui estamos "forçando" a não passar algum valor em branco (ainda mais os necessarios) - chama-se construtor
		public ContaCorrente(int agencia, int numero) {
			Agencia = agencia;
			Numero = numero;

			// aqui vamos agora setar o incremento de caracteristica do objeto
			TotalDeContasCriadas++;
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