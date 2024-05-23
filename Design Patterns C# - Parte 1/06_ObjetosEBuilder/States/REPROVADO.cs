using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ObjetosEBuilder
{
	internal class REPROVADO : EstadoDeUmOrcamento
	{
		public void AplicaDescontoExtra(Orcamento orcamento)
		{
			throw new Exception("Orcamentos reprovados nao recebem desconto extra");
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
