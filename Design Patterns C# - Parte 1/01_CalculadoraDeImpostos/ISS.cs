using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CalculadoraDeImpostos
{
	public class ISS : Imposto
	{
		public double Calcula(Orcamento orcamento)
		{
			return orcamento.Valor * 0.06;
		}
	}
}
