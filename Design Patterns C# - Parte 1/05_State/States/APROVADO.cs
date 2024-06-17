using _05_State.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_State
{
	internal class APROVADO : EstadoDeUmOrcamento
	{
		public void AplicaDescontoExtra(Orcamento orcamento)
		{
			orcamento.Valor -= (orcamento.Valor * 0.02);
		}
		public void Aprova(Orcamento orcamento)
		{
			throw new Exception("O orcamento já estáem estado de aprovação");
		}
		public void Reprova(Orcamento orcamento)
		{
			throw new Exception("O orcamento está em processo de aprovação");
		}
		public void Finaliza(Orcamento orcamento)
		{
			orcamento.EstadoAtual = new FINALIZADO();
		}
	}
}
