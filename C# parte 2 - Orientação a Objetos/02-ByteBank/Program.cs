using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank {
	internal class Program {
		static void Main(string[] args) {
			// continuação objeto

			Console.WriteLine("Executando Projeto 2");
			Console.WriteLine();

			ContaCorrente conta = new ContaCorrente();
            Console.WriteLine(conta.titular); // resultado vazio pois é uma string
			Console.WriteLine(conta.agencia); // resultado em zero pois em lugar algum foi atribuido um valor
			Console.WriteLine(conta.saldo); // resultado em 100 pois dentro do objeto foi definido o valor

			conta.saldo = 500;
			Console.WriteLine(conta.saldo); // resultado 500 pois foi adicionado um novo valor
		}
	}
}
