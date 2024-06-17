using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack {
	internal class Program {
		static void Main(string[] args) {
			var navegador = new Navegador();

			navegador.NavegarPara("google.com");
			navegador.NavegarPara("caelum.com.br");
			navegador.NavegarPara("alura.com.br");
			Console.WriteLine();
			navegador.Anterior();
			navegador.Anterior();
			navegador.Anterior();
            Console.WriteLine();
			navegador.Proximo();
			navegador.Proximo();
		}
	}
}
