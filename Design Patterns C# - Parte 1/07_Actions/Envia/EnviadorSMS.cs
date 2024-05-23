using _07_Actions.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Actions.Envia
{
	class EnviadorSMS : AcaoAposGerarNota
	{
		public void Executa(NotaFiscal nf)
		{
			Console.WriteLine("Simulando evio por email!");
		}
	}
}
