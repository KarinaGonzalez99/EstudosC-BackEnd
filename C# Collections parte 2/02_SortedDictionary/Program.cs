using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_SortedDictionary {
	internal class Program {
		static void Main(string[] args) {
			// sorted list ela trabalha com duas listas, uma lista de chaves e uma de valores (usa um array ordenado)
			// sorted dictionary trabalha com pares (usa uma tree)
			IDictionary<string, Aluno> sorted = new SortedDictionary<string, Aluno>();

			sorted.Add("VT", new Aluno("Vanessa", 34672));
			sorted.Add("AL", new Aluno("Ana", 5617));
			sorted.Add("RN", new Aluno("Rafael", 17645));
			sorted.Add("WM", new Aluno("Wanderson", 11287));

			Console.WriteLine();
			foreach (var item in sorted) {
				Console.WriteLine(item);
			}
		}
	}
}
