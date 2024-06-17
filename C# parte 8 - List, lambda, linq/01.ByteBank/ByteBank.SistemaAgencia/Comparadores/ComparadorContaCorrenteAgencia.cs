using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia.Comparadores {
	public class ComparadorContaCorrenteAgencia : IComparer<ContaCorrente> {
		public int Compare(ContaCorrente x, ContaCorrente y) {
			// o problema de fazer assim é que se mudar no futuro terá que ou sibsituir ou criar um novo
			x.Agencia.CompareTo(y.Agencia);
			return x.Agencia.CompareTo(y.Agencia);
			// Essa logica acaba sendo longa e repetitiva, então usamos o CompareTo
			//if (y == null && x == null) {
			//	return 1;
			//}

			//if (x.Agencia < y.Agencia) {
			//	return -1;
			//}

			//if (x.Agencia == y.Agencia) {
			//	return 0;
			//}

			//return 1;


		}
	}
}
