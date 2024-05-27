using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DesingPatterns2.Cap3
{
	class Historico
	{
		private IList<Estado> Estados = new List<Estado>();
		public void Adiciona(Estado estado)
		{
			Estados.Add(estado);
		}

		public Estado Pega(int indice)
		{
			return Estados[indice];
		}
	}
}
