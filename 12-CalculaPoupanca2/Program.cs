using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_CalculaPoupanca2 {
	internal class Program {
		static void Main(string[] args) {
            // calcula poupança 2 - for

            Console.WriteLine("Executa projeto 12 - Calcula Poupança 2");
            Console.WriteLine();

            double valorInvestido = 2000;

            for(int contadorMes = 1; contadorMes <= 12; contadorMes ++) {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine($"Após {contadorMes} meses, você terá {valorInvestido}");
            }


            Console.ReadLine();
        }
	}
}
