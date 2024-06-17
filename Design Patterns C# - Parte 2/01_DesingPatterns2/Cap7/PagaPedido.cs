using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DesingPatterns2.Cap7
{
	class PagaPedido : IComando
	{
		private Pedido Pedido;

		public PagaPedido(Pedido pedido)
		{
			Pedido = pedido;
		}

		public void Executa()
		{
            Console.WriteLine("Pagando o pedido do cliente {0}", Pedido.Cliente);
            Pedido.Paga();
		}
	}
}
