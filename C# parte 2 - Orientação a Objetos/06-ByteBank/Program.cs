using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank {
	internal class Program {
		static void Main(string[] args) {
			// saldo e definir saldo
			Console.WriteLine("Executando Projeto 6");
			Console.WriteLine();


			ContaCorrente conta = new ContaCorrente();
			// conta.saldo = -10;*/ // por ter ficado privado não podemos alterá-lo por aqui
			// Console.WriteLine(conta.saldo);

			//Console.WriteLine(conta.ObterSaldo());
			//conta.DefinirSaldo(-100);
			//Console.WriteLine(conta.ObterSaldo());

			conta.Saldo = 10; // colocamos que não pode ter -
            Console.WriteLine(conta.Saldo);

			Cliente cliente = new Cliente();
			cliente.nome = "Guilherme";
			cliente.cpf = "478.657.955-34";
			cliente.profissao = "Desnvolvedor Python";

			conta.Titular = cliente;

            Console.WriteLine(conta.Titular.nome);
        }
	}
}
