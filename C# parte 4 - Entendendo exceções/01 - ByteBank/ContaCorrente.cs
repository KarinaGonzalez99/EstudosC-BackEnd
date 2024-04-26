using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// MSDN = documentação exception


namespace _01___ByteBank {
	public class ContaCorrente {

		// taxa de lucro do banco em cima das operações dos clientes
		public static double TaxaOperacao { get; private set; }

		//define titular do tipo cliente
		public Cliente Titular { get; set; }

		// criar contador quantas vezes o cliente tentou fazer uma operação sem ter saldo suficiente
		public int ContadorSaquesNaoPermitidos { get; private set; }
		public int ContadorTransferenciasNaoPermitidas { get; private set; }


		// rastreia o total de contas criadas e so pode ser modificada dentro da classe conta corrente
		public static int TotalDeContasCriadas { get; private set; }


		// propriedade que pode obter edefinir o numero da agencia, e impede de ter valores menores ou iguais a zero
		public int Agencia { get; } // mesma coisa ele já entende e cria o campo private e readonlu

		// propriedade pra obter ou definir o numero da conta
		// pra evitar que aqui dentro depois de setado você modifique, colocamos que é um readonly
		public int Numero { get; } // pra facilitar podemos apenas atribuir o get que ele já entende e cria o campo private e readonly


		// propriedade privada que armazena o saldo da conta, inicializado com o valor de 100
		private double _saldo = 100;


		// propriedade que obtem ou define o saldo e não permite ser negativo
		public double Saldo {
			get {
				return _saldo;
			}
			set {
				if (value < 0) {
					return;
				}

				_saldo = value;
			}
		}


		// constrtutor de classe que inicializa uma nova instancia de conta corrente, com uma agncia e numero obrigatorios e permite o incrememento do contador de contas
		public ContaCorrente(int agencia, int numero) {
			if (numero <= 0) {
				throw new ArgumentException("O argumento agencia deve ser maior que 0.", nameof(agencia)); // 1° argumento 2° paramname
			}

			if (numero <= 0) {
				throw new ArgumentException("O argumento numero deve ser maior que 0.", nameof(numero));
			}

			Agencia = agencia;
			Numero = numero;


			TotalDeContasCriadas++;

			// antes ele estava em cima do TotalDeContasCriadas++ pra poder dar erro e testarmos
			TaxaOperacao = 30 / TotalDeContasCriadas; // a taxa é 30 e quanto mais contas criadas mais distribuido a taxa
		}

		// metodo pra sacar um valor do saldo da conta, impede caso não tenha saldo suficiente
		public void Sacar(double valor) {
			//Agencia = "123456"; // testando se ele reclama se é apenas readonly
			//Conta = "123456"; // testando se ele reclama se é apenas readonly

			// exceção relacionada ao argumento
			if (valor < 0) {
				throw new ArgumentException("Valor inválido para o saque.", nameof(valor)); // lembrando que usamos o nameof, pois se deixassemos como string, se alguem alterasse o parametro, ele nao alteraria a string literal
			}

			// exceção relacionada ao parametro
			if (_saldo < valor) {
				ContadorSaquesNaoPermitidos++;
				throw new SaldoInsuficienteException(Saldo, valor);
			}

			_saldo -= valor;
		}

		// metodo que deposita um valor no saldo da conta
		public void Depositar(double valor) {
			_saldo += valor;
		}

		// metodo que transfere um valor desta conta pra outra, e retorna true se der bom, ou falsese não tiver saldo suficiente
		public void  Transferir(double valor, ContaCorrente contaDestino) {

			if (valor <= 0) {
				throw new ArgumentException("Valor inválido para a transferencia.", nameof(valor)); // lembrando que usamos o nameof, pois se deixassemos como string, se alguem alterasse o parametro, ele nao alteraria a string literal
			}

			try {
				Sacar(valor);
			} catch(SaldoInsuficienteException) {
				ContadorTransferenciasNaoPermitidas++;
				throw;
			}
			contaDestino.Depositar(valor);
		}

		
	}
}
