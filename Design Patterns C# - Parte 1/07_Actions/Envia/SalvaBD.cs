using _07_Actions.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Actions.Envia
{
	class SalvaBD : AcaoAposGerarNota
	{
		public void Executa(NotaFiscal nf)
		{
			Console.WriteLine("Simulando salvar no bando de dados!");
		}
	}
}
