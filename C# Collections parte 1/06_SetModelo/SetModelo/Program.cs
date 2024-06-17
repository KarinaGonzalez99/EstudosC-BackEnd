using ListaSomenteLeitura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetModelo {
	internal class Program {
		static void Main(string[] args) {
			// declara o curso
			Curso csharpColecoes = new Curso("C# Colecoes", "Marcelo Oliveira");
			csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));
			csharpColecoes.Adiciona(new Aula("Criando uma Aula", 20));
			csharpColecoes.Adiciona(new Aula("Modelando com Coleções", 24));

			Aluno a1 = new Aluno("Vanessa Tonini", 34672);
			Aluno a2 = new Aluno("Ana Losnak", 5617);
			Aluno a3 = new Aluno("Rafael Nercessian", 17645);

			//Precisamos matricular os alunos no curso, criando um método
			csharpColecoes.Matricula(a1); // ctrl ctrl -> gerar metodo -> f12
			csharpColecoes.Matricula(a2);
			csharpColecoes.Matricula(a3);

			//imprimindo os alunos matriculados
			Console.WriteLine("Imprimindo os alunos matriculados");
			foreach (var aluno in csharpColecoes.Alunos) {
				Console.WriteLine(aluno);
			}

			//imprimir: "O aluno a1 está matriculado?"
			Console.WriteLine($"O aluno a1 {a1.Nome} está matriculado?");

			//Criar um método EstaMatriculado
			Console.WriteLine(csharpColecoes.EstaMatriculado(a1));

			//vamos instanciar uma aluna (Vanessa Tonini) - dnv
			Aluno tonini = new Aluno("Vanessa Tonini", 34672);
			//e verificar se Tonini está matriculada
			Console.WriteLine("Tonini está matriculada? " + csharpColecoes.EstaMatriculado(tonini));

			//mas a1 == a Tonini?
			Console.WriteLine("a1 == a Tonini?");
			Console.WriteLine(a1 == tonini); // false
			//o que ocorreu? a1 é equals a Tonini?
			Console.WriteLine("a1 é equals a Tonini?");
			Console.WriteLine(a1.Equals(tonini)); // false

			// limpando console
			Console.Clear();

			//pergunta: "Quem é o aluno com matrícula 5617?"
			Console.WriteLine("Quem é o aluno com matrícula 5617?");
			//implementando Curso.BuscaMatriculado
			Aluno aluno5617 = csharpColecoes.BuscaMatriculado(5617);
			//imprimindo o aluno5617 encontrado
			Console.WriteLine("aluno5617: " + aluno5617);
			// funciona mas é pouco eficiente, vamos introduzir uma nova coleção: dicionario
			// dicionario permite associar uma chave a um valor(matricula ao aluno)

			Aluno fabio = new Aluno("Fabio Gushiken", 5617);
			/*csharpColecoes.Matricula(fabio);*/ // "Já foi adicionado um item com a mesma chave"!!

			//e se quisermos trocar o aluno que tem a mesma chave?
			csharpColecoes.SubstituiAluno(fabio);

			Console.WriteLine("Quem é o Aluno 5617 agora?");
			Console.WriteLine(csharpColecoes.BuscaMatriculado(5617));



		}
	}
}
