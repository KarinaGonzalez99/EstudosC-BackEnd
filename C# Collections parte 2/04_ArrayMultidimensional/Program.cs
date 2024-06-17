using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ArrayMultidimensional
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[,] resultados = new string[3, 3]
				{
				{"Alemanha", "Espanha", "Itália"}, // vencedores de  2014
				{"Argentina", "Holanda", "França"}, // vencedores de  2010
				{"Holanda", "Alemanha", "Alemanha"}, // vencedores de  2006
			};

			for (int copa = 0; copa < 3; copa++)
			{
				int ano = 2014 - copa * 4;
				Console.Write(ano.ToString().PadRight(12));
			}
			Console.WriteLine();

			for (int posicao = 0; posicao < 3; posicao++)
			{
				for (int copa = 0; copa < 3; copa++)
				{
					Console.Write(resultados[posicao, copa].PadRight(12));
				}
				Console.WriteLine();
			}
		}
	}
}
