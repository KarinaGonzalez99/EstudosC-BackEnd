using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia {
	internal class Program {
		static void Main(string[] args) {

				ListaDeObject listaDeIdades = new ListaDeObject();
			listaDeIdades.Adicionar(10);
			listaDeIdades.Adicionar(5);
			listaDeIdades.Adicionar(4);
			listaDeIdades.AdicionarVarios(16, 23, 60);


			for(int i = 0; i < listaDeIdades.Tamanho; i++) {
				// como é object e ele não pode voltar int, transformamos o object em int
				int idade = (int)listaDeIdades[i];
				Console.WriteLine($"Idade no indice {i}: {idade}");
			}










			Console.ReadLine();


			ListaDeContaCorrente lista = new ListaDeContaCorrente(1);

			ContaCorrente contaDoGui = new ContaCorrente(1111, 22222);
			lista.Adicionar(contaDoGui);
			//Console.WriteLine("CONTA DO GUI CRIADA");

			lista.Adicionar(new ContaCorrente(874, 5679787));
			lista.Adicionar(new ContaCorrente(874, 5679754));
			lista.Adicionar(new ContaCorrente(874, 5679745));
			lista.Adicionar(new ContaCorrente(874, 5679787));
			lista.Adicionar(new ContaCorrente(874, 5679754));
			lista.Adicionar(new ContaCorrente(874, 5679745));
			lista.Adicionar(new ContaCorrente(874, 5679787));
			lista.Adicionar(new ContaCorrente(874, 5679754));
			lista.Adicionar(new ContaCorrente(874, 5679745));
			//
			//lista.Adicionar(new ContaCorrente(874, 5679787));
			//lista.Adicionar(new ContaCorrente(874, 5679754));
			//lista.Adicionar(new ContaCorrente(874, 5679745));
			//lista.Adicionar(new ContaCorrente(874, 5679787));
			//lista.Adicionar(new ContaCorrente(874, 5679754));
			//lista.Adicionar(new ContaCorrente(874, 5679745));
			//lista.Adicionar(new ContaCorrente(874, 5679787));
			//lista.Adicionar(new ContaCorrente(874, 5679754));
			//lista.Adicionar(new ContaCorrente(874, 5679745));

			lista.EscreverListaNaTela();

			lista.Remover(contaDoGui);
            //Console.WriteLine("CONTA DO GUI REMOVIDA");

            lista.EscreverListaNaTela();


			lista.MeuMetodo();
			lista.MeuMetodo(numero: 10); // dessa maneira eu defino apenas um com o valor que eu quero
            Console.WriteLine();
			Console.WriteLine();


			for (int i = 0; i < lista.Tamanho; i++) {
				ContaCorrente itemAtual = lista[i];
				Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
			}
		}

		static void TestaArrayInt() {
			// array
			int[] idades = new int[5];
			idades[0] = 50;
			idades[1] = 15;
			idades[2] = 10;
			idades[3] = 30;
			idades[4] = 1;

			int acumulador = 0;
			for (int indice = 0; indice < idades.Length; indice++) {
				int idade = idades[indice];
				Console.WriteLine($"Acessando o array idades no índice {indice}");
				Console.WriteLine($"Valor de idades[{indice}] = {idade}");
				acumulador += idade;

			}
			int media = acumulador / idades.Length;
			Console.WriteLine($"Media de idades = {media}");
		}

		static void TestaArrayDeContaCorrente() {
			ContaCorrente[] contas = new ContaCorrente[] {
				new ContaCorrente(123, 456789),
				new ContaCorrente(456, 123789),
				new ContaCorrente(789, 456123)
			};


			for (int i = 0; i < contas.Length; i++) {
				ContaCorrente contaAtual = contas[i];
				Console.WriteLine($"Conta {i} {contaAtual.Numero}");
			}
		}

		// quando queremos passar todos os itens de um array sem precisar dar uma quantidade usamos o params
		static int SomarVarios(params int[] numeros) {
			int acumaldor = 0;
			// ao inves de usar um for, podemos usar um foreach quando não precisamos lidar com indice
			foreach(int numero in numeros) {
				acumaldor += numero;
			}
			return acumaldor;
		}
	}
}
