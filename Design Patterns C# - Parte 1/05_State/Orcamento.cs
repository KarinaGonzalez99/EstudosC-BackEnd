using _05_State.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_State
{
	public class Orcamento
	{
		public EstadoDeUmOrcamento EstadoAtual { get; set; }


		public double Valor { get; set; }
		public IList<Item> Itens { get; private set; }

		public Orcamento(double valor)
		{
			Valor = valor;
			Itens = new List<Item>();
			EstadoAtual = new EM_APROVACAO();
		}

		public void AdicionaItem(Item item)
		{
			Itens.Add(item);
		}

		public void AplicaDescontoExtra()
		{
			EstadoAtual.AplicaDescontoExtra(this);
		}	

		public void Aprova()
		{
			EstadoAtual.Aprova(this);
		}
		public void Reprova()
		{
			EstadoAtual.Reprova(this);
		}
		public void Finaliza()
		{
			EstadoAtual.Finaliza(this);
		}
	}
}

