using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2 {
	internal class Program {
		static void Main(string[] args) {
			// condicionais2

			Console.WriteLine("Executando Projeto 8 - Condicionais2");
			Console.WriteLine();

			// ||
			int idadeJoao = 16;
			//int idadeJoao = 18;
			//int idadeJoao = 26;
			bool acompanhado = true;
			//bool acompanhado = false;

			if (idadeJoao >= 18 || acompanhado == true) {
				Console.WriteLine("Você pode entrar! Ou você tem >= 18 ou você está acompanhado!!!");
			}
			else {

				Console.WriteLine("Você é menor de idade e não está acompanhado");
			}

			Console.WriteLine();

			// &&
			int idadeMaria = 18;
			bool acompanhada = true;

			if (idadeMaria >= 18 && !acompanhada) { // ! nega
				Console.WriteLine("Você pode entrar! Pois tem 18 anos ou mais e não está acompanhado!");
			}
			else {
				Console.WriteLine("Você é menor de idade ou está acompanhado, portanto não pode entrar!");
			}
			Console.ReadLine();
		}
	}
}
