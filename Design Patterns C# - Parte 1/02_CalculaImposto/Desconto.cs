using _02_CalculadoraDeImpostos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CalculaImposto
{
	public interface Desconto
	{
		double Desconta(Orcamento orcamento);
		Desconto Proximo { get; set; }
	}
}
