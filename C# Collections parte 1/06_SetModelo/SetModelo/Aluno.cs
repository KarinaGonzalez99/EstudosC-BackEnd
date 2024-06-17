using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetModelo {
	internal class Aluno {
		private string nome;
		private int numeroMatricula;

		public Aluno(string nome, int numeroMatricula) {
			this.nome = nome;
			this.numeroMatricula = numeroMatricula;
		}

		public string Nome {
			get { return nome; }
			set { nome = value; }
		}

		public int NumeroMatricula {
			get { return numeroMatricula; }
			set { numeroMatricula = value; }
		}

		public override string ToString() {
			return $"[Nome: {nome}, Matrícula: {numeroMatricula}]";
		}

		public override bool Equals(object obj) { // era false so que com esse metodo virá true, pois passamos por cima da comparação default
			Aluno outroAluno = obj as Aluno;

			if (outroAluno == null) {
				return false;
			}

			return nome.Equals(outroAluno.nome);
		}

	}
}
