using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank {
	internal class Program {
		static void Main(string[] args) {
			try {
				ContaCorrente conta1 = new ContaCorrente(46848, 44542);
				ContaCorrente conta2 = new ContaCorrente(6848787, 648754);

				//conta1.Transferir(1000, conta2);
				conta1.Sacar(1000);
			}
			catch (OperacaoFinanceiraException e) {
				Console.WriteLine(e.Message);
				Console.WriteLine(e.StackTrace);


				// inner exception é uma classe interna da exception que armazena uma exceção dentro de outra excecao, ele da um detalhamento mais profundo de erro
				//Console.WriteLine("Informações da INNER EXCEPTION (exceção interna"); // usamos apenas pra vermos a informação, porque o usuario só vai ter acesso mesmo a mensagem, operação não realizada
				//Console.WriteLine(e.InnerException.Message);
				//Console.WriteLine(e.InnerException.StackTrace);

			}

			Console.ReadLine();

		}
		private static void Metodo() {
			TestaDivisao(0);
		}

		private static void TestaDivisao(int divisor) {
			int resultado = Dividir(10, divisor);
			Console.WriteLine($"Resultado da divisão de 10 por {divisor} é {resultado}");
		}

		private static int Dividir(int numero, int divisor) {
			try {
				return numero / divisor;
			}
			catch (DivideByZeroException) {
				Console.WriteLine($"Exceção com numero {numero} com divisor igual {divisor}");
				throw;
			}
		}
	}
}
