using _01_DesingPatterns2.Cap5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DesingPatterns2.Cap4
{
	 class Soma : IExpressao
	{
		public IExpressao Esquerda { get; private set; }
		public IExpressao Direita { get; private set; }


		public Soma(IExpressao esquerda, IExpressao direita)
		{
			Esquerda = esquerda;
			Direita = direita;
		}

		public int Avalia()
		{
			int valorEsquerda = Esquerda.Avalia();
			int valorDireita = Direita.Avalia();
			return valorEsquerda + valorDireita;
		}

		public void Aceita(Impressora impressora)
		{
			impressora.ImprimeSoma(this);
		}
	}
}
