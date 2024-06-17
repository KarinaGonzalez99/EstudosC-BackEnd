using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___ByteBank {
	public class SaldoInsuficienteException : Exception { // herda o exception porque toda exceção deverida do Exception

		public double Saldo { get; }
		public double ValorSaque { get; }

		public SaldoInsuficienteException() { // colocamos pra poder ou não usar a mensagem

		}

		// tornando a nossa exceção mais rica
		// usamos o this pois estamos referenciando ao metodo de baixo, que obriga a necessidade de um texto
		// nao usamos base porque se no futuro fizermos alguma alteração não afeta o this
		// se por exemplo colocamos alguma inicilaização lá, teriamos que fazer a mesma aqui
		public SaldoInsuficienteException(double saldo, double valorSaque) : this ($"Tentantiva de saque do valor de {valorSaque} em uma conta com saldo de {saldo}") { // usaremos pra passarmos erros mais ricos
			Saldo = saldo;
			ValorSaque = valorSaque;
		}


		public SaldoInsuficienteException(string mensagem) : base(mensagem) { // colocamos pra poder ou não usar a mensagem
			// podemos fazer aqui inicialização de algum campo ou propriedade
		}
	}
}
