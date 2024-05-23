using _02_CalculadoraDeImpostos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CalculaImposto
{
	internal class Program
	{
		static void Main(string[] args)
		{
			CalculadorDeDescontos calculador = new CalculadorDeDescontos();

			Orcamento orcamento = new Orcamento(500);
			orcamento.AdicionaItem(new Item("Caneta", 250));
			orcamento.AdicionaItem(new Item("Lapis", 250));
			orcamento.AdicionaItem(new Item("Geladeira", 250));
			orcamento.AdicionaItem(new Item("Microondas", 250));
			orcamento.AdicionaItem(new Item("Forno", 250));
			orcamento.AdicionaItem(new Item("Tesoura", 250));

			double desconto = calculador.Calcula(orcamento);
			Console.WriteLine(desconto);

		}
	}
}
