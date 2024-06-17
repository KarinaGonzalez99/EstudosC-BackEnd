using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos {
	// fazendo uma documentação:
	// Compilador ignora comentarios. Pra isso vamos criar um sumario

	// são 3 barras ///


	/// <summary>
	/// Define uma Conta Corrente do Banco Bytebank
	/// </summary>

	// pra rodar com nossos comentarios, tivemos que colocar o summary, e com isso agora temos warning em tudo que não tem summary


	public class ContaCorrente : IComparable {
		private static string TestandoReferenciaDeBibliotecaGracasAjudaDoJohn;
		private static string DificuldadeMasAchoQueEvoluiEEntendi;
		private static int TaxaOperacao;

		public static int TotalDeContasCriadas { get; private set; }

		public Cliente Titular { get; set; }

		public int ContadorSaquesNaoPermitidos { get; private set; }
		public int ContadorTransferenciasNaoPermitidas { get; private set; }

		public int Numero { get; }
		public int Agencia { get; }

		private double _saldo = 100;
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

		// por ser contrutor ele vai adicionar mais duas tags, automaticamente
		// nessas tags colocamos texto e pode ser que o valor altere, pra isso usamos <see e ele autocompleta
		// porem se vc faz o sistema de referenciar esse arquivo em outra pasta, ele não pega o summary, pra isso devemos então:
		// clicar na biblioteca, propriedades, compilar, saida, check no xml e fechar
		// copiar o xml e colar na nossa biblioteca

		/// <summary>
		/// Cria uma instância de ContaCorrente com os argumento utilizados
		/// </summary>
		/// <param name="agencia">Represete o valor da propriedade <see cref="Agencia"/> e deve possuir um valor maior que zero</param>
		/// <param name="numero">Represete o valor da propriedade Numero e deve possuir um valor maior que zero</param>
		/// <exception cref="ArgumentException"></exception>

		public ContaCorrente(int agencia, int numero) {
			if (numero <= 0) {
				throw new ArgumentException("O argumento agencia deve ser maior que 0.", nameof(agencia));
			}

			if (numero <= 0) {
				throw new ArgumentException("O argumento numero deve ser maior que 0.", nameof(numero));
			}

			Agencia = agencia;
			Numero = numero;

			TotalDeContasCriadas++;
			TaxaOperacao = 30 / TotalDeContasCriadas;
		}

		// o summary as vezes não é suficiente, pois queremos um resumo e não um textão... cm isso temos outras opções como:
		//exception
		// usamos o paramref pra referenciar um parametro

		/// <summary>
		/// Realiza o saque e atualiza o valor da propriedade <see cref="Saldo"/>
		/// <exception cref="ArgumentException">Exceção lançada quando um valor negativo é utilizado no argumento <paramref name="valor"/></exception>
		/// <exception cref="SaldoInsufienteException">Exceção lançada quando um valor negativo é utilizado no argumento <paramref name="valor"/>. </exception>
		/// </summary>
		/// <param name="valor"> Representa o valor do saque, deve ser maior que 0 e menor que <see cref="Saldo"/>. </param>



		public void Sacar(double valor) {
			if (valor < 0) {
				throw new ArgumentException("Valor inválido para o saque.", nameof(valor));
			}

			if (_saldo < valor) {
				ContadorSaquesNaoPermitidos++;
				throw new SaldoInsuficienteException(Saldo, valor);
			}

			_saldo -= valor;
		}

		public void Depositar(double valor) {
			_saldo += valor;
		}

		public void Transferir(double valor, ContaCorrente contaDestino) {
			if (valor < 0) {
				throw new ArgumentException("Valor inválido para a transferência.", nameof(valor));
			}

			try {
				Sacar(valor);
			}
			catch (SaldoInsuficienteException ex) {
				ContadorTransferenciasNaoPermitidas++;
				throw new OperacaoFinanceiraException("Operação não realizada.", ex);
			}

			contaDestino.Depositar(valor);
		}

		// ctrl . pra criar a interface automatica do IComparable
		public int CompareTo(object obj) {
			// retornar negativo quando a instancia precede o obj
			// retornar zero quando nossa instancia e obj forem equivalentes
			// retoranr positvo diferente de zero quando a precedencia for de obj

			var outraConta = obj as ContaCorrente;

			if(outraConta == null ){
				return -1;
			}

			if (Numero < outraConta.Numero) {
				return -1;
			}

			if (Numero == outraConta.Numero) {
				return 0;
			}
			return 1;

		}
	}

}
