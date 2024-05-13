using ByteBank.Modelos;
using ByteBank.SistemaAgencia.Comparadores;
using ByteBank.SistemaAgencia.Extensoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Estava com dificuldade em usar a referencia pois estava usando uma cópia e não o original isso fazia com que eu não conseguisse atualizar
// Optei por copiar e colar o arquivo inteiro da biblioteca original, pra poder editar. Demorei um pouco pois não estava sabendo mexer no 
// Visual Studio 2022, e não sabia como puxar um arquivo/pasta que estava no pc e não aparecia no VS22. 
// Havia tbm me esquecido de recompilar mas agora consegui!
// Tive ajuda do John quanto a ideia de que não era o original e sim a cópia!

namespace ByteBank.SistemaAgencia {
	internal class Program {
		static void Main(string[] args) {

			var contas = new List<ContaCorrente>() {
				new ContaCorrente(341, 1),
				new ContaCorrente(342, 999),
				new ContaCorrente(340, 4),
				new ContaCorrente(340, 456),
				new ContaCorrente(340, 10),
				new ContaCorrente(290, 123)
			};

			//Chama a implementação dada em IComparable:
			//contas.Sort(); // error, pelo menos um objeto deve implementar IComparable

			//Chama a implementação dada em IComparer
			//contas.Sort(new ComparadorContaCorrenteAgencia()); // podemos usar o OrderBy pra definirmos diretamente o que queremos ordernar sem precisar de todo esse contexto

			IOrderedEnumerable<ContaCorrente> listaOrdenada = contas.OrderBy(conta => conta.Numero);
			// podemos fazer assim tbm: 
			// contas = contas.OrderBy(conta => conta.Numero).ToList();

			// Console.WriteLine();
			// contas.OrderBy(conta => conta.Agencia);

			foreach (var cont in listaOrdenada) { // e ai poderia manter o antigo contas ao inves da listaOrdenada
				Console.WriteLine($"Conta número {cont.Numero}, ag.{cont.Agencia}");
			}

			Console.WriteLine();

			var contasComNulos = new List<ContaCorrente>() {
				new ContaCorrente(9123, 1),
				null,
				new ContaCorrente(7894, 999),
				new ContaCorrente(2354, 4),
				new ContaCorrente(9842, 456),
				null,
				null,
				new ContaCorrente(2572, 10),
				new ContaCorrente(04874, 123),
				null
			};


			//var contasNaoNulas = contasComNulos.Where(conta => conta != null);
			//IOrderedEnumerable<ContaCorrente> listaOrdenadaNulas = contasNaoNulas.OrderBy(conta => conta.Numero);
			// podemos organizar melhor :
			IOrderedEnumerable<ContaCorrente> contasOrdenadas = contas
				.Where(conta => conta != null)
				.OrderBy<ContaCorrente, int>(conta => conta.Numero);

			foreach (var cont in contasOrdenadas) { // e ao inves de usar o listaOrdenadaNulas, podemos usar direo o contasOrdenadas
				Console.WriteLine($"Conta número {cont.Numero}, ag.{cont.Agencia}");
			}


		}

		static void ListTeste() {
			// existe uma lista dentro do .NET LIST

			List<int> idades = new List<int>(); // antes tinhamos criado uma classe generica LISTA
			idades.Add(14); // criamos o Adicionar, mas ele é o Add do pronto do .NET
			idades.Add(5);
			idades.Add(29);
			idades.Add(50);

			// extender nossa classe list - vamos criar um metodo que facilite
			//ListExtensoes.AdicionarVarios(idades, 1, 2, 5, 55, 24, 86);

			//por causa do this podemos chamar o adicionar varios sem a classe
			// e sem chamar ela denovo
			idades.AdicionarVarios(85, 65, 95, 70);

			idades.Remove(5); // criamos o Remover... Remove

			for (int i = 0; i < idades.Count; i++) { // criamos o tamanho que virou o Count
				Console.WriteLine(idades[i]);
			}
		}

		static void TestandoVar() {
			// usando VAR, a ideia é usar pra facilitar:
			// antes:
			// ContaCorrente conta = new ContaCorrente(111, 2222);
			// depois:
			var conta = new ContaCorrente(111, 2222); // aceita o var pois dps vc dá o que é no caso a ContaCorrente que já está definido o tipo

			var idade = 10; // ele sabe o que é idade pq ele le o tipo int dps
			var nome = "Alura"; // ele sabe o que é nome pq ele le o tipo string dps

			//List<int> idades = new List<int>();
			var idades = new List<int>();
		}

		static void TestaSort() {
			// sort : ordenando

			// como já sabemos oq queremos dentro, já adicionamos direto
			var nomes = new List<string>() {
				"Wellignthon",
				"Guilherme",
				"Luana",
				"Luane",
				"Zeus",
				"Ana"
			};

			nomes.Sort();

			foreach (var nome in nomes) {
				Console.WriteLine(nome);
			}

			Console.WriteLine();

			var idades = new List<int>();

			idades.Add(5);
			idades.Add(29);
			idades.Add(50);
			idades.AdicionarVarios(99, -1);
			idades.Sort();

			for (int i = 0; i < idades.Count; i++) {
				Console.WriteLine(idades[i]);
			}

		}
	}
}
