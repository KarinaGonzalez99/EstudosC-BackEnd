using SetModelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSomenteLeitura {
	class Curso {
		// implementando um dicionario de alunos
		private IDictionary<int, Aluno> dicionarioAlunos = new Dictionary<int, Aluno>();

		private ISet<Aluno> alunos = new HashSet<Aluno>();

		public IList<Aluno> Alunos {
			get {
				return new ReadOnlyCollection<Aluno>(alunos.ToList());
			}
		}

		// usaremos propfull pra criar liga toda estrutura de propriedade get e set
		private IList<Aula> aulas;

		public IList<Aula> Aulas {
			get { return new ReadOnlyCollection<Aula>(aulas); }
			//set { aulas = value; } // remover pra não ter alteração
		}

		private string nome;
		private string instrutor;

		public Curso(string nome, string instrutor) {
			this.nome = nome;
			this.instrutor = instrutor;
			this.aulas = new List<Aula>();
		}

		public string Nome {
			get { return nome; }
			set { nome = value; }
		}


		public string Instrutor {
			get { return instrutor; }
			set { instrutor = value; }
		}

		internal void Adiciona(Aula aula) {
			aulas.Add(aula);
		}

		public int TempoTotal {
			get {
				//int total = 0;
				//            foreach (var aula in aulas)
				//            {
				//	total += aula.Tempo;
				//            }
				//return total;

				// outra forma:
				// LINQ = Language Integrated Query
				// Consulta Integrada à Linguagem

				return aulas.Sum(aula => aula.Tempo);
			}
		}

		public override string ToString() {
			return $"Curso:{nome},\n" +
				$"Tempo: {TempoTotal},\n" +
				$"Aulas: \n" +
				$"{string.Join("\n", aulas)} ";
		}

		internal void Matricula(Aluno aluno) {
			alunos.Add(aluno);
			dicionarioAlunos.Add(aluno.NumeroMatricula, aluno);
		}

		public bool EstaMatriculado(Aluno aluno) {
			return alunos.Contains(aluno);
		}

		internal Aluno BuscaMatriculado(int numeroMatricula) {
			Aluno aluno = null;
			dicionarioAlunos.TryGetValue(numeroMatricula, out aluno);
			return aluno;
		}

		internal void SubstituiAluno(Aluno aluno) {
			this.dicionarioAlunos[aluno.NumeroMatricula] = aluno;
		}
	}
}
