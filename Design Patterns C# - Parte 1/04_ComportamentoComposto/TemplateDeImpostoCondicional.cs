using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ComportamentoComposto
{
	public abstract class TemplateDeImpostoCondicional : Imposto
	{
		public override double Calcula(Orcamento orcamento)
		{
			if (TaxMax(orcamento))
			{
				return TaxacaoMax(orcamento);
			}
			return TaxacaoMin(orcamento);
		}

		public abstract bool TaxMax(Orcamento orcamento);
		public abstract double TaxacaoMax(Orcamento orcamento);
		public abstract double TaxacaoMin(Orcamento orcamento);
	}
}
