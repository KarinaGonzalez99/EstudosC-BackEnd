using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.String;
using static System.DateTime;

namespace UsingStatic
{
	class Programa
	{
		public void Main()
		{
			// Impressão de uma mensagem indicando o início da seção sobre "Using Static".
			WriteLine("4. Using Static");

			// Criação de um novo objeto da classe Aluno com o nome "Marty", sobrenome "McFly" e data de nascimento em 12 de junho de 1968.
			// Além disso, as propriedades Endereco e Telefone são inicializadas utilizando inicializadores de objeto.
			Aluno aluno = new Aluno("Marty", "McFly", new DateTime(1968, 6, 12))
			{
				Endereco = "9303 Lyon Drive Hill Valley CA",
				Telefone = "555-4385"
			};
			WriteLine(aluno.Nome);
			WriteLine(aluno.Sobrenome);

			WriteLine(aluno.NomeCompleto);
			WriteLine("Idade: {0}", aluno.GetIdade());
			WriteLine(aluno.DadosPessoais);
		}
	}

	class Aluno
	{
		public string Nome { get; }

		public string Sobrenome { get; }

		public string Endereco { get; set; }

		public string Telefone { get; set; }

		// Definição de uma propriedade com corpo de expressão para formatar os dados pessoais do aluno.
		public string DadosPessoais =>
				 Format("{0}, {1}, {2}", NomeCompleto, Endereco, Telefone);

		public DateTime DataNascimento { get; } = new DateTime(1990, 1, 1);

		public string NomeCompleto => Nome + " " + Sobrenome;

		public int GetIdade()
			=> (int)(((Now - DataNascimento).TotalDays) / 365.242199);

		public Aluno(string nome, string sobrenome)
		{
			Nome = nome;
			Sobrenome = sobrenome;
		}
		public Aluno(string nome, string sobrenome, DateTime dataNascimento) :
			this(nome, sobrenome)
		{
			this.DataNascimento = dataNascimento;
		}

	}
}
