using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank {
	internal class Program {
		static void Main(string[] args) {
		}

		// tive um pouco de dificuldade com a ideia do dispose e da implementação do finally. O finally expecificamente eu entendi, só a aplicação que me confundiu um pouco, mas o dispose realmente não ficou muito claro!
		private static void TestaInnerException() {
			try {
				ContaCorrente conta1 = new ContaCorrente(4564, 789684);
				ContaCorrente conta2 = new ContaCorrente(7891, 456794);

				// conta1.Transferir(10000, conta2);
				conta1.Sacar(10000);
			}
			catch (OperacaoFinanceiraException e) {
				Console.WriteLine(e.Message);
				Console.WriteLine(e.StackTrace);

				// Console.WriteLine("Informações da INNER EXCEPTION (exceção interna):");

			}
			//finally { é um complemento do try e catch pra fechar o arquivo quando seguro

			//}
		}

		private static void Metodo() {
			TestaDivisao(0);
		}

		private static void TestaDivisao(int divisor) {
			int resultado = Dividir(10, divisor);
			Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
		}

		private static int Dividir(int numero, int divisor) {
			try {
				return numero / divisor;
			}
			catch (DivideByZeroException) {
				Console.WriteLine("Exceção com numero=" + numero + " e divisor=" + divisor);
				throw;
				Console.WriteLine("Código depois do throw");
			}
		}

		// numero = 1
		// divisor = 2;

	}
}