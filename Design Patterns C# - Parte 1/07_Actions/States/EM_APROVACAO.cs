using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Actions
{
	internal class EM_APROVACAO : EstadoDeUmOrcamento
	{
		public void AplicaDescontoExtra(Orcamento orcamento)
		{
			orcamento.Valor = orcamento.Valor - (orcamento.Valor * 0.05);
		}

		public void Aprova(Orcamento orcamento)
		{
			orcamento.EstadoAtual = new APROVADO();
		}
		public void Reprova(Orcamento orcamento)
		{
			orcamento.EstadoAtual = new REPROVADO();
		}
		public void Finaliza(Orcamento orcamento)
		{
			throw new Exception("O orcamento em aprovação não pode finalizar");
		}
	}
}
