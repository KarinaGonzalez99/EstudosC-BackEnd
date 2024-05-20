using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Jagged
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// família 1: Família Flinstones
			//família 2: Família Simpsons
			//família 3: Família Dona Florinda

			// jagged array =  arrayserrilhado
			string[][] familias = new string[3][];
			// não podemos chamar dessa forma o jagged
			//{
			//	{ "Fred", "Wilma", "Pedrita"},
			//	{ "Homer", "Marge", "Lisa", "Bart", "Maggie" },
			//	{ "Florinda", "Kiko"}
			//};
			familias[0] = new string[] { "Fred", "Wilma", "Pedrita" };
			familias[1] = new string[] { "Homer", "Marge", "Lisa", "Bart", "Maggie" };
			familias[2] = new string[] { "Florinda", "Kiko" };


			foreach (var familia in familias)
			{
				Console.WriteLine(string.Join(",", familia));
			}
		}
	}
}
