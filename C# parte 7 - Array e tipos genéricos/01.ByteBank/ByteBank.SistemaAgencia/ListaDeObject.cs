using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia {
	public class ListaDeObject {
		private object[] _itens;
		// criar campo pra ver o indice do array
		private int _proximaPosicao;

		public int Tamanho {
			get {
				return _proximaPosicao;
			}
		}


		// pra não ser obrigatorio colocar uma quantidade, e sim opcional, podemos iniciar com 5 se a pessoa não quiser declarar
		//um valor
		public ListaDeObject(int capacidadeInicial = 5) {
			_itens = new object[capacidadeInicial];
			_proximaPosicao = 0;
		}

		public void Adicionar(object item) {
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

			object[] novoArray = new object[novoTamanho];

			for (int i = 0; i < _itens.Length; i++) {
				novoArray[i] = _itens[i];
			}

			_itens = novoArray;

		}

		public void Remover(object item) {
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
				object conta = _itens[i];
				//Console.WriteLine($"Conta no indice {i}: numero {conta.Agencia} {conta.Numero}");
			}
		}

		public object GetItemNoIndice(int indice) {
			if (indice < 0 || indice >= _proximaPosicao) {
				throw new ArgumentOutOfRangeException(nameof(indice));
			}
			return _itens[indice];

		}

		public object this[int indice] {
			get {
				return GetItemNoIndice(indice);
			}
		}

		public void AdicionarVarios(params object[] itens) {
			foreach (object item in itens) {
				Adicionar(item);
			}
		}

		public void MeuMetodo(string opcional = "uihdasfusdhf", int numero = 5) {

		}
	}
}
