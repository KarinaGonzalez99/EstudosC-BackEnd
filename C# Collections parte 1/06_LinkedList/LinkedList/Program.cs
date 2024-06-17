using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList {
	internal class Program {
		static void Main(string[] args) {
			List<string> frutas = new List<string> {
				"abacate",
				"banana",
				"caqui",
				"damasco",
				"figo"
			};

			foreach (string f in frutas) {
                Console.WriteLine(f);
            }

			// pra um ietm ser inserido no meio da lista ele existe esforco computacional, pois os elementos temq ue ser deslocados para darem espaço para o novo elemento
			// e se posterioremente precisemos remover este item, teremos que deslocar novamente os elementos que haviam sido deslocados anterioremente

			// quanto maior a lista mais ineficaz é a inserção e remoção da mesma
			// podemos usar a lista liagada ela serve pra exatamente este tip o de necessidade, evitando o uso de operação computacional na remoção e na remoção de itens de uma lista

			// lista ligada - linked list
			// - Elementos não presenciam estar em sequencia em moemoria
			// - Cada elemento sabe quem é o anteriore e o proximo
			// - Cada elemento é um nó que contem um valor

			//instanciando uma nova lista ligada: dias da semana
			LinkedList<string> dias = new LinkedList<string>();
			//adicionando um dia qualquer: "quarta"
			var d4 = dias.AddFirst("quarta");

			//mas e o valor "quarta"? está na propriedade d4.Value
			Console.WriteLine("d4.Value: " + d4.Value);
			// add mais:
			var d2 = dias.AddBefore(d4, "segunda");
			var d3 = dias.AddAfter(d2, "terça");
			var d6 = dias.AddAfter(d4, "sexta");
			var d7 = dias.AddAfter(d6, "sábado");
			var d5 = dias.AddBefore(d6, "quinta");
			var d1 = dias.AddBefore(d2, "domingo");

			foreach (var dia in dias) {
				Console.WriteLine(dia);
			}
		}
	}
}
