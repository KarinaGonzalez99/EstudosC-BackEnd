using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Actions
{
	internal class FINALIZADO : EstadoDeUmOrcamento
	{
		public void AplicaDescontoExtra(Orcamento orcamento)
		{
			throw new Exception("Orcamentos finalizados nao recebem desconto extra");
		}

		public void Aprova(Orcamento orcamento)
		{
			throw new Exception("O orçamento já está atualizado");
		}
		public void Reprova(Orcamento orcamento)
		{
			throw new Exception("O orçamento já está atualizado");
		}
		public void Finaliza(Orcamento orcamento)
		{
			throw new Exception("O orçamento já está atualizado");
		}
	}
}
