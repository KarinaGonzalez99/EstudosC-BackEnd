using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista {
	class Program {
		static void Main(string[] args) {
			string aulaIntro = "Introdução às Coleções";
			string aulaModelando = "Modelando a Classe Aula";
			string aulaSets = "Trabalhando com Conjuntos";

			// declarar a lista, o tipo
			//List<string> aulas = new List<string>{
			//	aulaIntro,
			//	aulaModelando,
			//	aulaSets
			//};

			// criar sem os elementos iniciais
			List<string> aulas = new List<string>();

			// podemos adicionar aos poucos
			aulas.Add(aulaIntro);
			aulas.Add(aulaModelando);
			aulas.Add(aulaSets);

			Console.WriteLine("A lista contém os seguintes elementos: ");
			Imprimir(aulas);

			Console.WriteLine();

			Console.WriteLine($"A primeira aula usando o [0] é: {aulas[0]}");
			Console.WriteLine($"A primeira aula usando o First é: {aulas.First()}");
			Console.WriteLine();

			Console.WriteLine($"A ultima aula usando o [count - 1] é: {aulas[aulas.Count - 1]}");
			Console.WriteLine($"A ultima aula usando o Last é: {aulas.Last()}");
			Console.WriteLine();

			// substituir um valor por outro
			aulas[0] = "Trabalhando com Listas";
			Console.WriteLine("A lista com a substituição do primeiro elemento[0], contém os seguintes elementos: ");
			Imprimir(aulas);
			Console.WriteLine();

			// encontrar intercorrencia
			Console.WriteLine($"A primeira aula 'Trabalhando' é: {aulas.First(aula => aula.Contains("Trabalhando"))}");
			Console.WriteLine($"A ultima aula 'Trabalhando' é: {aulas.Last(aula => aula.Contains("Trabalhando"))}");
			// encontrar porem caso não exista ele n quebra : First/Last ou default
			Console.WriteLine($"A primeira aula 'Conclusão' é: {aulas.FirstOrDefault(aula => aula.Contains("Conclusão"))}");
			Console.WriteLine($"A ultima aula 'Conclusão' é: {aulas.LastOrDefault(aula => aula.Contains("Conclusão"))}");
			Console.WriteLine();

			// remover o ultimo elemento
			aulas.RemoveAt(aulas.Count - 1);
			Console.WriteLine("Os elementos da lista atualizado após a remoção do ultimo elemento:");
			Imprimir(aulas);
			Console.WriteLine();

			// adicionando
			aulas.Add("Conlusão!");
			Console.WriteLine("Os elementos da lista atualizada após remoção e adição do ultimo elemento:");
			Imprimir(aulas);
			Console.WriteLine();

			// ordenando
			aulas.Sort();
            Console.WriteLine("Elementos ordenados:");
			Imprimir(aulas);
			Console.WriteLine();

			// copiando - get ranger pega a partir dos ultimos elementos
			List<string> copia = aulas.GetRange(aulas.Count - 2, 2); // penultimo e ultimo é pra pegar
            Console.WriteLine("Lista copiada a partir do ultimo elemento pegando apenas 2 elementos(ultimo e penultimo):");
			Imprimir(copia);
			Console.WriteLine();

			// clonar, porem não temos o metodo clonar direto
			List<string> clone = new List<string>(aulas);
            Console.WriteLine("Lista Clone:");
            Imprimir(clone);
			Console.WriteLine();

			Console.WriteLine();



		}

		private static void Imprimir(List<string> aulas) { // ctrl crtl extrair metodo

			// maneira 1
			//foreach (var aula in aulas)
			//{
			//    Console.WriteLine(aula);
			//}

			// maneira 2
			// no laço for, nao tem o length por conta de ser uma lista, pra isso usamos o count
			//for (int i = 0; i < aulas.Count; i++) {
			//	Console.WriteLine(aulas[i]);
			//}

			// maneira 3
			// laco usando o metodo foreach
			aulas.ForEach(aula => {
				Console.WriteLine(aula);
			});
		}
	}
}
