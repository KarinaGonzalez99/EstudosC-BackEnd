using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sintaxe
{
	class Programa
	{
		public void Main()
		{
			// Impressão de uma mensagem indicando o início da seção sobre "Membros Com Corpo De Expressão".
			Console.WriteLine("3. Membros Com Corpo De Expressão");

			// Criação de um novo objeto da classe Aluno com o nome "Marty", sobrenome "McFly" e data de nascimento em 12 de junho de 1968.
			Aluno aluno = new Aluno("Marty", "McFly", new DateTime(1968, 6, 12));
			Console.WriteLine(aluno.Nome);
			Console.WriteLine(aluno.Sobrenome);
			// Impressão do nome completo do aluno usando uma propriedade com corpo de expressão.
			Console.WriteLine(aluno.NomeCompleto);
			// Impressão da idade do aluno usando um método com corpo de expressão.
			Console.WriteLine("Idade: {0}", aluno.GetIdade());
		}
	}

	class Aluno
	{
		public string Nome { get; }

		public string Sobrenome { get; }

		public DateTime DataNascimento { get; } = new DateTime(1990, 1, 1);

		// Definição de uma propriedade com corpo de expressão para calcular e retornar o nome completo do aluno.
		public string NomeCompleto => Nome + " " + Sobrenome;

		// Definição de um método com corpo de expressão para calcular e retornar a idade do aluno.
		public int GetIdade() => (int)(((DateTime.Now - DataNascimento).TotalDays) / 365.242199);

		public Aluno(string nome, string sobrenome)
		{
			Nome = nome;
			Sobrenome = sobrenome;
		}
		public Aluno(string nome, string sobrenome, DateTime dataNascimento) :
			this(nome, sobrenome)
		{
			DataNascimento = dataNascimento;
		}

	}
}
