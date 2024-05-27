using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DesingPatterns2.Cap7
{
	public class Pedido
	{
		public string Cliente { get; private set; }
		public double Valor { get; private set; }
		public DateTime DataFinalizacao { get; private set; }
		public Status Status { get; private set; }

        public Pedido(string cliente, double valor)
        {
            Cliente = cliente;
			Valor = valor;
			Status = Status.Novo;
        }

		public void Paga()
		{
			Status = Status.Pago;
		}

		public void Finaliza()
		{
			Status = Status.Entregue;
			DataFinalizacao = DateTime.Now;
		}
	}
}
