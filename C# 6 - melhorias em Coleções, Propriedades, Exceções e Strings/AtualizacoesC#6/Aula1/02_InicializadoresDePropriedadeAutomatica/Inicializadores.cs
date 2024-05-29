using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicializadores
{
	class Programa
	{
		public void Main()
		{
			// Impressão de uma mensagem indicando o início da seção sobre "Inicializadores De Propriedade Automática".
			Console.WriteLine("2. Inicializadores De Propriedade Automática");

			// Criação de um novo objeto da classe Aluno com o nome "Marty", sobrenome "McFly" e data de nascimento em 12 de junho de 1968.
			Aluno aluno = new Aluno("Marty", "McFly", new DateTime(1968, 6, 12));
			Console.WriteLine(aluno.Nome);
			Console.WriteLine(aluno.Sobrenome);

			// Impressão da representação de string do objeto aluno usando o método ToString().
			Console.WriteLine(aluno.ToString());
		}
	}

	class Aluno
	{
		public string Nome { get; }

		public string Sobrenome { get; }

		// Definição da propriedade DataNascimento como somente-leitura, inicializada com uma data padrão.
		public DateTime DataNascimento { get; } = new DateTime(1990, 1, 1);

		// Construtor da classe Aluno que recebe nome e sobrenome como parâmetros.
		public Aluno(string nome, string sobrenome)
		{
			Nome = nome;
			Sobrenome = sobrenome;
		}

		// Construtor adicional da classe Aluno que recebe nome, sobrenome e data de nascimento como parâmetros.
		// Chama o construtor principal para inicializar nome e sobrenome, e então atribui a data de nascimento.
		public Aluno(string nome, string sobrenome, DateTime dataNascimento) :
			this(nome, sobrenome)
		{
			DataNascimento = dataNascimento;
		}

	}
}
