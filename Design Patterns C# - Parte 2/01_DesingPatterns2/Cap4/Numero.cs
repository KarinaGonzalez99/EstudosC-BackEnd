using _01_DesingPatterns2.Cap5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DesingPatterns2.Cap4
{
	class Numero : IExpressao
	{
		public int Valor { get; private set; }
		public Numero(int numero)
		{
			Valor = numero;
		}

		public int Avalia()
		{
			return Valor;
		}
		public void Aceita(Impressora impressora)
		{
			impressora.ImprimeNumero(this);
		}
	}
}

