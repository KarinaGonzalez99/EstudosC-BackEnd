using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Covariancia
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// conversão implicita de string pra obj
			string titulo = "meses";
			object obj = titulo;
			Console.WriteLine(obj);

			Console.WriteLine("List<string> para List<object>");

			IList<string> listaMeses = new List<string>
			{
				"Janeiro", "Fevereiro", "Março",
				"Abril", "Maio", "Junho",
				"Julho", "Agosto", "Setembro",
				"Outubro", "Novembro", "Dezembro"
			};
			//IList<object> listaObj = listaMeses; // n consegue ilist string em ilist object
			Console.WriteLine();

			// testando array de string em arrau de objects
			Console.WriteLine("string[] para object[]?");
			string[] arrayMeses = new string[]
			{
				"Janeiro", "Fevereiro", "Março",
				"Abril", "Maio", "Junho",
				"Julho", "Agosto", "Setembro",
				"Outubro", "Novembro", "Dezembro"
			};
			object[] arrayObj = arrayMeses; //COVARIÂNCIA!
			Console.WriteLine(arrayObj);
			foreach (var item in arrayObj)
			{
				Console.WriteLine(item);
			}
            Console.WriteLine();

            arrayObj[0] = "PRIMEIRO MÊS";
			Console.WriteLine(arrayObj[0]);
			Console.WriteLine();

			//arrayObj[0] = 12345;
			//Console.WriteLine(arrayObj[0]);
			//Console.WriteLine();

			Console.WriteLine("List<string> para IEnumerable<object>");
            Console.WriteLine();

            IEnumerable<object> enumObj = listaMeses; //COVARIÂNCIA
			foreach (var item in enumObj)
			{
				Console.WriteLine(item);
			}
			//enumObj[0] = 12345;
		}
	}
}
