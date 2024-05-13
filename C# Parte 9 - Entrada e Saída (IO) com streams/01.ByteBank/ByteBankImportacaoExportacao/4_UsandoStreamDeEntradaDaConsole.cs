using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao {
	partial class Program {

		static void UsarStreamDeEntrada() {
			// openStarndardInput recupera o metodo de entrada(que digitamos no console com o readline rodando
			using (var fluxoDeEntrada = Console.OpenStandardInput())
			using (var fs = new FileStream("entradaConsole.txt", FileMode.Create)) {
				// vamos guardar a informação

				var buffer = new byte[1024];

				// laço de repetição pra podermos sempre digitar e nos mostrar o byte lido
				while (true) {
					var bytesLidos = fluxoDeEntrada.Read(buffer, 0, 1024);
					fs.Write(buffer, 0, bytesLidos);
					fs.Flush();
					Console.WriteLine($"Bytes lidos da consol0e: {bytesLidos}");
				}
			}
		}

	}
}
