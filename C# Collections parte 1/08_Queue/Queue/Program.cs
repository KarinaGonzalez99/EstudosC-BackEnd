using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue {
	internal class Program {
		static Queue<string> pedagio = new Queue<string>();
		static void Main(string[] args) {
			// entrou: van
			string veiculo = "van";
			Enfileirar(veiculo);
			//entrou: kombi
			Enfileirar("kombi");
			//entrou: guincho
			Enfileirar("guincho");
			//entrou: pickup
			Enfileirar("pickup");

			//carro liberado
			Desenfileirar();
			Desenfileirar();
			Desenfileirar();
			Desenfileirar();
		}

		private static void Desenfileirar() {
			if (pedagio.Any()) {
				if (pedagio.Peek() == "guincho") {
					Console.WriteLine("guincho está fazendo o pagamento.");
				}

				string veiculo = pedagio.Dequeue();
				Console.WriteLine($"Saiu da fila: {veiculo}");
				Imprima();
			}
		}

		private static void Enfileirar(string veiculo) {
			Console.WriteLine($"Entrou na fila: {veiculo}");
			pedagio.Enqueue(veiculo);
			Imprima();
		}

		private static void Imprima() {
			Console.WriteLine("FILA:");
			foreach (var v in pedagio) {
				Console.WriteLine(v);
			}
		}
	}
}
