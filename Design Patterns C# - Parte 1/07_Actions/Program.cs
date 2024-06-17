using _07_Actions.Envia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Actions
{
	internal class Program
	{
		static void Main(string[] args)
		{
			CriadorDeNotaFiscal criador = new CriadorDeNotaFiscal();
			criador.ParaEmpresa("SADASD");
			criador.ComCnpj("12.123.123/1234-12");

			criador.ComItem(new ItemDaNota("Item 1", 100.0));
			criador.ComItem(new ItemDaNota("Item 2", 200.0));
			criador.NaDataAtual();
			criador.ComObservacoes("Uma obs qualquer");

			criador.AdicionaAcao(new EnviadorDeEmail());
			criador.AdicionaAcao(new SalvaBD());
			criador.AdicionaAcao(new EnviadorSMS());


			NotaFiscal nf = criador.Constroi();
			Console.WriteLine(nf.ValorBruto);
			Console.WriteLine(nf.Impostos);

		}
	}
}
