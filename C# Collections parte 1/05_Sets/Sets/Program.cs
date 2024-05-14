using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sets {
	internal class Program {
		static void Main(string[] args) {
			// sets = conjuntos

			// duas propriedades do set
			// 1. n permite duplicidade
			// 2. os elementos nao sao mantidos em ordem especifica

			// declarando set de alunos
			ISet<string> alunos = new HashSet<string>();
			// adicionando: vanessa, ana, rafael
			alunos.Add("Vanessa Tonini");
			alunos.Add("Ana Losnak");
			alunos.Add("Rafael Nercessain");

            //imprimindo
            Console.WriteLine(alunos);
            Console.WriteLine();
            Console.WriteLine(string.Join("\n", alunos));
            Console.WriteLine();

            // diferença entre uma lista e um set?
            alunos.Add("Priscila Stuan");
			alunos.Add("Rafael Rollo");
			alunos.Add("Fabio Gushiken");
			Console.WriteLine(string.Join("\n", alunos));
            Console.WriteLine();

			// removendo ana e adicionando o marcelo
			// n garante onde vai parar o novo elemento
			alunos.Remove("Ana Losnak");
			alunos.Add("Marcelo Oliveira");
			//imprimindo de novo
			Console.WriteLine(string.Join("\n", alunos));
            Console.WriteLine();

			// adicionando o Fabio pra testarmos duplicidade
			alunos.Add("Fabio Gushiken");
			Console.WriteLine(string.Join("\n", alunos));
			Console.WriteLine();

			// o hashset é mais rapido conforme for ficando maior comparado a lista

			//ordenando: sort -> o metodo hash set não tem o sort
			//alunos.Sort();
			//copiando: alunosEmLista
			List<string> alunosEmLista = new List<string>(alunos);
			//ordenando cópia
			alunosEmLista.Sort();
			//imprimindo cópia
			Console.WriteLine(string.Join(",", alunosEmLista));

		}
	}
}
