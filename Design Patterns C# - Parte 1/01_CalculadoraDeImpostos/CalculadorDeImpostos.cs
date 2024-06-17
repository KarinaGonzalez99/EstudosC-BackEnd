using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CalculadoraDeImpostos
{
	public class CalculadorDeImpostos
	{
		//  **************** NÃO DA PRA CRIAR INFINITOS IF A CADA NOVO IMPOSTO *************************
		//public void RealizaCalculo(Orcamento orcamento, String imposto)
		//{
		//	if ("ICMS".Equals(imposto))
		//	{
		//		//double icms = orcamento.Valor * 0.1;
		//		double icms = new ICMS().CalculaICMS(orcamento);
		//		Console.WriteLine(icms);
		//	}
		//	else if ("ISS".Equals(imposto))
		//	{
		//		//double iss = orcamento.Valor * 0.06;
		//		double iss = new ISS().CalculaISS(orcamento);
		//		Console.WriteLine(iss);
		//	}
		//}

		// **************** NÃO DA PRA TER QUE FICAR CRIANDO UM NOVO CONSTRUTOR A CADA IMPOSTO CRIADO *************************
		//public void RealizaCalculoICMS(Orcamento orcamento)
		//{
		//	//double icms = orcamento.Valor * 0.1;
		//	double icms = new ICMS().CalculaICMS(orcamento);
		//	Console.WriteLine(icms);
		//}

		//public void RealizaCalculoIss(Orcamento orcamento)
		//{
		//	//double iss = orcamento.Valor * 0.06;
		//	double iss = new ISS().CalculaISS(orcamento);
		//	Console.WriteLine(iss);
		//}

		//  **************** CRIAMOS A INTERFACE IMPOSTO E COLOCAMOS DE HERANÇA EM CADA CLASSE DE IMPOSTO CRIADO *************************
		public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
		{
				//double icms = orcamento.Valor * 0.1;
				double impostosGenericos = imposto.Calcula(orcamento);
				Console.WriteLine(impostosGenericos);

		}
	}
}
