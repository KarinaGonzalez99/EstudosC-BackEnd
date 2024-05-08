using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia {
	public class ListaDeContaCorrente {

		private ContaCorrente[] _itens;
		// criar campo pra ver o indice do array
		private int _proximaPosicao;

		public int Tamanho {
			get {
				return _proximaPosicao;
			}
		}


		// pra não ser obrigatorio colocar uma quantidade, e sim opcional, podemos iniciar com 5 se a pessoa não quiser declarar
		//um valor
		public ListaDeContaCorrente(int capacidadeInicial = 5) {
			_itens = new ContaCorrente[capacidadeInicial];
			_proximaPosicao = 0;
		}

		public void Adicionar(ContaCorrente item) {
			VerificarCapacidade(_proximaPosicao + 1);
			//Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");
			_itens[_proximaPosicao] = item;
			_proximaPosicao++;
		}


		// verifica seo o array tem capacidade suficiente pra armazenar itens, se não ele cria um novo array com capacidade
		//suficiente e copia os intens do antifo pro novo , além de atualizar que o _itens aponta pro novo array
		private void VerificarCapacidade(int tamanhoNecessario) {
			if (_itens.Length >= tamanhoNecessario) {
				return;
			}

			// se for longo a lista, fica lento, pra isso vamos criar:
			int novoTamanho = _itens.Length * 2;
			if (novoTamanho < tamanhoNecessario) {
				novoTamanho = tamanhoNecessario;
			}

			//Console.WriteLine("Aumentando capacidade da lista!");

			ContaCorrente[] novoArray = new ContaCorrente[novoTamanho];

			for (int i = 0; i < _itens.Length; i++) {
				novoArray[i] = _itens[i];
			}

			_itens = novoArray;

		}

		public void Remover(ContaCorrente item) {
			// vamos descobrir o indice que queremos remover
			int indiceItem = -1; // pra sinalizar que é um valor invalido

			for (int i = 0; i < _proximaPosicao; i++) {
				// nao usamos == compara referencias e queremos comparar a equivalencia por isso usamos o equals
				if (_itens[i].Equals(item)) {
					indiceItem = i;
					break;
				}
			}
			for (int i = indiceItem; i < _proximaPosicao; i++) {
				_itens[i] = _itens[i + 1];
			}
			_proximaPosicao--;
			_itens[_proximaPosicao] = null;
		}

		public void EscreverListaNaTela() {
			for (int i = 0; i < _proximaPosicao; i++) {
				ContaCorrente conta = _itens[i];
				//Console.WriteLine($"Conta no indice {i}: numero {conta.Agencia} {conta.Numero}");
			}
		}

		public ContaCorrente GetItemNoIndice(int indice) {
			if (indice < 0 || indice >= _proximaPosicao) {
				throw new ArgumentOutOfRangeException(nameof(indice));
			}
			return _itens[indice];

		}

		public ContaCorrente this[int indice] {
			get {
				return GetItemNoIndice(indice);
			}
		}

		public void MeuMetodo(string opcional = "uihdasfusdhf", int numero = 5) {

		}

	}
}
