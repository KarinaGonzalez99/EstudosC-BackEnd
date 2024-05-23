using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ObjetosEBuilder
{
	public class ISS : Imposto
	{
		//reescreveer construtor, pq construtores nao são herdados
		public ISS(Imposto outroImposto) : base(outroImposto) { }

		public ISS() : base() { }

		public override double Calcula(Orcamento orcamento)
		{
			return orcamento.Valor * 0.06 + CalculoOutroImposto(orcamento);
		}
	}
}
