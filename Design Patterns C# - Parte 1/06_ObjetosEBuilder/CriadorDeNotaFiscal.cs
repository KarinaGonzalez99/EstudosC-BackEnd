using System;
using System.Collections;
using System.Collections.Generic;

namespace _06_ObjetosEBuilder
{
	public class CriadorDeNotaFiscal
	{
		public string RazaoSocial { get; private set; }
		public string Cnpj { get; private set; }
		public string Observacoes { get; private set; }
		public DateTime Data {  get; private set; }
		private double valorTotal;
		private double impostos;
		private IList<ItemDaNota> todosItens = new List<ItemDaNota>();

		public void ComObservacoes(string observacoes)
		{
			Observacoes = observacoes;
		}

		public void ParaEmpresa(string razaoSocial)
		{
			RazaoSocial = razaoSocial;
		}

		public void ComCnpj(string cnpj)
		{
			Cnpj = cnpj;
		}
		public void ComItem(ItemDaNota item)
		{
			todosItens.Add(item);
			valorTotal += item.Valor;
			impostos += item.Valor * 0.05;
		}
		public void NaDataAtual()
		{
			Data = DateTime.Now;
		}

		public NotaFiscal Constroi()
		{
			return new NotaFiscal(RazaoSocial, Cnpj, Data, valorTotal, impostos.ToString(), todosItens, Observacoes);
		}
	}
}