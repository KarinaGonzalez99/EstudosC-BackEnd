﻿namespace _02_CalculadoraDeImpostos
{
	public class Item
	{
		public string Nome { get; private set; }
		public double Valor { get; private set; }

		public Item(string nome, double valor)
		{
			Nome = nome;
			Valor = valor;
		}
	}
}