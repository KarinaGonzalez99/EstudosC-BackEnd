using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomenteLeitura
{
	class Programa
	{
		public void Main()
		{
			// Impressão de uma mensagem indicando o início da seção sobre "Propriedades Automáticas Somente-Leitura".
			Console.WriteLine("1. Propriedades Automáticas Somente-Leitura");

			// Criação de um novo objeto da classe Aluno com o nome "Marty", sobrenome "McFly" e data de nascimento em 12 de junho de 1968.
			Aluno aluno = new Aluno("Marty", "McFly", new DateTime(1968, 6, 12));
			Console.WriteLine(aluno.Nome);
			Console.WriteLine(aluno.Sobrenome);

			// Tentativa de modificar as propriedades Nome e Sobrenome, o que não é permitido devido à sua configuração de somente leitura.
			//aluno.Nome = "Biff";
			//aluno.Sobrenome = "Tannen";
			//Console.WriteLine(aluno.Nome);
			//Console.WriteLine(aluno.Sobrenome);

			// Impressão da representação de string do objeto aluno usando o método ToString().
			Console.WriteLine(aluno.ToString());
		}
	}

	class Aluno
	{
		// Definição da propriedade Nome como somente-leitura.
		public string Nome { get; } // set sendo readonly

		// Definição da propriedade Sobrenome como comum.
		public string Sobrenome { get; }

		// Definição da propriedade DataNascimento como comum.
		public DateTime DataNascimento { get; }

		// Definição do construtor da classe Aluno, que inicializa as propriedades Nome, Sobrenome e DataNascimento.
		public Aluno(string nome, string sobrenome, DateTime dataNascimento)
		{
			Nome = nome;
			Sobrenome = sobrenome;
			DataNascimento = dataNascimento;
		}

		// Tentativa de modificar as propriedades Nome e Sobrenome dentro do método ToString(),
		//public override string ToString()
		//{
		//    this.Nome = "novo nome";
		//    this.Sobrenome = "novo sobrenome";
		//    return string.Format("{0} {1}", Nome, Sobrenome);
		//}
	}
}
