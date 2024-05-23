using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MethodImposto
{
	public class IKCV : TemplateDeImpostoCondicional
	{
		public override bool TaxMax(Orcamento orcamento)
		{
			return orcamento.Valor > 500 && itemMaiorQue100Reais(orcamento);
		}

		public override double TaxacaoMax(Orcamento orcamento)
		{
				return orcamento.Valor * 0.1;
		}
		public override double TaxacaoMin(Orcamento orcamento)
		{
			return orcamento.Valor * 0.06;
		}
					

		private bool itemMaiorQue100Reais(Orcamento orcamento)
		{
			foreach (Item item in orcamento.Itens)
			{
				if (item.Valor > 100) return true;
			}
			return false;
		}
	}
}
