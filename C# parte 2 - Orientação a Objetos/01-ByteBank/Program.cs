using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank {
	internal class Program {
		static void Main(string[] args) {
			// objeto

			Console.WriteLine("Executar Projeto 1");

			//transformados em objeto

			//string titular = "Gabriela";
			//int numeroAgencia = 863;
			//int numero = 863146;
			//double saldo = 100;

			//string titular2 = "Bruno";
			//int numeroAgencia2 = 863;
			//int numero2 = 864;
			//double saldo2 = 50;


			//new ContaCorrente();

			//linkando
			ContaCorrente contaDaGabriela = new ContaCorrente();
			contaDaGabriela.titular = "Gabriela";
			contaDaGabriela.agencia = 863;
			contaDaGabriela.numero = 863146;
			contaDaGabriela.saldo = 100;

            Console.WriteLine();
            Console.WriteLine(contaDaGabriela.titular);
			Console.WriteLine($"Saldo atual: {contaDaGabriela.saldo}");


			contaDaGabriela.saldo += 200;
			Console.WriteLine($"Saldo atualizado: {contaDaGabriela.saldo}");

			Console.ReadLine();
		}
	}
}
