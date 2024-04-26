using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___ByteBank {
	internal class Program {
		static void Main(string[] args) {
			// try/catch da referencia nula, foi colcoado aqui porque pela ordem de excecução ele é o proximo e ultimo a executar (baseado na referencia colocada)
			try {
				ContaCorrente conta = new ContaCorrente(10, 1231);
				ContaCorrente conta2 = new ContaCorrente(1545, 99999);
				conta2.Transferir(100000, conta);
				//conta.Agencia = 455; // testando se ta private 
				conta.Depositar(50);
				Console.WriteLine(conta.Saldo);
				conta.Sacar(500);


			}
			catch (ArgumentException ex) {
				// ParamName: obtem o nome do parametro que causa a exceção
				if (ex.ParamName == "numero") {

				}

				Console.WriteLine("Argumento com problema: " + ex.ParamName);
				//Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException");
				Console.WriteLine(ex.Message);
			}
			catch (SaldoInsuficienteException ex) {
				Console.WriteLine(ex.Saldo);
				Console.WriteLine(ex.ValorSaque);

				Console.WriteLine(ex.StackTrace);

				Console.WriteLine(ex.Message);
				//Console.WriteLine("Exceção do tipo SaldoInsuficientException");
			}

			catch (Exception ex) {
				Console.WriteLine(ex.Message);
			}
			//try {
			Metodo();
			//}
			/*		catch (Exception e) {*/ // 'e' de exceção
											//Console.WriteLine(e.Message);
											//Console.WriteLine(erro.StackTrace); // comentado pro terminal ficar mais facil de ler
											//}



			// podemos fazer um base que consegue entender qual o erro sem darmos o contexto manualmente
			//catch (NullReferenceException erro) {
			//	Console.WriteLine(erro.Message);
			//	Console.WriteLine(erro.StackTrace);
			//	Console.WriteLine("Aconteceu um erro de referencia nula!!!");
			//}
			//catch (DivideByZeroException erro) {
			//	Console.WriteLine(erro.Message);
			//	Console.WriteLine(erro.StackTrace);
			//	Console.WriteLine("Aconteceu um erro de referencia nula!!!");
			//}
			//ContaCorrente conta = new ContaCorrente(7480, 874150);

			//Console.WriteLine(ContaCorrente.TaxaOperacao);

			//Metodo();
			Console.ReadLine();

		}

		// Teste com a cadeia de chamada:
		// Metodo -> TestaDivisao -> Dividir
		private static void Metodo() {
			TestaDivisao(0); // da erro se não fizermos a exceção, elenem roda o codigo de baixo
							 //TestaDivisao(2);
							 //TestaDivisao(20);
		}

		private static void TestaDivisao(int divisor) { // em c# os erros são objetos
			int resultado = Dividir(10, divisor);
			Console.WriteLine($"Resultado da divisão de 10 por {divisor} é {resultado}");
			//comentado pra colocarmos as exceções focadas em um lugar,no caso no main
			//try {
			//	int resultado = Dividir(10, divisor);
			//	Console.WriteLine($"Resultado da divisão de 10 por {divisor} é {resultado}");
			//}
			//catch (DivideByZeroException erro) { // esse por exemplo é um objeto de erro C#
			//	Console.WriteLine(erro.Message); // "Tentativa de divisão por zero."
			//	Console.WriteLine(erro.StackTrace); // mostra o rastro da pilha de chamadas
			//}

			//if (resultado == -1) {
			//	Console.WriteLine("Não é possivel fazer divisão por zero");
			//}
			//else {
			//}

		}

		private static int Dividir(int numero, int divisor) {

			try {
				return numero / divisor;
			}
			catch (DivideByZeroException) {
				Console.WriteLine($"Exceção com numero {numero} com divisor igual {divisor}");
				throw; // usada pra lançar a exceção que esse bloco catch ta pegando, ou seja, controle de fluxo

			}


			//if (divisor == 0) { // com isso pra cada codigo teriamos que fazer um if. Pra evitar isso usmos o try e o catch
			//	return -1;
			//}

			//if (divisor > numero) {
			//	return -2;
			//}

			// referencia nula
			/*ContaCorrente conta = null;*/ // não aponta pra nenhum lugar

			// pra rodar o try catch descomente a linha abaixo, foi comentada pra testar outras excessoes
			// Console.WriteLine(conta.Saldo); // a maquina vai ver o erro e lancar o erro de exceção, pra isso não acontecer vamos puxar um catch com o NullReferenceException

			//return numero / divisor; // comentado pra podermos fazer um detalhamento melhor
		}


	}
}
