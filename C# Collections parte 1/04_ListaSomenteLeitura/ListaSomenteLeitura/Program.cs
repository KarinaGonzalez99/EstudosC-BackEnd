using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSomenteLeitura {
	internal class Program {
		static void Main(string[] args) {
			Curso csharpColecoes = new Curso("C# Collections", "Marcelo Oliveira");
			csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));
			Imprimir(csharpColecoes.Aulas);
            Console.WriteLine();

			// adicionar 2 aulas
			csharpColecoes.Adiciona(new Aula("Criando uma Aula", 20));
			csharpColecoes.Adiciona(new Aula("Modelando com coleções", 19));
			Imprimir(csharpColecoes.Aulas);
			Console.WriteLine();

			// ordenar lista de aula
			//csharpColecoes.Aulas.Sort();

			// copiar lista pra outra lista
			List<Aula> aulasCopiadas = new List<Aula>(csharpColecoes.Aulas);

			// ordenar a copia
			aulasCopiadas.Sort();
			Imprimir(aulasCopiadas);
            Console.WriteLine();

            // totalizar o tempo do curso
            Console.WriteLine(csharpColecoes.TempoTotal);
            Console.WriteLine();

            Console.WriteLine(csharpColecoes);
            Console.WriteLine();

			// imprimir detalhes do curso

        }
		private static void Imprimir(IList<Aula> aulas) {
			Console.Clear();
			foreach (var aula in aulas) {
				Console.WriteLine(aula);
			}
		}
	}
}
