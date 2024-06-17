using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.String;
using static System.DateTime;
using System.Collections.ObjectModel;

namespace OperadoresNull
{
	class Programa
	{
		public void Main()
		{
			// Impressão de uma mensagem indicando o início da seção sobre "Operadores Null-Condicionais".
			WriteLine("5. Operadores Null-Condicionais");

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

			// Adicionando avaliações ao aluno.
			aluno.AdicionarAvaliacao(new Avaliacao(1, "Geografia", 8));
			aluno.AdicionarAvaliacao(new Avaliacao(1, "Matemática", 7));
			aluno.AdicionarAvaliacao(new Avaliacao(1, "História", 9));
			ImprimirMelhorNota(aluno);

			// Criando um novo aluno sem fornecer data de nascimento.
			Aluno aluno2 = new Aluno("Bart", "Simpson");

			ImprimirMelhorNota(aluno2);

		}

		// Método para imprimir a melhor nota do aluno.
		private static void ImprimirMelhorNota(Aluno aluno)
		{
			// Utilizando o operador null-condicional para acessar a propriedade MelhorAvaliacao.
			// Se aluno for nulo, a expressão retorna nulo sem gerar exceção.
			Console.WriteLine("Melhor nota: {0}",
				aluno?.MelhorAvaliacao?.Nota);
		}
	}

	class Aluno
	{
		public string Nome { get; }

		public string Sobrenome { get; }

		public string Endereco { get; set; }

		public string Telefone { get; set; }

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

		// Lista para armazenar as avaliações do aluno.
		private IList<Avaliacao> avaliacoes = new List<Avaliacao>();

		// Propriedade de somente leitura para expor as avaliações do aluno.
		public IReadOnlyCollection<Avaliacao> Avaliacoes => new ReadOnlyCollection<Avaliacao>(avaliacoes);

		// Método para adicionar uma avaliação à lista de avaliações do aluno.
		public void AdicionarAvaliacao(Avaliacao avaliacao)
		{
			avaliacoes.Add(avaliacao);
		}

		// Propriedade com corpo de expressão para retornar a melhor avaliação do aluno.
		public Avaliacao MelhorAvaliacao =>
			avaliacoes.OrderBy(a => a.Nota).LastOrDefault();
	}

	class Avaliacao
	{
		// Construtor da classe Avaliacao que recebe o bimestre, a matéria e a nota.
		public Avaliacao(int bimestre, string materia, double nota)
		{
			Bimestre = bimestre;
			Materia = materia;
			Nota = nota;
		}

		// Propriedades da avaliação: bimestre, matéria e nota.
		public int Bimestre { get; }
		public string Materia { get; }
		public double Nota { get; }
	}
}
