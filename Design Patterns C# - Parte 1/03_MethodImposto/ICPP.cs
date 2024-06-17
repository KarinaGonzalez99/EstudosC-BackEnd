using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MethodImposto
{
	public class ICPP : TemplateDeImpostoCondicional
	{
		public override bool TaxMax(Orcamento orcamento)
		{
			return orcamento.Valor >= 500;
		}

		public override double TaxacaoMax(Orcamento orcamento)
		{
			return orcamento.Valor * 0.07;
		}
		public override double TaxacaoMin(Orcamento orcamento)
		{
			return orcamento.Valor * 0.05;
		}
	}
}
