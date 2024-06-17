using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String {
	class Program {
		static void Main(string[] args) {
			string aulaIntro = "Introdução às Coleções";
			string aulaModelando = "Modelando a Classe Aula";
			string aulaSets = "Trabalhando com Conjuntos";

			// maneira 1 de declarar um array
			//string[] aulas = new string[]
			//{
			//	aulaIntro,
			//	aulaModelando,
			//	aulaSets
			//};

			// maneira 2 de declarar um array
			string[] aulas = new string[3];
			aulas[0] = aulaIntro;
			aulas[1] = aulaModelando;
			aulas[2] = aulaSets;

			Console.WriteLine($"Mostrando o que aula é: {aulas}");
			Console.WriteLine();

			Console.WriteLine("Todo o array:");
			Imprimir(aulas);
			Console.WriteLine();

			// primeiro indice
			Console.WriteLine($"A aula na posição 0 doa array é a: {aulas[0]}");
			// ultimo indice
			Console.WriteLine($"A aula na ultima posição do array é a: {aulas[aulas.Length - 1]}");
			Console.WriteLine();

			// primeiro indice que tiver o aulamodelando
			Console.WriteLine("Aula modelando está no índice " + Array.IndexOf(aulas, aulaModelando));
			// ultimo indice que tiver o aulamodelando
			Console.WriteLine($"O utlimo index que foi encontrada aula modelando foi: {Array.LastIndexOf(aulas, aulaModelando)}");
			Console.WriteLine();

			// inverter array
			Array.Reverse(aulas);
			Console.WriteLine("O array invertido fica:");
			Imprimir(aulas);
			// reverter a inversão
			Array.Reverse(aulas);
			Console.WriteLine("O array re-invertido fica:");
			Imprimir(aulas);
			Console.WriteLine();

			// remodelando o tamanho do array
			Array.Resize(ref aulas, 2);
			Console.WriteLine("O array com tamanho[2] remodelado fica:");
			Imprimir(aulas);
			Console.WriteLine();
			Array.Resize(ref aulas, 3);
			Console.WriteLine("O array com tamanho[3] remodelado fica:");
			Imprimir(aulas);
			Console.WriteLine();
			// o valor fica faltando pra isso vamos dar o novo valor
			aulas[aulas.Length - 1] = "Conclusão";
			Console.WriteLine("O novo array com tamanho[3] remodelado fica:");
			Imprimir(aulas);
			Console.WriteLine();

			// ordenar em ordem alfabetica
			Array.Sort(aulas);
			Console.WriteLine("O array na ordem alfabetica fica:");
			Imprimir(aulas);
			Console.WriteLine();

			// copiar array pra outro array
			string[] copia = new string[2];
			Array.Copy(aulas, 1, copia, 0, copia.Length);
			Console.WriteLine("O novo array 'copia', tem os seguintes elementos:");
			Imprimir(copia);
			Console.WriteLine();

			// copiar de maneira mais simples e completa, sem o as ele não consegue transformar o objeto em string e clonar
			string[] clone = aulas.Clone() as string[];
			Console.WriteLine("O array 'clone', tem os seguintes elementos:");
			Imprimir(clone);
			Console.WriteLine();

			// limpar os elementos
			Array.Clear(clone, 1, 2);
			Console.WriteLine("O array 'clone', utilizando o metodo clear a partir do 1 indice fica:");
			Imprimir(clone);
			Console.WriteLine();
		}

		// maneira de imprimir cada um
		private static void Imprimir(string[] aulas) {
			//foreach (var aula in aulas)
			//{
			//  Console.WriteLine(aula);
			//}

			for (int i = 0; i < aulas.Length; i++) {
				Console.WriteLine(aulas[i]);
			}
		}
	}
}
