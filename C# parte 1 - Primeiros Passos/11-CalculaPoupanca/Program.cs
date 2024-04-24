using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_CalculaPoupanca {
	internal class Program {
		static void Main(string[] args) {
			// calcula poupança - while

			Console.WriteLine("Executando projeto 11 - Calcula Poupança");

			double valorInvestido = 1000;
			int contadorMes = 1;


			//valorInvestido = valorInvestido + valorInvestido * 0.0036;
			//Console.WriteLine($"Após 1 mês, você terá R${valorInvestido}");

			//valorInvestido = valorInvestido + valorInvestido * 0.0036;
			//Console.WriteLine($"Após 2 meses, você terá R${valorInvestido}");

			while (contadorMes <= 12) {
				valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine($"Após {contadorMes} meses, você terá {valorInvestido}");
                contadorMes++;
			
			}

			Console.ReadLine();
		}
	}
}
