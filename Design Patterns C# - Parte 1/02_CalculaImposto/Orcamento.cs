using _02_CalculaImposto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CalculadoraDeImpostos
{
	public class Orcamento
	{
		public double Valor { get; set; }
		public IList<Item> Itens { get; private set; }

		public Orcamento(double valor)
		{
			Valor = valor;
			Itens = new List<Item>();
		}

		public void AdicionaItem(Item item)
		{
			Itens.Add(item);
		}
	}
}

