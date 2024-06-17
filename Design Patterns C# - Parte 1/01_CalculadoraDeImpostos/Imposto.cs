using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CalculadoraDeImpostos
{
	public interface Imposto
	{
		double Calcula(Orcamento orcamento);
	}
}
