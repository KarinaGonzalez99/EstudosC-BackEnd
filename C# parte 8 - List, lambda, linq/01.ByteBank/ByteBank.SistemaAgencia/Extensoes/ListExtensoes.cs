using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia.Extensoes {
	public static class ListExtensoes {
		// colocamos aqui por organização
		// T pra podermos escolher o tipo - deixamos o metodo generico
		public static void AdicionarVarios<T>(this List<T> listaDeInteiros, params T[] itens) {
			foreach (T i in itens) {
				listaDeInteiros.Add(i);
			}
		}
	}
}
