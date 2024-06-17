using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeObjeto {
	internal class Program {
		static void Main(string[] args) {
			var aulaIntro = new Aula("Introdução às Coleções", 20);
			var aulaModelando = new Aula("Modelando a Classe Aula", 18);
			var aulaSets = new Aula("Trabalhando com Conjuntos", 16);

			List<Aula> aulas = new List<Aula>();
			aulas.Add(aulaIntro);
			aulas.Add(aulaModelando);
			aulas.Add(aulaSets);
			//aulas.Add("Conclusão");

			Imprimir(aulas);
            Console.WriteLine();

            // ordenar não da certo não usarmos o metodo ICOMPARABLE porque é ele que da uma
            aulas.Sort();
			Console.WriteLine("Aulas ordenadas: ");
			Imprimir(aulas);
            Console.WriteLine();

            // ordenar pelo tempo
            aulas.Sort((param1, param2) => param1.Tempo.CompareTo(param2.Tempo));
            Console.WriteLine("Aulas ordenadas pelo tempo: ");
			Imprimir(aulas);
			Console.WriteLine();

		}

		private static void Imprimir(List<Aula> aulas) {
            Console.Clear();
			foreach(var aula in aulas) {
                Console.WriteLine(aula);
            }
        }
	}
	// lista de objeto pra armazenar a aula e o tempo
	class Aula : IComparable { 
		private string titulo;
		private int tempo;


		public Aula(string titulo, int tempo) {
			this.titulo = titulo;
			this.tempo = tempo;
		}

		public string Titulo { get => titulo; set => titulo = value; }
		public int Tempo { get => tempo; set => tempo = value; }

		public int CompareTo(object obj) { // o COMPARETO permite comparação entre os objetos
			// conversão do tipo aula pra trabalhar com o titulo
			Aula that = obj as Aula;
			return titulo.CompareTo(that.titulo);
		}

		// criamos pra imprimir pois sobreescreve o metodo padrão da classe object
		public override string ToString() {
			return $"[Título: {titulo}, tempo: {tempo} minutos]";
		}
	}
}
