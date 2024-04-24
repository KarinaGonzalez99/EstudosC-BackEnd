using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank {
	internal class Program {
		static void Main(string[] args) {
			// simplificando
			Console.WriteLine("Executando Projeto 7");
			Console.WriteLine();


			ContaCorrente conta = new ContaCorrente();
			Console.WriteLine(conta.Saldo);

			Cliente cliente = new Cliente();
			cliente.Nome = "Fernanda";
			cliente.CPF = "065.155.985-00";
			cliente.Profissao = "QA";

			conta.Titular = cliente;

			Console.WriteLine(conta.Titular.Nome);
		}
	}
}
