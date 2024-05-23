using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_State
{
	public abstract class Imposto
	{
		// criando o outro imposto pta fazermos o composto com a ideia de que os impostos se somam (basicamente)
		public Imposto OutroImposto { get; set; }

		public Imposto(Imposto outroImposto)
		{
			OutroImposto = outroImposto;
		}

		// implementando pois sem ele, acabamos sendo obrigados a colocar em looping imposto sob imposto
		public Imposto()
		{
			OutroImposto = null;
		}

		public abstract double Calcula(Orcamento orcamento);

		protected double CalculoOutroImposto(Orcamento orcamento)
		{
			if (OutroImposto == null) return 0;
			return OutroImposto.Calcula(orcamento);

		}
	}
}
