using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ObjetosEBuilder
{
	public class NotaFiscal
	{
		public string RazaoSocial { get; set; }
		public string Cnpj { get; set; }
		public DateTime DataDeEmissao { get; set; }
		public double ValorBruto { get; set; }
		public string Impostos { get; set; }
		public IList<ItemDaNota> itens { get; set; }
		public string Observacoes { get; set; }

		public NotaFiscal(string razaoSocial, string cnpj, DateTime dataDeEmissao, double valorBruto, string impostos, IList<ItemDaNota> itens, string observacoes)
		{
			RazaoSocial = razaoSocial;
			Cnpj = cnpj;
			DataDeEmissao = dataDeEmissao;
			ValorBruto = valorBruto;
			Impostos = impostos;
			this.itens = itens;
			Observacoes = observacoes;
		}
	}
}
