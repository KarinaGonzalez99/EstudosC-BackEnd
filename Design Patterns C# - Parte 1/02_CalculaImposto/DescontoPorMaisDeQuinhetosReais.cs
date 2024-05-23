using _02_CalculadoraDeImpostos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CalculaImposto
{
	public class DescontoPorMaisDeQuinhetosReais : Desconto
	{
		public Desconto Proximo {  get; set; }
		public double Desconta(Orcamento orcamento)
		{
			if (orcamento.Valor > 500.00)
			{
				return orcamento.Valor * 0.07;
			}

			return Proximo.Desconta(orcamento);
		}
	}
}
