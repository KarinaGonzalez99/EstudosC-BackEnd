using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_OperadoresDeConjuntos
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] seq1 = { "janeiro", "fevereiro", "março" };
			string[] seq2 = { "fevereiro", "MARÇO", "abril" };

			// concatenação de duas sequencias
			Console.WriteLine("Concatenando duas sequências");
			var consulta = seq1.Concat(seq2);
			foreach (var item in consulta)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine();

			// união de duas sequencias
			Console.WriteLine("União de duas sequências");
			var consulta2 = seq1.Union(seq2);
			foreach (var item in consulta2)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine();

			// uniao de duas sequencias com comparador
			Console.WriteLine("União de duas sequências com comparador");
			var consulta3 = seq1.Union(seq2, StringComparer.InvariantCultureIgnoreCase); // ignora diferença entre maiscula e minuscula
			foreach (var item in consulta3)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine();

			// interseção de duas sequencias
			Console.WriteLine("Interseção de duas sequências"); // elemento em comum
			var consulta4 = seq1.Intersect(seq2);
			foreach (var item in consulta4)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine();

			Console.WriteLine("Exceto: elementos de seq1 que não estão em seq2");
			var consulta5 = seq1.Except(seq2);
			foreach (var item in consulta5)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine();
		}
	}
}
